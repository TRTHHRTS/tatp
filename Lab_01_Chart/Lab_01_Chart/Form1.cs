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

        private decimal startNum;
        private decimal endNum;
        private int pointCount;
        private List<int> list;
        private readonly Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            startNum = Convert.ToDecimal(startNumTextBox.Text);
            endNum = Convert.ToDecimal(endNumTextBox.Text);
            pointCount = Convert.ToInt32(pointCountTextBox.Text);
            var res = getMeasures(startNum, endNum, pointCount);
            drawChart(res);
            tabsId.SelectTab(chartTab);

        }


        private void getRandomNumbers(decimal count)
        {
            decimal i = 0;
            list = new List<int>();
            while (i++ < count)
            {
                list.Add(rnd.Next());
            }
        }

        private void drawChart(long[] res)
        {
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "List.Sort()";
            foreach (var t in res)
                chart1.Series[0].Points.AddY(t);
        }

        private long[] getMeasures(decimal start, decimal end, int count)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();

            var res = new long[count];
            var fraction = Math.Round((end - start)/(count-1));
            for (int i = 0; i < count; i++)
            {
                var tempPointer = (fraction*(i)) + start;
                getRandomNumbers(tempPointer);
                var tries = new long[5];
                for (var j = 0; j < 5; j++)
                {
                    myStopwatch.Start();
                    // Тут вызываем разные сортировки, передаем как параметр
                    list.Sort();
                    myStopwatch.Stop();
                    tries[j] = myStopwatch.ElapsedMilliseconds;
                }
                Array.Sort(tries);
                res[i] = tries[2];
            }
            return res;
        }
    }
}
