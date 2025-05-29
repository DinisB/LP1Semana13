using System;
using System.Collections.Generic;
using System.Linq;

class SuperList : List<Double>
{
    public void GetMinMax1(out double min, out double max)
    {
        min = this.Min();
        max = this.Max();
    }

    public struct MinMaxResult
    {
        public double Min;
        public double Max;

        public MinMaxResult(double min, double max)
        {
            Min = min;
            Max = max;
        }
    }
    public MinMaxResult GetMinMax2()
    {
        return new MinMaxResult(this.Min(), this.Max());
    }
    public void GetMinMax3(ref double min, ref double max)
    {
        min = this.Min();
        max = this.Max();
    }
    public (double min, double max) GetMinMax4()
    {
        return (min: this.Min(), max: this.Max());
    }
}