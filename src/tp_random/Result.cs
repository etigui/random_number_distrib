/*****************************
Auteur:     Florian Meret
			Etienne Guignard
Date:       12.10.2016
Name:       convolution.h
Projet:     Convolution 2D
Version:    1.0
*******************************/

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tp_random
{
    public partial class Result : Form
    {
        private string average = null;
        private string standard_deviation = null;
        private string variance = null;
        private string rand_type = null;
        private string max_draw = null;
        private int[] values = null;

        public string Average{
            get { return average; }
            set { average = value; }
        }
        public string Standard_deviation{
            get { return standard_deviation; }
            set { standard_deviation = value; }
        }
        public string Variance{
            get { return variance; }
            set { variance = value; }
        }
        public string Rand_type{
            get { return rand_type; }
            set { rand_type = value; }
        }
        public string Max_draw
        {
            get { return max_draw; }
            set { max_draw = value; }
        }
        public int[] Values{
            get { return values; }
            set { values = value; }
        }     

        public Result() {
            InitializeComponent();
        }

        private void Result_Shown(object sender, EventArgs e) {

            // Form title
            this.Text = rand_type ?? "not defined";

            // Show if average, rand_type and variance
            TB_result.Text = text_result();

            // Display chart
            CH_values.Titles.Add(rand_type ?? "not defined");
            CH_values.Series[0].IsVisibleInLegend = false;
            double start = 0.05;
            CH_values.Series[0]["PixelPointWidth"] = "44";
            CH_values.ChartAreas[0].AxisX.Interval = 0.1;
            CH_values.ChartAreas[0].AxisX.Maximum = 1.0;
            CH_values.ChartAreas[0].AxisX.Minimum = 0.0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++) {
                CH_values.Series[0].Points.AddXY(start, values[i]);
                CH_values.Series[0].Points[i].Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)); ;
                start = start + 0.1 ;
            }      
        }

        private string text_result() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{nameof(average)} = {average ?? "not defined"}");
            sb.AppendLine($"{nameof(standard_deviation)} = {standard_deviation ?? "not defined"}");
            sb.AppendLine($"{nameof(variance)} = {variance ?? "not defined"}");
            sb.AppendLine($"{nameof(max_draw)} = {max_draw ?? "not defined"}");
            return sb.ToString();
        }
    }
}
