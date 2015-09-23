using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_01_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int TOTAL_SORT_COUNT = 4;
        public static int ATTEMPTS = 5;
        public static int ATTEMT_NUMBER_TO_USE = 3;

        private int startNum;
        private int endNum;
        private int pointCount;

        private int[] array;
        private long[][] res;
        private readonly Random rnd = new Random();

        private Task task;
        private CancellationTokenSource token;
        private CancellationToken ct;

        private void button1_Click(object sender, EventArgs e)
        {
            if (startNumTextBox.Text.Length == 0 || endNumTextBox.Text.Length == 0 || pointCountTextBox.Text.Length == 0)
            {
                MessageBox.Show("Заполните входные данные");
                return;
            }
            startNum = Convert.ToInt32(startNumTextBox.Text);
            endNum = Convert.ToInt32(endNumTextBox.Text);
            pointCount = Convert.ToInt32(pointCountTextBox.Text);

            progressBar1.Maximum = pointCount*TOTAL_SORT_COUNT;

            var context = TaskScheduler.FromCurrentSynchronizationContext();
            token = new CancellationTokenSource();
            ct = token.Token;

            task = Task.Factory.StartNew(() =>
            {
                try
                {
                    getMeasures(startNum, endNum, pointCount);
                }
                catch (AggregateException ee)
                {
                    MessageBox.Show("Отменено пользователем.");
                }
                finally
                {
                    token.Dispose();
                }
                
            })
                    .ContinueWith(t =>
                    {
                        drawChart();
                        tabsId.SelectTab(chartTab);
                    }, ct, TaskContinuationOptions.OnlyOnRanToCompletion, context);
        }


        private void getRandomNumbers(decimal count)
        {
            array = new int[Convert.ToInt32(count)];
            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next();
            }
        }

        private void drawChart()
        {
            for (int i = 0; i < TOTAL_SORT_COUNT; i++)
            {
                chart1.Series[i].Points.Clear();
            }
            for (int i = 0; i < pointCount; i++)
            {
                for (int j = 0; j < TOTAL_SORT_COUNT; j++)
                {
                    chart1.Series[j].Points.AddXY(i+1, res[j][i]);
                }
            }
        }

        private void getMeasures(decimal start, decimal end, int count)
        {
            try
            {
                res = new long[TOTAL_SORT_COUNT][];
                for (var i = 0; i < TOTAL_SORT_COUNT; i++)
                {
                    res[i] = new long[count];
                }
                var fraction = Math.Round((end - start)/(count - 1));
                for (var i = 0; i < count; i++)
                {
                    var tempPointer = (fraction*(i)) + start;
                    getRandomNumbers(tempPointer);
                    for (int k = 0; k < TOTAL_SORT_COUNT; k++)
                    {
                        // проверяем, не отменил ли пользователь операцию
                        ct.ThrowIfCancellationRequested();

                        res[k][i] = Sorts.getSortTime((SORT_TYPE) k, array);
                        BeginInvoke(new MethodInvoker(delegate
                        {
                            progressBar1.Increment(1);
                        }));
                    }
                }
            }
            catch (OperationCanceledException oce)
            {
                MessageBox.Show("Отменено пользователем.");
            }
            finally
            {
                token.Dispose();
                BeginInvoke(new MethodInvoker(delegate
                {
                    progressBar1.Value = 0;
                }));
            }
        }

        private void resetSettingsBtn_Click(object sender, EventArgs e)
        {
            startNumTextBox.Text = "";
            endNumTextBox.Text = "";
            pointCountTextBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            startNumTextBox.Text = "1000";
            endNumTextBox.Text = "100000";
            pointCountTextBox.Text = "10";
            progressBar1.Value = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            token?.Cancel();
        }
    }
}
