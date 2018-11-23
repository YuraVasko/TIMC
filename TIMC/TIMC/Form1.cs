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
using BLL;

namespace TIMC
{
    public partial class Form1 : Form
    {
        DyscreteDistribution DyscreteDistribution;
        NonInterrupted NonInterrupted;
        List<double> FashionVal;
        List<double> Variations;
        double MedianaVal;
        double AverageSelectiveVal;
        double MathematicaHopeVal;
        double SamplingRateVal;
        double DispersionVal;
        double FlucktoationVal;
        double VariationVal;
        double AsymetryVal;
        double ExcitementVal;
        double CentralMomentVal;

        public Form1()
        { 
            InitializeComponent();
                    
            button3.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void Discrete_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            NonInterrupted = null;
            DataTable.Rows.Clear();
            DyscreteDistribution = new DyscreteDistribution();
            DyscreteDistribution.GenerateSample(Int32.Parse(this.power.Text), Int32.Parse(this.From.Text), Int32.Parse(this.To.Text));
            DyscreteDistribution.GenerateVariationSeries();
            Variations = DyscreteDistribution.VariationSeries;
            DyscreteDistribution.GenerateStatisticalDistribution();
            DyscreteDistribution.GenerateRelativeFrequencyDistribution();
            DyscreteDistribution.GenerateEmpiricalFunctionData();
            DyscreteDistribution.CalculateMathematicalHope();
            DyscreteDistribution.CalculateDispersion();
            FashionVal = DyscreteDistribution.Fashion;
            MedianaVal = DyscreteDistribution.Mediana;
            AverageSelectiveVal = DyscreteDistribution.AverageSelective;
            MathematicaHopeVal = DyscreteDistribution.MathematicalHope;
            SamplingRateVal = DyscreteDistribution.SamplingRate;
            DispersionVal = DyscreteDistribution.Dispersion;
            FlucktoationVal = DyscreteDistribution.Flucktoation;
            VariationVal = DyscreteDistribution.Variation;
            AsymetryVal = DyscreteDistribution.Asymentry;
            ExcitementVal = DyscreteDistribution.Excitement;
            foreach (var pair in DyscreteDistribution.StatisticalDistribution)
            {
                DataGridViewCell x = new DataGridViewTextBoxCell();
                DataGridViewCell n = new DataGridViewTextBoxCell();
                DataGridViewCell p = new DataGridViewTextBoxCell();
                x.Value = pair.Key;
                n.Value = pair.Value;
                p.Value = DyscreteDistribution.RelativeFrequencyDistribution[pair.Key];
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(x, n, p);
                DataTable.Rows.Add(row);
            }
        }


        private void Uninterrupted_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            DyscreteDistribution = null;
            NonInterrupted = new NonInterrupted();
            NonInterrupted.ReadLaplassValues();
            DataTable.Rows.Clear();
            NonInterrupted.GenerateSampleAndVariationSeries(Int32.Parse(this.power.Text), Double.Parse(this.From.Text), Double.Parse(this.To.Text));
            NonInterrupted.GenerateStatisticalDistribution();
            NonInterrupted.GenerateRelativeFrequencyDistribution();
            NonInterrupted.GenerateEmpiricalFunctionData();

            NonInterrupted.CalculateMathematicalHope();
            NonInterrupted.CalculateDispersion();
            NonInterrupted.GenerateNormalRelativeFrequencyDistribution();
            FashionVal = NonInterrupted.Fashion;
            MedianaVal = NonInterrupted.Mediana;
            AverageSelectiveVal = NonInterrupted.AverageSelective;
            MathematicaHopeVal = NonInterrupted.MathematicalHope;
            SamplingRateVal = NonInterrupted.SamplingRate;
            DispersionVal = NonInterrupted.Dispersion;
            FlucktoationVal = NonInterrupted.Flucktoation;
            VariationVal = NonInterrupted.Variation;
            AsymetryVal = NonInterrupted.Asymentry;
            ExcitementVal = NonInterrupted.Excitement;
            Variations = NonInterrupted.Sample;

            foreach (var pair in NonInterrupted.StatisticalDistribution)
            {
                DataGridViewCell x = new DataGridViewTextBoxCell();
                DataGridViewCell n = new DataGridViewTextBoxCell();
                DataGridViewCell m = new DataGridViewTextBoxCell();
                //DataGridViewCell p = new DataGridViewTextBoxCell();
                x.Value = pair.Key;
                n.Value = pair.Value;
                m.Value = NonInterrupted.RelativeFrequencyDistribution[pair.Key];
                //p.Value = NonInterrupted.NormalRelativeFrequencyDistribution[pair.Key];
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(x, n, m);
                DataTable.Rows.Add(row);
            }
        }

