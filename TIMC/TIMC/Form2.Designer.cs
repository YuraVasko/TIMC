namespace TIMC
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EmpiricFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FriquencyPoligon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FrequencyDiagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpiricFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriquencyPoligon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.05198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.94802F));
            this.tableLayoutPanel1.Controls.Add(this.EmpiricFunction, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FriquencyPoligon, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1892, 446);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // EmpiricFunction
            // 
            this.EmpiricFunction.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.EmpiricFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.EmpiricFunction.Legends.Add(legend1);
            this.EmpiricFunction.Location = new System.Drawing.Point(3, 3);
            this.EmpiricFunction.Name = "EmpiricFunction";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Емпірична функція розподілу";
            this.EmpiricFunction.Series.Add(series1);
            this.EmpiricFunction.Size = new System.Drawing.Size(940, 440);
            this.EmpiricFunction.TabIndex = 3;
            this.EmpiricFunction.Text = "chart3";
            // 
            // FriquencyPoligon
            // 
            chartArea2.Name = "ChartArea1";
            this.FriquencyPoligon.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.FriquencyPoligon.Legends.Add(legend2);
            this.FriquencyPoligon.Location = new System.Drawing.Point(949, 3);
            this.FriquencyPoligon.Name = "FriquencyPoligon";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "Полігон частот";
            this.FriquencyPoligon.Series.Add(series2);
            this.FriquencyPoligon.Size = new System.Drawing.Size(940, 440);
            this.FriquencyPoligon.TabIndex = 4;
            this.FriquencyPoligon.Text = "chart2";
            // 
            // FrequencyDiagram
            // 
            this.FrequencyDiagram.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea3.Name = "ChartArea1";
            this.FrequencyDiagram.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.FrequencyDiagram.Legends.Add(legend3);
            this.FrequencyDiagram.Location = new System.Drawing.Point(460, 513);
            this.FrequencyDiagram.Name = "FrequencyDiagram";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Діаграма частот";
            this.FrequencyDiagram.Series.Add(series3);
            this.FrequencyDiagram.Size = new System.Drawing.Size(956, 449);
            this.FrequencyDiagram.TabIndex = 6;
            this.FrequencyDiagram.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(33, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1889, 36);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Графічне представлення статистичного матеріалу";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1924, 985);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FrequencyDiagram);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpiricFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriquencyPoligon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmpiricFunction;
        private System.Windows.Forms.DataVisualization.Charting.Chart FriquencyPoligon;
        private System.Windows.Forms.DataVisualization.Charting.Chart FrequencyDiagram;
        private System.Windows.Forms.TextBox textBox1;
    }
}