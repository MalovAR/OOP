using EverythingAboutPerson;

namespace LAB_1
{
    public class Program
    {
        public static Person InsertPerson()
        {
            Person person = new Person();

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите имя");
                    person.FirstName = Console.ReadLine();
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите фамилию");
                    person.SecondName = Console.ReadLine();
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите возраст");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    break;
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (FormatException)
                {
                    Console.WriteLine("Некорректный формат. Возраст " +
                        "должен состоять только из цифр");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Укажите пол: М - Male (мужской), " +
                "Ж(F) - Female (женский)");
                    string insertedGender = Console.ReadLine();

                    switch (insertedGender)
                    {
                        case "M":
                        case "m":
                        case "М":
                        case "м":
                            break;
                        case "F":
                        case "f":
                        case "Ж":
                        case "ж":
                            person.Gender = Gender.Female;
                            break;
                        default:
                            throw new Exception();
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Неправильно указан пол.\n");
                }
            }
            return person;
        }
        
        public static void ShowPersonToConsole(Person person)
        {
            Console.WriteLine(person.GetPersonInfo());
        }

        static void Main()
        {
            //3 пункт
            //a.
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
            Console.WriteLine("Создано 2 списка персон");
            Person Valera = new ("Валера", "Жмышенко", 54, Gender.Male);
            Person Geralt = new ("Геральт", "Приблуда", 100, Gender.Male);
            Person Vesemyr = new ("Весемир", "Старый", 160, Gender.Male);
            Person Gendalf = new ("Гендальф", "Серый", 1000, Gender.Male);
            Person Ulfric = new ("Ульфрик", "Буревестник", 45, Gender.Male);
            Person Goblin = new ("Дмитрий", "Пучков", 62, Gender.Male);
            Person Vova = new ("Владимир", "Вист", 30, Gender.Male);
            PersonList personList1 = new PersonList();
            PersonList personList2 = new PersonList();
            personList1.AddPerson(Valera);
            personList1.AddPerson(Gendalf);
            personList1.AddPerson(Goblin);
            personList2.AddPerson(Geralt);
            personList2.AddPerson(Vesemyr);
            personList2.AddPerson(Ulfric);
            ////b.
            Console.ReadKey();
            Console.WriteLine("Список 1:");
            Console.WriteLine(personList1.GetPersonsList());
            Console.ReadKey();
            Console.WriteLine("Список 2:");
            Console.WriteLine(personList2.GetPersonsList());
            ////c.
            Console.ReadKey();
            Console.WriteLine("Добавление нового человека в первый список");
            personList1.AddPerson(Vova);
            Console.WriteLine(personList1.GetPersonsList());
            ////d.
            Console.ReadKey();
            Console.WriteLine("Добавление второго человека из первого " +
                "списка в конец второго списка");
            personList2.AddPerson(personList1.GetPersonByIndex(1));
            Console.WriteLine($"Список 1 : " +
                $"\n{personList1.GetPersonsList()}");
            Console.WriteLine($"Список 2 : " +
                $"\n{personList2.GetPersonsList()}");
            ////e.
            Console.ReadKey();
            Console.WriteLine("Удаление второго человека из первого списка");
            personList1.RemovePersonsByIndex(1);
            Console.WriteLine($"Список 1 : " +
                $"\n{personList1.GetPersonsList()}");
            Console.WriteLine($"Список 2 : " +
                $"\n{personList2.GetPersonsList()}");
            ////f.
            Console.ReadKey();
            Console.WriteLine("Очищение второго списка");
            personList2.ClearList();
            Console.WriteLine($"Список 2 : " +
                $"\n{personList2.GetPersonsList()}");


            //проверка 4 пункта
            Person newPerson = InsertPerson();
            ShowPersonToConsole(newPerson);

            //проверка 5 пункта
            for (int i = 0; i < 10; i++)
            {
                Person newRandomPerson = Person.GetRandomPerson();
                ShowPersonToConsole(newRandomPerson);
            }

        }
    }
}