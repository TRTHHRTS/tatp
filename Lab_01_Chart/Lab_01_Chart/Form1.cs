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
            int i = 0;
            //list = new List<int>();
            array = new int[Convert.ToInt32(count)];
            while (i++ < count)
            {
                array[i] = rnd.Next();
                //list.Add(rnd.Next());
            }
        }

        private void drawChart(long[][] res)
        {
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "List.Sort()";
            chart1.Series[1].ChartType = SeriesChartType.Spline;
            chart1.Series[1].Points.Clear();
            chart1.Series[1].Name = "Quicksort";

            foreach (var t in res)
                chart1.Series[0].Points.AddY(t);
        }

        private long[][] getMeasures(decimal start, decimal end, int count)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();

            var res = new long[3, count];
            var fraction = Math.Round((end - start)/(count-1));
            for (int i = 0; i < count; i++)
            {
                var tempPointer = (fraction*(i)) + start;
                getRandomNumbers(tempPointer);
                var tries = new long[3, 5];
                for (var j = 0; j < 5; j++)
                {
                    // Тут вызываем разные сортировки, передаем как параметр
                    myStopwatch.Start();
                    Array.Sort(array);
                    myStopwatch.Stop();
                    tries[0, j] = myStopwatch.ElapsedMilliseconds;
                    myStopwatch.Start();
                    //TODO переделать нормальный вызов через новый метод
                    Quicksort.quicksort(array, 0, array.Length);
                    myStopwatch.Stop();
                    tries[1, j] = myStopwatch.ElapsedMilliseconds;
                }
                //Array.Sort(tries);
                foreach (var temp in tries)
                {
                    Console.WriteLine(temp);
                }
                Console.WriteLine();
                //tries[0, 0]
                res[0, i] = tries[0, 2];
                res[1, i] = tries[1, 2];
            }
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
