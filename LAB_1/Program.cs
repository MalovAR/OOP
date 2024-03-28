using EverythingAboutPerson;
using System;

namespace LAB_1
{
    //TODO+: XML
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

                catch (Exception ex)
                {
                    switch (ex)
                    {
                        //TODO: {}
                        case ArgumentOutOfRangeException _:
                        case ArgumentException _:
                            {
                                Console.WriteLine(ex.Message);
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
        /// Метод для ввода объекта класса Person с консоли
        /// </summary>
        /// <returns></returns>
        public static Person InsertPerson()
        {
            Person person = new Person();

            List<Action> actions = new List<Action>()
            {
                () =>
                {
                    Console.WriteLine("Введите имя");
                    person.FirstName = Console.ReadLine();
                },
                () =>
                {
                    Console.WriteLine("Введите фамилию");
                    person.SecondName = Console.ReadLine();
                },
                () =>
                {
                    Console.WriteLine("Введите возраст");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                },
                () =>
                {
                    Console.WriteLine("Укажите пол: М - Male (мужской), " +
                "Ж(F) - Female (женский)");
                    string insertedGender = Console.ReadLine().ToUpper();
                    switch (insertedGender)
                    {
                        case "M":
                        case "М":
                            break;
                        case "F":
                        case "Ж":
                            person.Gender = Gender.Female;
                            break;
                        default:
                            throw new ArgumentException("Неправильно указан пол.\n");
                    }
                }

            };
            foreach (Action action in actions)
            {
                ActionHandler(action);
            }
            return person;
        }

        //TODO: XML
        /// <summary>
        /// Метод, который выводит информацию об объекте 
        /// класса <see cref="Person"/> в консоль
        /// </summary>
        /// <param name="person"> объект класса <see cref="Person"/> </param>
        public static void ShowPersonToConsole(Person person)
        {
            Console.WriteLine(person.GetPersonInfo());
        }

        //TODO: RSDN
        public static void Main()
        {

            ////3 пункт
            ////a.
            //Console.WriteLine("Нажмите любую кнопку");
            //Console.ReadKey();
            //Console.WriteLine("Создано 2 списка персон");
            ////TODO: RSDN
            //Person valera = new("Валера", "Жмышенко", 54, Gender.Male);
            //Person geralt = new("Геральт", "Приблуда", 100, Gender.Male);
            //Person vesemyr = new("Весемир", "Старый", 160, Gender.Male);
            //Person gendalf = new("Гендальф", "Серый", 1000, Gender.Male);
            //Person ulfric = new("Ульфрик", "Буревестник", 45, Gender.Male);
            //Person goblin = new("Дмитрий", "Пучков", 62, Gender.Male);
            //Person vova = new("Владимир", "Вист", 30, Gender.Male);
            //PersonList personList1 = new PersonList();
            //PersonList personList2 = new PersonList();
            //personList1.AddPerson(valera);
            //personList1.AddPerson(gendalf);
            //personList1.AddPerson(goblin);
            //personList2.AddPerson(geralt);
            //personList2.AddPerson(vesemyr);
            //personList2.AddPerson(ulfric);
            //Console.ReadKey();
            //personList2.GetPersonIndex(vova);

            //////b.
            //Console.ReadKey();
            //Console.WriteLine("Список 1:");
            //Console.WriteLine(personList1.GetPersonsList());
            //Console.ReadKey();
            //Console.WriteLine("Список 2:");
            //Console.WriteLine(personList2.GetPersonsList());
            //////c.
            //Console.ReadKey();
            //Console.WriteLine("Добавление нового человека в первый список");
            //personList1.AddPerson(Vova);
            //Console.WriteLine(personList1.GetPersonsList());
            //////d.
            //Console.ReadKey();
            //Console.WriteLine("Добавление второго человека из первого " +
            //    "списка в конец второго списка");
            //personList2.AddPerson(personList1.GetPersonByIndex(1));
            //Console.WriteLine($"Список 1 : " +
            //    $"\n{personList1.GetPersonsList()}");
            //Console.WriteLine($"Список 2 : " +
            //    $"\n{personList2.GetPersonsList()}");
            //////e.
            //Console.ReadKey();
            //Console.WriteLine("Удаление второго человека из первого списка");
            //personList1.RemovePersonsByIndex(1);
            //Console.WriteLine($"Список 1 : " +
            //    $"\n{personList1.GetPersonsList()}");
            //Console.WriteLine($"Список 2 : " +
            //    $"\n{personList2.GetPersonsList()}");
            //////f.
            //Console.ReadKey();
            //Console.WriteLine("Очищение второго списка");
            //personList2.ClearList();
            //Console.WriteLine($"Список 2 : " +
            //    $"\n{personList2.GetPersonsList()}");


            //проверка 4 пункта
            Person newPerson = InsertPerson();
            ShowPersonToConsole(newPerson);

            ////проверка 5 пункта
            //for (int i = 0; i < 10; i++)
            //{
            //    Person newRandomPerson = Person.GetRandomPerson();
            //    ShowPersonToConsole(newRandomPerson);
            //}

        }
    }
}