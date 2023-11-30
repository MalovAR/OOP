namespace _5._1._2
{
    /// <summary>
    /// Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Функция, которая определяет слова в предложении и записывает их по отдельности.
        /// </summary>
        /// <param name="str"> Строка, которую принимает на вход функция.</param>.
        public static void ShowSeparateWords(string str)
        {
            // цикл, который итерируется по каждому слову
            // словом считается любой набор символов, разделенный, перечисленными символами
            foreach (string word in str.Split(' ', '.', ',', '!', '?', ';', ':'))
            {
                if (word.Length != 0)
                {
                    Console.WriteLine(word);
                }
            }
        }

        static void Main(string[] args)
        {
            string str = new(Console.ReadLine());
            ShowSeparateWords(str);
        }
    }
}