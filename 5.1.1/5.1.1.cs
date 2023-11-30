using System.Diagnostics.Metrics;

namespace _5._1._1
{
    /// <summary>
    /// Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Функция, которая определяет число слов, состоящих не более чем из 4 букв.
        /// </summary>
        /// <param name="str"> Строка, которую принимает на вход функция.</param>
        /// <returns> Количество слов, состоящих не более чем чем из 4 букв. </returns>
        public static int DefineShortWordsAmount(string str)
        {
            // счетчик слов, состоящих не более чем из 4 букв
            int counter = 0;

            // цикл, который итерируется по каждому слову
            // словом считается любой набор символов, разделенный, перечисленными символами
            foreach (string word in str.Split(' ', '.', ',', '!', '?', ';', ':'))
            {
                if (word.Length <= 4 & word.Length != 0)
                    counter++;
            }

            // счетчик
            return counter;
        }

        static void Main(string[] args)
        {
            string str = new(Console.ReadLine());
            Console.WriteLine(DefineShortWordsAmount(str));
        }
    }
}