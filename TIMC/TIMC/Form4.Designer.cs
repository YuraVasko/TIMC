namespace TIMC
{
    partial class Form4
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
            this.GridViewFirst = new System.Windows.Forms.DataGridView();
            this.EmpirImov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriticalImov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GridViewSecond = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.XiEmpir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CheckH = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.XiCritical = new System.Windows.Forms.TextBox();
            this.Vysnovok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewFirst
            // 
            this.GridViewFirst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewFirst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpirImov,
            this.CriticalImov});
            this.GridViewFirst.Location = new System.Drawing.Point(594, 91);
            this.GridViewFirst.Name = "GridViewFirst";
            this.GridViewFirst.RowTemplate.Height = 24;
            this.GridViewFirst.Size = new System.Drawing.Size(563, 417);
            this.GridViewFirst.TabIndex = 0;
            // 
            // EmpirImov
            // 
            this.EmpirImov.HeaderText = "m(i)";
            this.EmpirImov.Name = "EmpirImov";
            // 
            // CriticalImov
            // 
            this.CriticalImov.HeaderText = "np(i)";
            this.CriticalImov.Name = "CriticalImov";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(448, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(816, 36);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Критерій Пірсона";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(448, 542);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(816, 36);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Кінцева таблиця (np(i)>=10 та m(i) >=5) ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GridViewSecond
            // 
            this.GridViewSecond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSecond.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.GridViewSecond.Location = new System.Drawing.Point(594, 654);
            this.GridViewSecond.Name = "GridViewSecond";
            this.GridViewSecond.RowTemplate.Height = 24;
            this.GridViewSecond.Size = new System.Drawing.Size(563, 315);
            this.GridViewSecond.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "m(i)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "np(i)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Xi емпіричне";
            // 
            // XiEmpir
            // 
            this.XiEmpir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XiEmpir.Location = new System.Drawing.Point(96, 103);
            this.XiEmpir.Name = "XiEmpir";
            this.XiEmpir.Size = new System.Drawing.Size(159, 36);
            this.XiEmpir.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(336, 29);
            this.label9.TabIndex = 36;
            this.label9.Text = "Виберіть рівень значущості";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0.01",
            "0.025",
            "0.05",
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "0.95",
            "0.975",
            "0.99"});
            this.comboBox1.Location = new System.Drawing.Point(96, 268);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 33);
            this.comboBox1.TabIndex = 37;
            // 
            // CheckH
            // 
            this.CheckH.Location = new System.Drawing.Point(122, 362);
            this.CheckH.Name = "CheckH";
            this.CheckH.Size = new System.Drawing.Size(104, 50);
            this.CheckH.TabIndex = 38;
            this.CheckH.Text = "Перевірити гіпотезу";
            this.CheckH.UseVisualStyleBackColor = true;
            this.CheckH.Click += new System.EventHandler(this.CheckH_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Xi критичне";
            // 
            // XiCritical
            // 
            this.XiCritical.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XiCritical.Location = new System.Drawing.Point(99, 525);
            this.XiCritical.Name = "XiCritical";
            this.XiCritical.Size = new System.Drawing.Size(159, 36);
            this.XiCritical.TabIndex = 40;
            // 
            // Vysnovok
            // 
            this.Vysnovok.AutoSize = true;
            this.Vysnovok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vysnovok.Location = new System.Drawing.Point(96, 687);
            this.Vysnovok.Name = "Vysnovok";
            this.Vysnovok.Size = new System.Drawing.Size(0, 29);
            this.Vysnovok.TabIndex = 41;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 996);
            this.Controls.Add(this.Vysnovok);
            this.Controls.Add(this.XiCritical);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CheckH);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.XiEmpir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GridViewSecond);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GridViewFirst);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewFirst;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView GridViewSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox XiEmpir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CheckH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox XiCritical;
        private System.Windows.Forms.Label Vysnovok;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpirImov;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriticalImov;
    }
}