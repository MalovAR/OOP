using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EverythingAboutPerson
{
    /// <summary>
    /// класс RandomPerson
    /// </summary>
    public class RandomPerson
    {
        //TODO: RSDN
        static List<string> maleNamesList = new List<string>() {
                "Андрей", "Артемий","Александр", "Владимир",
                "Вячеслав","Владлен","Глеб","Георгий",
                "Григорий","Ерофей","Евгений","Егор" };

        static List<string> femaleNamesList = new List<string>() {
                "Анастасия","Анна","Александра","Валентина",
                "Валерия","Василиса","Галина","Дарья",
                "Оксана","Елена","Евгения","Екатерина" };

        static List<string> maleSecondNamesList = new List<string>() {
                "Попов","Лебедев","Петров","Ленин",
                "Русский","Татарский","Дугин","Сковорода",
                "Путин","Копцев","Кац","Сорокин" };

        static List<string> femaleSecondNamesList = new List<string>() {
                "Попова","Лебедева","Петрова","Ленина",
                "Русская","Татарская","Дугина","Сковорода",
                "Путина","Копцева","Кац","Сорокина" };

        static List<string> jobsList = new List<string>() {
                "МВД", "МЧС", "ФСБ", "Детский Сад N10",
                "Школа N1", "Государственный Лицей",
                "Поликлинника N1", "Автомастерская"};

        static List<string> kindergardensList = new List<string>() {
                "Детский Сад N1", "Детский Сад N10", "Детский Сад N35"};

        static List<string> schoolsList = new List<string>() {
                "Школа N1", "Государственный Лицей", "Гимназия N5"};

        /// <summary>
        /// экземпляр класса Random
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Метод генерирующий случайное число заданной длины
        /// </summary>
        /// <param name="numberLength">длина числа</param>
        /// <returns>сгенерированное число в виде строки</returns>
        public static string GetRandomNumbers(int numberLength)
        {
            string number = "";
            for (int i = 0; i < numberLength; i++)
            {
                string digit = Convert.ToString(_random.Next(0, 9));
                number += digit;
            }
            return number;
        }

        /// <summary>
        /// Метод, заполняющий основные поля базового класса
        /// </summary>
        public static void SetBaseData(PersonBase person)
        {
            person.Age = _random.Next(person.MinAge, person.MaxAge);

            if (person.Gender == Gender.Male)
            {
                person.FirstName = maleNamesList
                        [_random.Next(maleNamesList.Count)];
                person.SecondName = maleSecondNamesList
                    [_random.Next(maleSecondNamesList.Count)];
            }
            else
            {
                person.FirstName = femaleNamesList
                        [_random.Next(femaleNamesList.Count)];
                person.SecondName = femaleSecondNamesList
                    [_random.Next(femaleSecondNamesList.Count)];
            }
        }

        /// <summary>
        /// Метод, случайным образом определяющий пол 
        /// </summary>
        /// <param name="person"> Объект класса базового класса </param>
        public static void SetPersonGender(PersonBase person)
        {
            person.Gender = 
                (Gender)_random.Next(Enum.GetValues(typeof(Gender)).Length);
        }

        /// <summary>
        /// Метод, определяющий состояние брака
        /// </summary>
        /// <param name="adult"> Объект класса <see cref="Adult"/>,
        /// для которого определяется состояние брака </param>
        public static void SetAPartner(Adult adult)
        {
            Adult partner = new();
            bool isMarried = _random.Next(0, 2) == 0;
            if (isMarried == true)
            {
                if (adult.Gender == Gender.Male)
                {
                    int secondNameIndex = maleSecondNamesList.IndexOf(adult.SecondName);
                    partner = CreateRandomAdult(Gender.Female);
                    partner.SecondName = femaleSecondNamesList[secondNameIndex];
                }
                else
                {
                    int secondNameIndex = femaleSecondNamesList.IndexOf(adult.SecondName);
                    partner = CreateRandomAdult(Gender.Male);
                    partner.SecondName = maleSecondNamesList[secondNameIndex];
                }
                adult.Partner = partner;
            }
        }

        /// <summary>
        /// Метод, определяющий родителей
        /// </summary>
        /// <param name="child">Объект класса <see cref="Child"/>,
        /// для которого определяются родители </param>
        public static void SetParents(Child child)
        {
            Adult parent = CreateRandomAdult();
            if (parent.Gender == Gender.Male)
            {
                child.Father = parent;
                SetAPartner(parent);
                child.Mother = parent.Partner;
                if (child.Gender == Gender.Male)
                {
                    child.SecondName = parent.SecondName;
                }
                else
                {
                    int secondNameIndex = maleSecondNamesList.IndexOf(parent.SecondName);
                    child.SecondName = femaleSecondNamesList[secondNameIndex];
                }
            }
            else
            {
                child.Mother = parent;
                SetAPartner(parent);
                child.Father = parent.Partner;
                if (child.Gender == Gender.Female)
                {
                    child.SecondName = parent.SecondName;
                }
                else
                {
                    int secondNameIndex = femaleSecondNamesList.IndexOf(parent.SecondName);
                    child.SecondName = maleSecondNamesList[secondNameIndex];
                }
            }          
        }

        /// <summary>
        /// Перегруженый метод создания случайного объекта
        /// класса <see cref="Adult"/>, определяющий его поля 
        /// базового класса в соответствии с полом
        /// </summary>
        /// <param name="gender">Пол создаваемого объекта класса 
        /// <see cref="Adult"/> </param>
        /// <returns> Объект класса <see cref="Adult"/> </returns>
        public static Adult CreateRandomAdult(Gender gender)
        {
            Adult adult = new();
            adult.Gender = gender;
            SetBaseData(adult);
            return adult;
        }

        /// <summary>
        /// Метод создания случайного объекта класса <see cref="Adult"/>
        /// </summary>
        /// <returns> Объект класса <see cref="Adult"/> </returns>
        public static Adult CreateRandomAdult()
        {
            Adult adult = new();
            bool isWorking = _random.Next(0, 2) == 0;
            SetPersonGender(adult);
            SetBaseData(adult);

            if (adult.Gender == Gender.Male && adult.Age < Adult.MalePensionAge ||
                adult.Gender == Gender.Female && adult.Age < Adult.FemalePensionAge)
            {
                if (isWorking == true)
                {
                    adult.Job = jobsList[_random.Next(jobsList.Count)];
                }
            }
            else
            {
                adult.Job = "Пенсионер";
            }

            adult.PassportSeries = GetRandomNumbers(Adult.SeriesLength);
            adult.PassportNumber = GetRandomNumbers(Adult.NumberLength);
            SetAPartner(adult);
            return adult;
        }

        /// <summary>
        /// Метод создания случайного объекта класса <see cref="Child"/>
        /// </summary>
        /// <returns> Объект класса <see cref="Child"/> </returns>
        public static Child CreateRandomChild()
        {
            Child child = new();
            bool isEducated = _random.Next(0, 2) == 0;
            SetPersonGender(child);
            SetBaseData(child);
            if (child.Age > 0 && child.Age < 7 && isEducated == true) 
            {
                child.Institute = kindergardensList[_random.Next(kindergardensList.Count)];
            }
            if (child.Age > 7 && isEducated == true)
            {
                child.Institute = schoolsList[_random.Next(schoolsList.Count)];
            }
            SetParents(child);
            return child;
        }
    }
}
