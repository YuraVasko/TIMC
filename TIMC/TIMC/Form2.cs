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
    public partial class Form2 : Form
    {
        DyscreteDistribution dyscreteDistribution;
        NonInterrupted nonInterruptedDistribution;

        public Form2(object distribution)
        {
            InitializeComponent();
            EmpiricFunction.Series[0].EmptyPointStyle.Color = Color.Transparent;
            FrequencyDiagram.Series[0].Points.Clear();
            FriquencyPoligon.Series[0].Points.Clear();
            EmpiricFunction.Series[0].Points.Clear();
            if(distribution as DyscreteDistribution != null)
            {
                dyscreteDistribution = distribution as DyscreteDistribution;
                foreach (var pair in dyscreteDistribution.StatisticalDistribution)
                {
                    FrequencyDiagram.Series[0].Points.Add(new DataPoint(pair.Key, pair.Value));
                    FriquencyPoligon.Series[0].Points.Add(new DataPoint(pair.Key, pair.Value));
                }
                DataPoint point;
                EmpiricFunction.Series[0].Points.Add(new DataPoint(dyscreteDistribution.Variants.ElementAt(0) - 2, 0));
                EmpiricFunction.Series[0].Points.Add(new DataPoint(dyscreteDistribution.Variants.ElementAt(0), 0));
                point = new DataPoint(dyscreteDistribution.Variants.ElementAt(0), 0);
                point.IsEmpty = true;
                EmpiricFunction.Series[0].Points.Add(point);
                foreach (var pair in dyscreteDistribution.EmpiricalFunctionData)
                {
                    if (pair.Key.Key != Int32.MinValue)
                    {
                        point = new DataPoint(pair.Key.Key, pair.Value);
                        point.IsEmpty = true;
                        EmpiricFunction.Series[0].Points.Add(point);
                        point = new DataPoint(pair.Key.Key, pair.Value);
                        EmpiricFunction.Series[0].Points.Add(point);

                    }
                    point = new DataPoint(pair.Key.Value, pair.Value);
                    if (pair.Value != 1)
                    {
                        point.MarkerStyle = MarkerStyle.Circle;
                        point.MarkerSize = 5;
                    }
                    EmpiricFunction.Series[0].Points.Add(point);
                    point = new DataPoint(pair.Key.Value, pair.Value);
                    point.IsEmpty = true;
                    EmpiricFunction.Series[0].Points.Add(point);
                }
            }
            else
            {
                nonInterruptedDistribution = distribution as NonInterrupted;
                foreach (var pair in nonInterruptedDistribution.StatisticalDistribution)
                {
                    FrequencyDiagram.Series[0].Points.Add(new DataPoint(pair.Key, pair.Value));
                    FriquencyPoligon.Series[0].Points.Add(new DataPoint(pair.Key, pair.Value));
                }
                DataPoint point;
                EmpiricFunction.Series[0].Points.Add(new DataPoint(nonInterruptedDistribution.Variants.ElementAt(0) - 2, 0));
                EmpiricFunction.Series[0].Points.Add(new DataPoint(nonInterruptedDistribution.Variants.ElementAt(0), 0));
                point = new DataPoint(nonInterruptedDistribution.Variants.ElementAt(0), 0);
                point.IsEmpty = true;
                EmpiricFunction.Series[0].Points.Add(point);
                foreach (var pair in nonInterruptedDistribution.EmpiricalFunctionData)
                {
                    if (pair.Key.Key != Int32.MinValue)
                    {
                        point = new DataPoint(pair.Key.Key, pair.Value);
                        point.IsEmpty = true;
                        EmpiricFunction.Series[0].Points.Add(point);
                        EmpiricFunction.Series[0].Points.Add(new DataPoint(pair.Key.Key, pair.Value));

                    }
                    point = new DataPoint(pair.Key.Value, pair.Value);
                    if (pair.Value != 1)
                    {
                        point.MarkerStyle = MarkerStyle.Circle;
                        point.MarkerSize = 5;
                    }
                    EmpiricFunction.Series[0].Points.Add(point);
                    point = new DataPoint(pair.Key.Value, pair.Value);
                    point.IsEmpty = true;
                    EmpiricFunction.Series[0].Points.Add(point);
                }
            }
        }


    }
}
