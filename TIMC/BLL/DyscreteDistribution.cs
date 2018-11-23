using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DyscreteDistribution
    {
        public SortedSet<int> Variants { get; set; }
        public List<int> Sample { get; set; }
        public List<double> VariationSeries { get; set; }
        public Dictionary<double, int> StatisticalDistribution { get; set; }
        public Dictionary<double, double> RelativeFrequencyDistribution { get; set; }
        public Dictionary<KeyValuePair<int, int>, double> EmpiricalFunctionData { get; set; }
        public double MathematicalHope { get; set; }
        public double Dispersion { get; set; }

        public double BeginningMomentValue
        {
            get
            {
                double result = 0;
                foreach (var element in VariationSeries)
                {
                    result += element;
                }
                return result/VariationSeries.Count;
            }
        }

        public double CentralMomentValue
        {
            get
            {
                double result = 0;
                foreach (var element in VariationSeries)
                {
                    result += element - AverageSelective;
                }
                return Math.Round(result / VariationSeries.Count,3);
            }
        }

        public double SamplingRate
        {
            get
            {
                return VariationSeries[VariationSeries.Count - 1] - VariationSeries[0];
            }
        }

        public double Mediana
        {
            get
            {
                return VariationSeries.Count % 2 == 0 ? (VariationSeries[VariationSeries.Count / 2] + VariationSeries[(VariationSeries.Count / 2) - 1]) * 1.0 / 2 : VariationSeries[(VariationSeries.Count / 2)];
            }
        }

        public List<double> Fashion
        {
            get
            {
                List<double> list = new List<double>();
                int result = Int32.MinValue;
                double fashion = 0;
                foreach (var pair in StatisticalDistribution)
                {
                    if (pair.Value > result)
                    {
                        list.Clear();
                        result = pair.Value;
                        fashion = pair.Key;
                        list.Add(pair.Key);
                    }
                    else if (pair.Value == result)
                    {
                        list.Add(pair.Key);
                    }

                }
                return list;
            }
        }

        public double AverageSelective
        {
            get
            {
                return VariationSeries.Sum() * 1.0 / VariationSeries.Count;
            }
        }

        public double Flucktoation
        {
            get
            {
                return Math.Sqrt(Dispersion);
            }
        }

        public double Variation
        {
            get
            {
                return Flucktoation * 1.0 / AverageSelective;
            }
        }

        public double Asymentry
        {
            get
            {
                double result = 0;
                double tmp1 = 0, tmp2 = 0;
                for (int i = 0; i < VariationSeries.Count; i++)
                {
                    tmp1 += Math.Pow(VariationSeries[i] - AverageSelective, 3);
                    tmp2 += Math.Pow(VariationSeries[i] - AverageSelective, 2);
                }
                tmp1 /= VariationSeries.Count;
                tmp2 /= VariationSeries.Count;
                result = (tmp1 / Math.Pow(tmp2, 3.0 / 2));
                return result;
            }
        }

        public double Excitement
        {
            get
            {
                double result = 0;
                double tmp1 = 0, tmp2 = 0;
                for (int i = 0; i < VariationSeries.Count; i++)
                {
                    tmp1 += Math.Pow(VariationSeries[i] - AverageSelective, 4);
                    tmp2 += Math.Pow(VariationSeries[i] - AverageSelective, 2);
                }
                tmp1 /= VariationSeries.Count;
                tmp2 /= VariationSeries.Count;
                result = (tmp1 / Math.Pow(tmp2, 2)) - 3;
                return result;
            }
        }

        public DyscreteDistribution()
        {
            Sample = new List<int>();
            Variants = new SortedSet<int>();
            VariationSeries = new List<double>();
            StatisticalDistribution = new Dictionary<double, int>();
            RelativeFrequencyDistribution = new Dictionary<double, double>();
            EmpiricalFunctionData = new Dictionary<KeyValuePair<int, int>, double>();
        }

        public void GenerateSample(int n, int from, int to)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Sample.Add(random.Next(from, to));
                Variants.Add(Sample[Sample.Count - 1]);
            }
        }

        public void GetSampleFromFile()
        {
            string data = File.ReadAllText("DyscreteDistribution.txt");
            string[] numbers = data.Split(';');
            foreach (var number in numbers)
            {
                Sample.Add(Int32.Parse(number));
                Variants.Add(Sample[Sample.Count - 1]);
            }
        }

        //public void GetSampleFromFile()
        //{
        //    string[] data = File.ReadAllLines("DyscreteTable.txt");
        //    int n = int.Parse(data[0]);
        //    bool first = true;
        //    foreach (var line in data)
        //    {
        //        if (first)
        //        {
        //            first = false;
        //            continue;
        //        }
        //        string[] tmp = line.Split(':');
        //        for (int i = 0; i < n * double.Parse(tmp[1]); i++)
        //        {
        //            Sample.Add(Int32.Parse(tmp[0]));
        //            Variants.Add(Sample[Sample.Count - 1]);
        //        }
        //    }
        //}



        public void GenerateVariationSeries()
        {
            Sample.ForEach(element => VariationSeries.Add(element));
            VariationSeries.Sort();
        }

        public void GenerateStatisticalDistribution()
        {
            VariationSeries.Distinct().ToList().ForEach(element => StatisticalDistribution.Add(element, 0));
            VariationSeries.ForEach(element => StatisticalDistribution[element]++);
        }

        public void GenerateRelativeFrequencyDistribution()
        {
            int n = Sample.Count;
            foreach (var pair in StatisticalDistribution)
            {
                RelativeFrequencyDistribution.Add(pair.Key, pair.Value * 1.0 / n);
            }
        }

        public void GenerateEmpiricalFunctionData()
        {
            double lastP = 0;
            EmpiricalFunctionData.Add(new KeyValuePair<int, int>(Int32.MinValue, Variants.ElementAt(0)), lastP);
            for (int i = 0; i < Variants.Count - 1; i++)
            {
                lastP += RelativeFrequencyDistribution[Variants.ElementAt(i)];
                EmpiricalFunctionData.Add(new KeyValuePair<int, int>(Variants.ElementAt(i), Variants.ElementAt(i + 1)), lastP);
            }
            EmpiricalFunctionData.Add(new KeyValuePair<int, int>(Variants.ElementAt(Variants.Count - 1), Variants.ElementAt(Variants.Count - 1) + 2), 1);
        }

        public void CalculateMathematicalHope()
        {
            MathematicalHope = 0;
            foreach (var pair in StatisticalDistribution)
            {
                MathematicalHope += Math.Pow(pair.Key-AverageSelective,2) * pair.Value;
            }
        }

        public void CalculateDispersion()
        {
            
            Dispersion = MathematicalHope / ((Sample.Count * 1.0) - 1);
        }

    }
}
