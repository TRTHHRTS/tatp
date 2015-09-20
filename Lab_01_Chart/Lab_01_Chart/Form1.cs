using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private readonly Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            startNum = Convert.ToInt32(startNumTextBox.Text);
            endNum = Convert.ToInt32(endNumTextBox.Text);
            pointCount = Convert.ToInt32(pointCountTextBox.Text);
            var res = getMeasures(startNum, endNum, pointCount);
            drawChart(res);
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

        private void drawChart(long[][] res)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "List.Sort()";
            chart1.Series[1].Points.Clear();
            chart1.Series[1].Name = "Quicksort";
            for (int i = 0; i < pointCount; i++)
            {
                chart1.Series[0].Points.AddXY(i, res[0][i]);
                chart1.Series[1].Points.AddXY(i, res[1][i]);
                Console.WriteLine("res[0]["+i+"]="+ res[0][i]+ ",res[1]["+i+"]="+ res[1][i]);
            }
        }

        private long[][] getMeasures(decimal start, decimal end, int count)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();

            var res = new long[3][];
            var fraction = Math.Round((end - start)/(count-1));
            var tries = new long[3][];
            tries[0] = new long[count];
            tries[1] = new long[count];
            for (int i = 0; i < count; i++)
            {
                var tempPointer = (fraction*(i)) + start;
                getRandomNumbers(tempPointer);

                // Тут вызываем разные сортировки, передаем как параметр
                var attempts = new long[5];
                for (var j = 0; j < 5; j++)
                {
                    myStopwatch.Start();
                    Array.Sort(array);
                    myStopwatch.Stop();
                    attempts[j] = myStopwatch.ElapsedMilliseconds;
                }
                Array.Sort(attempts);
                tries[0][i] = attempts[2];
                attempts = new long[5];
                for (var j = 0; j < 5; j++)
                {
                    //TODO переделать нормальный вызов через новый метод
                    myStopwatch.Start();
                    Quicksort.quicksort(array, 0, array.Length - 1);
                    myStopwatch.Stop();
                    attempts[j] = myStopwatch.ElapsedMilliseconds;
                }
                Array.Sort(attempts);
                tries[1][i] = attempts[2];
            }
            res[0] = tries[0];
            res[1] = tries[1];
            return res;
        }

        private void resetSettingsBtn_Click(object sender, EventArgs e)
        {
            startNumTextBox.Text = "";
            endNumTextBox.Text = "";
            pointCountTextBox.Text = "";

        }
    }
}
