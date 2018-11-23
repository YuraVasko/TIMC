using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BLL
{
    public class NonInterrupted
    {
        List<double> arr = new List<double> { 0.01, 0.025, 0.05, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 0.95, 0.975, 0.99 };
        public Dictionary<double, double> LaplassaValues;
        public SortedSet<double> Variants { get; set; }
        public List<double> Sample { get; set; }
        public List<double> VariationSeries { get; set; }
        public Dictionary<double, int> StatisticalDistribution { get; set; }
        public Dictionary<double, double> RelativeFrequencyDistribution { get; set; }
        public Dictionary<double, double> NormalRelativeFrequencyDistribution { get; set; }
        public List<double> NormalRelativeFrequencyDistributionAfterCombine { get; set; }
        public List<double> StatisticalDistributionAfterCombine { get; set; }
        public Dictionary<KeyValuePair<double, double>, double> EmpiricalFunctionData { get; set; }
        public Dictionary<double, double> Vidrizky { get; set; }
        public double MathematicalHope { get; set; }
        public double Dispersion { get; set; }
        public int N { get; set; }
        public double From { get; set; }
        public double To { get; set; }
        public int N1 {get;set;}
        public double XiCritical { get; set; }

        public double BeginningMomentValue
        {
            get
            {
                double result = 0;
                foreach (var element in Sample)
                {
                    result += element ;
                }
                return result / Sample.Count;
            }
        }

        public double CentralMomentValue
        {
            get
            {
                double result = 0;
                foreach (var element in Sample)
                {
                    result += element - AverageSelective;
                }
                return result / Sample.Count;
            }
        }


        public double GetXiCritical(int fx, double alpha)
        {

            double result = 0;
            string[] lines = File.ReadAllLines("Pirson.txt");
            string[] row = lines[fx].Split('\t');
            string tmp = row[arr.IndexOf(alpha)+1];
            result = Double.Parse(tmp);
            XiCritical = result;
            return result;
        }

        public double XiEmpir
        {
            get
            {
                NormalRelativeFrequencyDistributionAfterCombine = new List<double>();
                StatisticalDistributionAfterCombine = new List<double>();
                N1 = 0;
                double result = 0;
                double npi = 0;
                double mi = 0;
                foreach (var variant in Variants)
                {
                    npi += Sample.Count * NormalRelativeFrequencyDistribution[variant];
                    mi += StatisticalDistribution[variant];
                    if(npi >= 10 && mi >=5)
                    {
                        //result += Math.Pow(mi - npi, 2) / (npi);
                        StatisticalDistributionAfterCombine.Add(mi);
                        NormalRelativeFrequencyDistributionAfterCombine.Add(npi);
                        npi = 0;
                        mi = 0;
                        N1++;
                    }
                }
                if (npi != 0)
                {
                    StatisticalDistributionAfterCombine[StatisticalDistributionAfterCombine.Count-1]+=mi;
                    NormalRelativeFrequencyDistributionAfterCombine[NormalRelativeFrequencyDistributionAfterCombine.Count - 1] += npi;

                }
                for(int i=0;i< NormalRelativeFrequencyDistributionAfterCombine.Count;i++)
                {
                    result += Math.Pow(StatisticalDistributionAfterCombine[i] - NormalRelativeFrequencyDistributionAfterCombine[i], 2) / (NormalRelativeFrequencyDistributionAfterCombine[i]);
                }
                return result;
            }
        }
        public double SamplingRate
        {
            get
            {
                return StatisticalDistribution.Last().Key - StatisticalDistribution.First().Key;
            }
        }

        public double Mediana
        {
            get
            {
                int count = 0;
                foreach (var item in StatisticalDistribution)
                {
                    count += item.Value;
                    if (count >= Sample.Count * 1.0 / 2)
                        return item.Key;
                }
                return StatisticalDistribution.Last().Key;
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
                double sum = 0;
                foreach(var item in StatisticalDistribution )
                {
                    sum += item.Key * item.Value;
                }
                return sum/Sample.Count;
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
                for (int i = 0; i < Sample.Count; i++)
                {
                    tmp1 += Math.Pow(Sample[i] - AverageSelective, 3);
                    tmp2 += Math.Pow(Sample[i] - AverageSelective, 2);
                }
                tmp1 /= Sample.Count;
                tmp2 /= Sample.Count;
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
                for (int i = 0; i < Sample.Count; i++)
                {
                    tmp1 += Math.Pow(Sample[i] - AverageSelective, 4);
                    tmp2 += Math.Pow(Sample[i] - AverageSelective, 2);
                }
                tmp1 /= Sample.Count;
                tmp2 /= Sample.Count;
                result = (tmp1 / Math.Pow(tmp2, 2)) - 3;
                return result;
            }
        }

        public NonInterrupted()
        {
            Sample = new List<double>();
            Variants = new SortedSet<double>();
            VariationSeries = new List<double>();
            StatisticalDistribution = new Dictionary<double, int>();
            RelativeFrequencyDistribution = new Dictionary<double, double>();
            EmpiricalFunctionData = new Dictionary<KeyValuePair<double, double>, double>();
        }

        public void GetSampleFromFile()
        {
            string data = File.ReadAllText("NonInteruptedDistribution.txt");
            string[] numbers = data.Split(';');
            foreach (var number in numbers)
            {
                Sample.Add(Double.Parse(number));
                Variants.Add(Sample[Sample.Count - 1]);
            }
            From = Variants.Min();
            To = Variants.Max;
            while (true)
            {
                if (Math.Pow(2, N) <= Sample.Count && Math.Pow(2, N + 1) > Sample.Count)
                {
                    N++;
                    break;
                }
                N++;
            }
            Sample.Sort();
        }


        public void GetSampleFromFileVidrizky()
        {
            string[] data = File.ReadAllLines("NonInteruptedTable.txt");
            Vidrizky.Clear();
            int n = int.Parse(data[0]);
            bool first = true;
            foreach (var line in data)
            {
                if (first)
                {
                    first = false;
                    continue;
                }
                N++;
                string[] tmp = line.Split('_');
                for (int i = 0; i < n * double.Parse(tmp[1]); i++)
                {
                    Sample.Add(Double.Parse(tmp[0]));
                    Variants.Add(Sample[Sample.Count - 1]);
                }
            }
            From = Variants.Min();
            To = Variants.Max;
            Sample.Sort();
        }



        public void GenerateSampleAndVariationSeries(int n, double from, double to)
        {
            N = 0;
            From = from;
            To = to;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Sample.Add(random.NextDouble() * (to - from) + from);
            }
            while (true)
            {
                if (Math.Pow(2, N) <= Sample.Count && Math.Pow(2, N + 1) > Sample.Count)
                {
                    N++;
                    break;
                }
                N++;
            }
            Sample.Sort();
        }

        public void GenerateStatisticalDistribution()
        {
            Vidrizky = new Dictionary<double, double>();
            double step = (To - From) * 1.0 / N;
            double start = From;
            double end = From + step;
            Variants.Clear();
            for (int i = 0; i < N; i++)
            {
                Vidrizky.Add(start, end);
                VariationSeries.Add(start + (end - start) * 1.0 / 2);
                Variants.Add(start + (end - start) * 1.0 / 2);
                StatisticalDistribution.Add(start + (end - start) * 1.0 / 2, Sample.Where(element => element >= start && element <= end).ToList().Count());
                start += step;
                end += step;
            }
            VariationSeries.Sort();
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
            EmpiricalFunctionData.Add(new KeyValuePair<double, double>(Int32.MinValue, Variants.ElementAt(0)), lastP);
            for (int i = 0; i < Variants.Count - 1; i++)
            {
                lastP += RelativeFrequencyDistribution[Variants.ElementAt(i)];
                EmpiricalFunctionData.Add(new KeyValuePair<double, double>(Variants.ElementAt(i), Variants.ElementAt(i + 1)), lastP);
            }
            EmpiricalFunctionData.Add(new KeyValuePair<double, double>(Variants.ElementAt(Variants.Count - 1), Variants.ElementAt(Variants.Count - 1) + 2), 1);
        }

        public void CalculateMathematicalHope()
        {
            MathematicalHope = 0;
            foreach (var pair in StatisticalDistribution)
            {
                MathematicalHope += Math.Pow((pair.Key - AverageSelective),2) * pair.Value;
            }
        }

        public void CalculateDispersion()
        { 
            Dispersion = MathematicalHope/((Sample.Count * 1.0)-1);
        }

        public void GenerateNormalRelativeFrequencyDistribution()
        {
            int index = 0;
            NormalRelativeFrequencyDistribution = new Dictionary<double, double>();
            double first = GetLaplassValue((Vidrizky[From] - AverageSelective) / Flucktoation);
            double second = GetLaplassValue(Double.MinValue);
            double p = first - second;
            NormalRelativeFrequencyDistribution.Add(Variants.ElementAt(index), first - second);
            foreach (var pair in Vidrizky)
            {
                if (pair.Key == From)
                {
                    continue;
                }
                index++;
                if (Math.Round(pair.Value, 2) == To)
                {
                    NormalRelativeFrequencyDistribution.Add(Variants.ElementAt(index), 1 - p);
                    continue;
                }
                first = GetLaplassValue((pair.Value - AverageSelective) / Flucktoation);
                second = GetLaplassValue((pair.Key - AverageSelective) / Flucktoation);
                p += first - second;
                NormalRelativeFrequencyDistribution.Add(Variants.ElementAt(index), first - second);
            }
        }

        public double GetLaplassValue(double element)
        {
            element = Math.Round(element, 2);
            if (element <= 0)
            {
                element *= (-1);
                if (element > 5)
                {
                    return -0.5;
                }
                else
                {
                    return -LaplassaValues.FirstOrDefault(pair => pair.Key == element).Value;
                }
            }
            else
            {
                if (element > 5)
                {
                    return 0.5;
                }
                else
                {
                    return LaplassaValues.FirstOrDefault(pair => pair.Key == element).Value;
                }
            }
        }

        public void ReadLaplassValues()
        {
            LaplassaValues = new Dictionary<double, double>();
            List<string> stringValues = new List<string>();
            string[] lines = File.ReadAllLines("F(x).txt");
            foreach (string line in lines)
            {
                stringValues.AddRange(line.Split(';'));
            }
            foreach (string value in stringValues)
            {
                string[] tmp = value.Split('-');
                LaplassaValues.Add(Double.Parse(tmp[0]), Double.Parse(tmp[1]));
            }
        }
    }
}
