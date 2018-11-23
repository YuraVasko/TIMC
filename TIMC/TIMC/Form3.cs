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
    public partial class Form3 : Form
    {
        DyscreteDistribution dyscreteDistribution;
        NonInterrupted nonInterruptedDistribution;
        public Form3(object distribution)
        {
            InitializeComponent();
            if (distribution as DyscreteDistribution != null)
            {
                dyscreteDistribution = distribution as DyscreteDistribution;
                string tmp = "";
                dyscreteDistribution.VariationSeries.ForEach(element => tmp += element + "; ");

                tmp.Insert(tmp.Length / 2, "\r\n");

                VariatioSampleValue.Text = tmp;
                tmp = "";
                dyscreteDistribution.Fashion.ForEach(element => tmp += (element.ToString() + "; "));
                ModaValue.Text = tmp;
                SampleValume.Text = dyscreteDistribution.Sample.Count.ToString();
                MedianaValue.Text = dyscreteDistribution.Mediana.ToString();
                AvgSampleValue.Text = dyscreteDistribution.AverageSelective.ToString();
                DevationValue.Text = dyscreteDistribution.MathematicalHope.ToString();
                RozmahValue.Text = dyscreteDistribution.SamplingRate.ToString();
                VariansaValue.Text = dyscreteDistribution.Dispersion.ToString();
                StandartValue.Text = dyscreteDistribution.Flucktoation.ToString();
                DispersionValue.Text = ((dyscreteDistribution.Dispersion * (dyscreteDistribution.Sample.Count - 1)) / dyscreteDistribution.Sample.Count).ToString();
                VariationValue.Text = dyscreteDistribution.Variation.ToString();
                AsymentryValue.Text = dyscreteDistribution.Asymentry.ToString();
                ExcesValue.Text = dyscreteDistribution.Excitement.ToString();
                CentarlMomentValue.Text = dyscreteDistribution.CentralMomentValue.ToString();
                BeginningMomentValue.Text = dyscreteDistribution.BeginningMomentValue.ToString();
            }
            else
            {
                nonInterruptedDistribution = distribution as NonInterrupted;
                string tmp = "";
                nonInterruptedDistribution.Sample.ForEach(element => tmp += Math.Round(element,3) + "; ");

                tmp.Insert(tmp.Length / 2, "\r\n");

                VariatioSampleValue.Text = tmp;
                tmp = "";
                nonInterruptedDistribution.Fashion.ForEach(element => tmp += (Math.Round(element,3).ToString() + "; "));
                ModaValue.Text = tmp;
                SampleValume.Text = nonInterruptedDistribution.Sample.Count.ToString();
                MedianaValue.Text = Math.Round(nonInterruptedDistribution.Mediana,3).ToString();
                AvgSampleValue.Text = Math.Round(nonInterruptedDistribution.AverageSelective).ToString();
                DevationValue.Text = Math.Round(nonInterruptedDistribution.MathematicalHope,3).ToString();
                RozmahValue.Text = Math.Round(nonInterruptedDistribution.SamplingRate,3).ToString();
                VariansaValue.Text = Math.Round(nonInterruptedDistribution.Dispersion,3).ToString();
                StandartValue.Text = Math.Round(nonInterruptedDistribution.Flucktoation,3).ToString();
                DispersionValue.Text = Math.Round(((nonInterruptedDistribution.Dispersion * (nonInterruptedDistribution.Sample.Count - 1)) / nonInterruptedDistribution.Sample.Count),3).ToString();
                VariationValue.Text = Math.Round(nonInterruptedDistribution.Variation,3).ToString();
                AsymentryValue.Text = Math.Round(nonInterruptedDistribution.Asymentry,3).ToString();
                ExcesValue.Text = Math.Round(nonInterruptedDistribution.Excitement,3).ToString();
                CentarlMomentValue.Text = nonInterruptedDistribution.CentralMomentValue.ToString();
                BeginningMomentValue.Text = nonInterruptedDistribution.BeginningMomentValue.ToString();
            }
        }
    }
}
