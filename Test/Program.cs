using EverythingAboutPerson;
using System;

namespace Test
{
    /// <summary>
    /// класс Programm
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод обработки возможных исключений.
        /// </summary>
        /// <param name="action">Действие.</param>
        public static void ActionHandler(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }

                catch (Exception exception)
                {
                    switch (exception)
                    {
                        case ArgumentOutOfRangeException _:
                        case ArgumentException _:
                        {
                            Console.WriteLine(exception.Message);
                            break;
                        }

                        case FormatException _:
                        {
                            Console.WriteLine("Некорректный формат. Возраст " +
                            "должен состоять только из цифр");
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод Main
        /// </summary>
        public static void Main()
        {
            Random random = new Random();
            PersonList personList = new PersonList();
            for (int i = 0; i < 7; i++)
            {
                bool isAdult = random.Next(0,2) == 0;
                //BUG:+
                if (isAdult)
                {
                    personList.AddPerson(RandomPerson.CreateRandomAdult());
                }
                else
                {
                    personList.AddPerson(RandomPerson.CreateRandomChild());
                }
            }

            Console.WriteLine(personList.GetPersonsList());

            var person = personList.GetPersonByIndex(3);
            Type type = person.GetType();
            Console.WriteLine($"Тип четвертого человека в списке: {type}");

            switch (person)
            {
                case Adult adult:
                    Console.WriteLine(adult.ProveImAdult());
                    break;
                case Child child:
                    Console.WriteLine(child.ProveImChild());
                    break;
            }
        }
    }
}