        private void DyscreteButton_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            DyscreteDistribution = new DyscreteDistribution();
            DyscreteDistribution.GetSampleFromFile();
            From.Text = DyscreteDistribution.Variants.ElementAt(0).ToString();
            To.Text = DyscreteDistribution.Variants.ElementAt(DyscreteDistribution.Variants.Count - 1).ToString();
            power.Text = DyscreteDistribution.Sample.Count().ToString();


            DataTable.Rows.Clear();
            DyscreteDistribution.GenerateVariationSeries();
            Variations = DyscreteDistribution.VariationSeries;
            DyscreteDistribution.GenerateStatisticalDistribution();
            DyscreteDistribution.GenerateRelativeFrequencyDistribution();
            DyscreteDistribution.GenerateEmpiricalFunctionData();

            DataPoint point;
            point = new DataPoint(DyscreteDistribution.Variants.ElementAt(0), 0);
            point.IsEmpty = true;
            DyscreteDistribution.CalculateMathematicalHope();
            DyscreteDistribution.CalculateDispersion();
            FashionVal = DyscreteDistribution.Fashion;
            MedianaVal = DyscreteDistribution.Mediana;
            AverageSelectiveVal = DyscreteDistribution.AverageSelective;
            MathematicaHopeVal = DyscreteDistribution.MathematicalHope;
            SamplingRateVal = DyscreteDistribution.SamplingRate;
            DispersionVal = DyscreteDistribution.Dispersion;
            FlucktoationVal = DyscreteDistribution.Flucktoation;
            VariationVal = DyscreteDistribution.Variation;
            AsymetryVal = DyscreteDistribution.Asymentry;
            ExcitementVal = DyscreteDistribution.Excitement;
            foreach (var pair in DyscreteDistribution.StatisticalDistribution)
            {
                DataGridViewCell x = new DataGridViewTextBoxCell();
                DataGridViewCell n = new DataGridViewTextBoxCell();
                DataGridViewCell p = new DataGridViewTextBoxCell();
                x.Value = pair.Key;
                n.Value = pair.Value;
                p.Value = DyscreteDistribution.RelativeFrequencyDistribution[pair.Key];
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(x, n, p);
                DataTable.Rows.Add(row);
            }
        }

        private void NonInteruptedButton_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            NonInterrupted = new NonInterrupted();
            NonInterrupted.GetSampleFromFile();
            From.Text = NonInterrupted.From.ToString();
            To.Text = NonInterrupted.To.ToString();
            power.Text = NonInterrupted.Sample.Count.ToString();
            NonInterrupted.ReadLaplassValues();
            DataTable.Rows.Clear();
            NonInterrupted.GenerateStatisticalDistribution();
            NonInterrupted.GenerateRelativeFrequencyDistribution();
            NonInterrupted.GenerateEmpiricalFunctionData();
            NonInterrupted.CalculateMathematicalHope();
            NonInterrupted.CalculateDispersion();
            NonInterrupted.GenerateNormalRelativeFrequencyDistribution();
            FashionVal = NonInterrupted.Fashion;
            MedianaVal = NonInterrupted.Mediana;
            AverageSelectiveVal = NonInterrupted.AverageSelective;
            MathematicaHopeVal = NonInterrupted.MathematicalHope;
            SamplingRateVal = NonInterrupted.SamplingRate;
            DispersionVal = NonInterrupted.Dispersion;
            FlucktoationVal = NonInterrupted.Flucktoation;
            VariationVal = NonInterrupted.Variation;
            AsymetryVal = NonInterrupted.Asymentry;
            ExcitementVal = NonInterrupted.Excitement;
            Variations = NonInterrupted.Sample;

            foreach (var pair in NonInterrupted.StatisticalDistribution)
            {
                DataGridViewCell x = new DataGridViewTextBoxCell();
                DataGridViewCell n = new DataGridViewTextBoxCell();
                DataGridViewCell m = new DataGridViewTextBoxCell();
                DataGridViewCell p = new DataGridViewTextBoxCell();
                x.Value = pair.Key;
                n.Value = pair.Value;
                m.Value = NonInterrupted.RelativeFrequencyDistribution[pair.Key];
                //p.Value = NonInterrupted.NormalRelativeFrequencyDistribution[pair.Key];
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(x, n, m);
                DataTable.Rows.Add(row);

            }

            double tmp = 0;
            double k = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2;
            if (DyscreteDistribution == null)
            {
                form2 = new Form2(NonInterrupted);
            }
            else
            {
                form2 = new Form2(DyscreteDistribution);
            }
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form2;
            if (DyscreteDistribution == null)
            {
                form2 = new Form3(NonInterrupted);
            }
            else
            {
                form2 = new Form3(DyscreteDistribution);
            }
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(NonInterrupted);
            form4.ShowDialog();
            
        }
    }
}
