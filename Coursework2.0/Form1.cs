using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Coursework2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void funcBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void leftBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rightBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void epsilonBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            
            string func = "f(x) = " + funcBox.Text;
            double epsilon = Convert.ToDouble(epsilonBox.Text);
            double b = Convert.ToDouble(rightBox.Text);

            double a = Convert.ToDouble(leftBox.Text);

            string path = filePathBox.Text + "\\" + fileNameBox.Text + ".txt";
            MessageBox.Show(Methods.Fib(true, func, a, b, epsilon, path).ToString());

        }


        private void colorBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].MarkerColor = Color.Red;
        }

        private void orangebtn_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].MarkerColor = Color.Orange;
        }
        private void goldbtn_Click(object sender, EventArgs e)
        {

            this.chart1.Series[0].MarkerColor = Color.Gold;
        }

        private void linebtn_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].MarkerColor = Color.Lime;
        }


        private void bluebtn_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].MarkerColor = Color.Blue;
        }

        private void indigobtn_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].MarkerColor = Color.Indigo;
        }

        private void thickBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void thickBox_Leave(object sender, EventArgs e)
        {

            try
            {
                this.chart1.Series[0].MarkerSize = Int32.Parse(thickBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You need to write size!");
                
            }
            
        }

        private void graphStepBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void graphbtn_Click(object sender, EventArgs e)
        {

            string func = "f(x) = " + funcBox.Text;
            double step = 0.1;
            try
            {
                step = Convert.ToDouble(graphStepBox.Text);
            } catch(Exception ex)
            {
                MessageBox.Show("Enter step");
            }
            
            double b = Convert.ToDouble(rightBox.Text);

            double a = Convert.ToDouble(leftBox.Text);


            this.chart1.Series[0].Points.Clear();
            double x, y;
            x = a;
            do
            {
                y = Methods.func(func, x);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += step;
            } while (x <= b);

        }

        private void circlebtn_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
        }

        private void squarebtn_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].MarkerStyle = MarkerStyle.Square;
        }

        private void diamondbtn_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].MarkerStyle = MarkerStyle.Diamond;
        }

        private void starbtn_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].MarkerStyle = MarkerStyle.Star5;
        }

        private void filepathbtn_Click(object sender, EventArgs e)
        {
            filePathBox.Text = null;
            folderBrowserDialog1.ShowDialog();
            filePathBox.Text = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Dispose();
        }

        private void filePathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

    }
}

