
using System.Text.RegularExpressions;

namespace _5._2._1
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

            // регулярное выражение, определяющее группы цифр в тексте
            Regex regexNumbers = new Regex(@"\b\d+\b");

            // реуглярное выражение, определяющее слова в тексте
            Regex regexWords = new Regex(@"[a-zA-Zа-яА-Я]+\b");
            MatchCollection matchesNumbers = regexNumbers.Matches(str);
            MatchCollection matchesWords = regexWords.Matches(str);
            if (matchesWords.Count > matchesNumbers.Count)
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Не верно");
            }
        }
    }
}