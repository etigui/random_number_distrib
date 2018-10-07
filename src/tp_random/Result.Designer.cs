namespace tp_random
{
    partial class Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CH_values = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TB_result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CH_values)).BeginInit();
            this.SuspendLayout();
            // 
            // CH_values
            // 
            chartArea1.Name = "ChartArea1";
            this.CH_values.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CH_values.Legends.Add(legend1);
            this.CH_values.Location = new System.Drawing.Point(12, 12);
            this.CH_values.Name = "CH_values";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CH_values.Series.Add(series1);
            this.CH_values.Size = new System.Drawing.Size(553, 300);
            this.CH_values.TabIndex = 0;
            this.CH_values.Text = "chart1";
            // 
            // TB_result
            // 
            this.TB_result.Location = new System.Drawing.Point(12, 318);
            this.TB_result.Multiline = true;
            this.TB_result.Name = "TB_result";
            this.TB_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_result.Size = new System.Drawing.Size(553, 81);
            this.TB_result.TabIndex = 1;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 407);
            this.Controls.Add(this.TB_result);
            this.Controls.Add(this.CH_values);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Result";
            this.Text = "Result";
            this.Shown += new System.EventHandler(this.Result_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CH_values)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CH_values;
        private System.Windows.Forms.TextBox TB_result;
    }
}