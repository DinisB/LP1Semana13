using System;

namespace MultipleStuff
{
    public class Program
    {
        private SuperList sl = new SuperList { 1, 2, 4, 9};
        public static void Main(string[] args)
        {
            SuperList sl = new SuperList { 1, 2, 4, 9 };
            double min, max;
            sl.GetMinMax1(out min, out max);
            Console.WriteLine($"{min}, {max}");
            SuperList.MinMaxResult minMax = sl.GetMinMax2();
            Console.WriteLine($"{minMax.Min}, {minMax.Max}");
            sl.GetMinMax3(ref min, ref max);
            Console.WriteLine($"{min}, {max}");
            var (min4, max4) = sl.GetMinMax4();
            Console.WriteLine($"{min4}, {max4}");
        }
    }
}
