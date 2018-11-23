using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace TIMC
{
    public partial class Form4 : Form
    {
        NonInterrupted NonInterrupted;
        public Form4(object distribution)
        {
            InitializeComponent();
            NonInterrupted = distribution as NonInterrupted;
            XiEmpir.Text = NonInterrupted.XiEmpir.ToString();
            foreach (var pair in NonInterrupted.StatisticalDistribution)
            {
                DataGridViewCell x = new DataGridViewTextBoxCell();
                DataGridViewCell m = new DataGridViewTextBoxCell();
                DataGridViewCell pn = new DataGridViewTextBoxCell();
                x.Value = pair.Key;
                m.Value = pair.Value;
                pn.Value = NonInterrupted.NormalRelativeFrequencyDistribution[pair.Key] * NonInterrupted.Sample.Count;
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(m, pn);
                GridViewFirst.Rows.Add(row);
            }
            for (int i=0;i<NonInterrupted.NormalRelativeFrequencyDistributionAfterCombine.Count;i++)
            {
                DataGridViewCell m = new DataGridViewTextBoxCell();
                DataGridViewCell pn = new DataGridViewTextBoxCell();
                m.Value = NonInterrupted.StatisticalDistributionAfterCombine[i];
                pn.Value = NonInterrupted.NormalRelativeFrequencyDistributionAfterCombine[i];
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(m, pn);
                GridViewSecond.Rows.Add(row);
            }
        }

        private void CheckH_Click(object sender, EventArgs e)
        {
            int df = NonInterrupted.N1 - 3;
            if(df<=0)
            {
                Vysnovok.Text = "Ступінь вільності менше рівне нуля!";
                Vysnovok.Visible = true;
                return;
            }
            XiCritical.Text = NonInterrupted.GetXiCritical(df, Double.Parse(comboBox1.Text)).ToString();
            if (NonInterrupted.XiEmpir >= NonInterrupted.XiCritical)
            {
                Vysnovok.Text = "Оскільки Хі емпіричне\nбільше за Хі критичне \n Гіпотезу відхиляємо";
            }
            else
            {
                Vysnovok.Text = "Оскільки Хі емпіричне\nменше за Хі критичне \n Гіпотезу приймаємо";
            }
            Vysnovok.Visible = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
