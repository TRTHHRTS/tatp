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

        private int startNum;
        private int endNum;
        private int pointCount;
        //private List<int> list;
        private int[] array;
        private long[][] res;
        private readonly Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            startNum = Convert.ToInt32(startNumTextBox.Text);
            endNum = Convert.ToInt32(endNumTextBox.Text);
            pointCount = Convert.ToInt32(pointCountTextBox.Text);
            getMeasures(startNum, endNum, pointCount);
            //drawChart();
            tabsId.SelectTab(chartTab);

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
            
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "List.Sort()";
            chart1.Series[1].Points.Clear();
            chart1.Series[1].Name = "Quicksort";
            chart1.Series[2].Points.Clear();
            chart1.Series[2].Name = "Heapsort";
            for (int i = 0; i < pointCount; i++)
            {
                chart1.Series[0].Points.AddXY(i, res[0][i]);
                chart1.Series[1].Points.AddXY(i, res[1][i]);
                chart1.Series[2].Points.AddXY(i, res[2][i]);
                //TODO debug
                //Console.WriteLine("res[0]["+i+"]="+ res[0][i]+ ",res[1]["+i+"]="+ res[1][i]);
            }
        }

        private void getMeasures(decimal start, decimal end, int count)
        {
            var context = TaskScheduler.FromCurrentSynchronizationContext();
            res = new long[3][];
            res[0] = new long[count];
            res[1] = new long[count];
            res[2] = new long[count];
            var fraction = Math.Round((end - start)/(count-1));
            for (int i = 0; i < count; i++)
            {
                var tempPointer = (fraction * (i)) + start;
                getRandomNumbers(tempPointer);

                int cur = new int();
                cur = i;
                Task task1 = Task.Factory.StartNew(() => runSortInThread(cur, SORT_TYPE.SORT))
                    .ContinueWith(t =>
                    {
                        drawChart();
                    }, CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion, context);
                Task.Factory.StartNew(() => runSortInThread(cur, SORT_TYPE.QUICKSORT))
                    .ContinueWith(t =>
                    {
                        drawChart();
                    }, CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion, context);
                Task.Factory.StartNew(() => runSortInThread(cur, SORT_TYPE.HEAPSORT))
                    .ContinueWith(t =>
                    {
                        drawChart();
                    }, CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion, context);
            }
        }

        private void runSortInThread(int i, SORT_TYPE type)
        {
            Console.WriteLine(type.ToString() + " started, i="+i);
            res[(int)type][i] = Sorts.getSortTime(type, array);
            Console.WriteLine(type.ToString() + " finished, i=" + i);
        }

        private void resetSettingsBtn_Click(object sender, EventArgs e)
        {
            startNumTextBox.Text = "";
            endNumTextBox.Text = "";
            pointCountTextBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            drawChart();
            //chart1.Update();
        }
    }
}
