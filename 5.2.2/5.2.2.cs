using System.Text.RegularExpressions;

namespace _5._2._2
{
    /// <summary>
    /// Program.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str = new(Console.ReadLine());
            Regex regexDomain = new Regex(@"www\.\S+[a-zA-Z]\.ru\b");
            MatchCollection matchesDomain = regexDomain.Matches(str);
            if (matchesDomain.Count > 0)
            {
                foreach (Match domain in matchesDomain)
                Console.WriteLine(domain.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}