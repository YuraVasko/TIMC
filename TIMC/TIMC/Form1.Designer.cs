namespace TIMC
{
    partial class Form1
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
            this.Discrete = new System.Windows.Forms.Button();
            this.Uninterrupted = new System.Windows.Forms.Button();
            this.From = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.TextBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.Element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.DyscreteButton = new System.Windows.Forms.Button();
            this.NonInteruptedButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Discrete
            // 
            this.Discrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discrete.Location = new System.Drawing.Point(321, 554);
            this.Discrete.Name = "Discrete";
            this.Discrete.Size = new System.Drawing.Size(234, 75);
            this.Discrete.TabIndex = 0;
            this.Discrete.Text = "Дискретна статистична змінна";
            this.Discrete.UseVisualStyleBackColor = true;
            this.Discrete.Click += new System.EventHandler(this.Discrete_Click);
            // 
            // Uninterrupted
            // 
            this.Uninterrupted.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uninterrupted.Location = new System.Drawing.Point(38, 554);
            this.Uninterrupted.Name = "Uninterrupted";
            this.Uninterrupted.Size = new System.Drawing.Size(234, 75);
            this.Uninterrupted.TabIndex = 1;
            this.Uninterrupted.Text = "Неперервна статистична змінна";
            this.Uninterrupted.UseVisualStyleBackColor = true;
            this.Uninterrupted.Click += new System.EventHandler(this.Uninterrupted_Click);
            // 
            // From
            // 
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(212, 135);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(270, 36);
            this.From.TabIndex = 2;
            this.From.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // To
            // 
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(212, 224);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(270, 36);
            this.To.TabIndex = 3;
            this.To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "ВІД";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "ДО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "ВВЕДІТЬ ПРОМІЖОК";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 58);
            this.label4.TabIndex = 7;
            this.label4.Text = "ВВЕДІТЬ ПОТУЖНІСТЬ \r\nВИБІРКИ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // power
            // 
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(145, 452);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(307, 36);
            this.power.TabIndex = 8;
            this.power.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataTable
            // 
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Element,
            this.P,
            this.Number});
            this.DataTable.Location = new System.Drawing.Point(671, 142);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.Size = new System.Drawing.Size(951, 596);
            this.DataTable.TabIndex = 27;
            // 
            // Element
            // 
            this.Element.HeaderText = "Елемент";
            this.Element.Name = "Element";
            this.Element.ReadOnly = true;
            this.Element.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // P
            // 
            this.P.HeaderText = "Частота";
            this.P.Name = "P";
            // 
            // Number
            // 
            this.Number.HeaderText = "Ймовірність";
            this.Number.Name = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1013, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Частотна таблиця";
            // 
            // DyscreteButton
            // 
            this.DyscreteButton.Location = new System.Drawing.Point(321, 876);
            this.DyscreteButton.Name = "DyscreteButton";
            this.DyscreteButton.Size = new System.Drawing.Size(209, 85);
            this.DyscreteButton.TabIndex = 39;
            this.DyscreteButton.Text = "Зчитати дані про дискретну статистичну змінна з файлу";
            this.DyscreteButton.UseVisualStyleBackColor = true;
            this.DyscreteButton.Click += new System.EventHandler(this.DyscreteButton_Click);
            // 
            // NonInteruptedButton
            // 
            this.NonInteruptedButton.Location = new System.Drawing.Point(38, 876);
            this.NonInteruptedButton.Name = "NonInteruptedButton";
            this.NonInteruptedButton.Size = new System.Drawing.Size(209, 85);
            this.NonInteruptedButton.TabIndex = 40;
            this.NonInteruptedButton.Text = "Зчитати дані про непервну статистичну змінну з файлу";
            this.NonInteruptedButton.UseVisualStyleBackColor = true;
            this.NonInteruptedButton.Click += new System.EventHandler(this.NonInteruptedButton_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(671, 800);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 107);
            this.button1.TabIndex = 42;
            this.button1.Text = "Переглянути гафічне представлення статистичного матеріалу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1018, 800);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 107);
            this.button2.TabIndex = 43;
            this.button2.Text = "Переглянути числові характеристики статистичного матеріалу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1351, 800);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 107);
            this.button3.TabIndex = 44;
            this.button3.Text = "Перевірити правельність висунутої гіпотези, щодо нормального розподілу генерально" +
    "ї сукупності ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 982);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NonInteruptedButton);
            this.Controls.Add(this.DyscreteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.power);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.Uninterrupted);
            this.Controls.Add(this.Discrete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Discrete;
        private System.Windows.Forms.Button Uninterrupted;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox power;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DyscreteButton;
        private System.Windows.Forms.Button NonInteruptedButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Element;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.Button button3;
    }
}

