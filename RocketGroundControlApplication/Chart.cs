using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RocketGroundControl
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            disableAll();
            if (comboBox1.Text.Equals("Acceleration"))
            {
                yAxisLabel.Text = "Acceleration X (Blue)\nAcceleration Y(Green)\nAcceleration Z(Red)";
                chart1.Series[3].Enabled = true;
                chart1.Series[4].Enabled = true;
                chart1.Series[5].Enabled = true;
            }
            else if (comboBox1.Text.Equals("Orientation"))
            {
                yAxisLabel.Text = "Yaw\nPitch\nRoll";
                chart1.Series[9].Enabled = true;
                chart1.Series[10].Enabled = true;
                chart1.Series[11].Enabled = true;
            }
            else if (comboBox1.Text.Equals("Velocity"))
            {
                yAxisLabel.Text = "Velocity X(Blue)\nVelocity Y(Green)\nVelocity Z(Red)";
                chart1.Series[6].Enabled = true;
                chart1.Series[7].Enabled = true;
                chart1.Series[8].Enabled = true;
            }
            else if (comboBox1.Text.Equals("Pressure"))
            {
                yAxisLabel.Text = "Pressure";
                chart1.Series[0].Enabled = true;
            }
            else if (comboBox1.Text.Equals("Altitude"))
            {
                yAxisLabel.Text = "Altitude";
                chart1.Series[2].Enabled = true;
            }
            else
            {
                yAxisLabel.Text = "Temperature";
                chart1.Series[1].Enabled = true;
            }
            scale();
        }

        private void disableAll()
        {
            for (int i = 0; i < 12; i++ )
                chart1.Series[i].Enabled = false;
        }

        public void addPoint(int series, double x, double y)
        {
            chart1.Series[series].Points.AddXY(x, y);
            scale();
        }

        private void scale()
        {
            if (chart1.Series[0].Enabled)
            {
                chart1.ChartAreas[0].Axes[1].Maximum = highestPoint(0);
                chart1.ChartAreas[0].Axes[1].Minimum = lowestPoint(0);
                chart1.ChartAreas[0].Axes[0].Maximum = highestX(0);
            }
            else if(chart1.Series[1].Enabled)
            {
                chart1.ChartAreas[0].Axes[1].Maximum = highestPoint(1);
                chart1.ChartAreas[0].Axes[1].Minimum = lowestPoint(1);
                chart1.ChartAreas[0].Axes[0].Maximum = highestX(1);
            }
            else if (chart1.Series[2].Enabled)
            {
                chart1.ChartAreas[0].Axes[1].Maximum = highestPoint(2);
                chart1.ChartAreas[0].Axes[1].Minimum = lowestPoint(2);
                chart1.ChartAreas[0].Axes[0].Maximum = highestX(2);
            }
            else if (chart1.Series[3].Enabled)
            {
                chart1.ChartAreas[0].Axes[1].Maximum = max(highestPoint(3), highestPoint(4), highestPoint(5));
                chart1.ChartAreas[0].Axes[1].Minimum = low(lowestPoint(3), lowestPoint(4), lowestPoint(5));
                chart1.ChartAreas[0].Axes[0].Maximum = highestX(3);
            }
            else if (chart1.Series[6].Enabled)
            {
                chart1.ChartAreas[0].Axes[1].Maximum = max(highestPoint(6), highestPoint(7), highestPoint(8));
                chart1.ChartAreas[0].Axes[1].Minimum = low(lowestPoint(6), lowestPoint(7), lowestPoint(8));
                chart1.ChartAreas[0].Axes[0].Maximum = highestX(6);
            }
            else
            {
                chart1.ChartAreas[0].Axes[1].Maximum = max(highestPoint(9), highestPoint(10), highestPoint(11));
                chart1.ChartAreas[0].Axes[1].Minimum = low(lowestPoint(9), lowestPoint(10), lowestPoint(11));
                chart1.ChartAreas[0].Axes[0].Maximum = highestX(9);
            }
        }

        private double max(double num1, double num2, double num3)
        {
            double max = 0;

            if (num1 > num2)
            {
                if (num1 > num3)
                    max = num1;
                else
                    max = num3;
            }
            else if (num2 > num3)
            {
                max = num2;
            }
            else
                max = num3;

            return max;
        }

        private double low(double num1, double num2, double num3)
        {
            double low = 0;

            if (num1 < num2)
            {
                if (num1 < num3)
                    low = num1;
                else
                    low = num3;
            }
            else if (num2 < num3)
            {
                low = num2;
            }
            else
                low = num3;

            return low;
        }

        private double highestPoint(int series)
        {
            double max = 0;
            for (int i = 0; i < chart1.Series[series].Points.Count; i++ )
            {
                if (chart1.Series[series].Points[i].YValues[0] > max)
                    max = chart1.Series[series].Points[i].YValues[0];
            }
                return max;
        }
        
        private double highestX(int series)
        {
            double max = 0;
            for (int i = 0; i < chart1.Series[series].Points.Count; i++)
            {
                if (chart1.Series[series].Points[i].XValue > max)
                    max = chart1.Series[series].Points[i].XValue;
            }
            return max;
        }

        private double lowestPoint(int series)
        {
            double low = 0;
            for (int i = 0; i < chart1.Series[series].Points.Count; i++)
            {
                if (chart1.Series[series].Points[i].YValues[0] < low)
                    low = chart1.Series[series].Points[i].YValues[0];
            }
            return low;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Chart_Load(object sender, EventArgs e)
        {

        }
    }
}
