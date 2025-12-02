using System.Text.RegularExpressions;

namespace AOC2025Day2
{
    internal class Program
    {
        static string PartOne(string data)
        {
            Regex regex = new Regex(@"^([0-9]+)\1$");
            ulong total = 0;
            foreach (string range in data.Split(','))
            {
                ulong start = ulong.Parse(range.Split("-")[0]);
                ulong end = ulong.Parse(range.Split("-")[1]);
                for (ulong i = start; i <= end; i++)
                {
                    if (regex.IsMatch(Convert.ToString(i)))
                    {
                        total += i;
                    }
                }
            }
            return total.ToString();
        }
        static string PartTwo(string data)
        {
            Regex regex = new Regex(@"^([0-9]+)\1+$");
            ulong total = 0;
            foreach (string range in data.Split(','))
            {
                ulong start = ulong.Parse(range.Split("-")[0]);
                ulong end = ulong.Parse(range.Split("-")[1]);
                for (ulong i = start; i <= end; i++)
                {
                    if (regex.IsMatch(Convert.ToString(i)))
                    {
                        total += i;
                    }
                }
            }
            return total.ToString();
        }
        static void Main()
        {
            string file = File.ReadAllText(@"../../../input.txt");
            Console.WriteLine(PartOne(file));
            Console.WriteLine(PartTwo(file));
        }
    }
}
