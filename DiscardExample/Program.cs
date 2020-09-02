using System;

namespace DiscardExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var (_, _, _, pop1, _, pop2) = QueryCityPopulationByYear("India", 1947, 2020);
            Console.WriteLine($"Population chage: {pop2 - pop1:N0}");
            ShowValue("hello");
        }

        private static void ShowValue(string _)
        {
            _ = "Hello World";
            Console.WriteLine(_);
        }

        private static (string, double, int, int, int, int) QueryCityPopulationByYear(string name, int year1, int year2)
        {
            int pop1 = 0, pop2 = 0;
            double area = 0;
            if (name == "India")
            {
                area = 468.48;
                if (year1 == 1947)
                {
                    pop1 = 7781984;
                }
                if (year2 == 2020)
                {
                    pop2 = 8175133;
                }
                return (name, area, year1, pop1, year2, pop2);
            }
            //Return nothing
            return ("", 0, 0, 0, 0, 0);
        }
    }
}
