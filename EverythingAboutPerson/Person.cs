using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EverythingAboutPerson
{
   //TODO+: XML
   /// <summary>
   /// Класс Person.
   /// </summary>
    public class Person
    {
        /// <summary>
        /// поле класса - Имя
        /// </summary>
        private string _firstName;

        /// <summary>
        /// поле класса - Фамилия
        /// </summary>
        private string _secondName;

        /// <summary>
        /// поле класса - Возраст
        /// </summary>
        private int _age;

        /// <summary>
        /// константа -  минимальный возраст
        /// </summary>
        private const int _minAge = 0;

        /// <summary>
        /// константа - максимальный возраст
        /// </summary>
        private const int _maxAge = 150;

        /// <summary>
        /// Шаблон задания имен на русском языке
        /// </summary>
        private const string _rusNamePattern = "^[а-яА-Я]+-?[а-яА-Я]+$";

        /// <summary>
        /// Шаблон задания имен на английском языке
        /// </summary>
        private const string _engNamePattern = "^[a-zA-Z]+-?[a-zA-Z]*$";

        /// <summary>
        /// Экземпляр класса <see cref="Person"/> по умолчанию
        /// </summary>
        public Person() : this("Unknown", "Unknown", 0, Gender.Male) { }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name"></param>
        /// <param name="secondName"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Person(string name, string secondName, int age, Gender gender)
        {
            FirstName = name;
            SecondName = secondName;
            Age = age;
            Gender =  gender;
        }

        /// <summary>
        ///  Метод, проверяющий, имя состоит из русских или английских букв
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <returns> 
        /// true, если имя состоит из русских или англиских символов
        /// false, если имя содержит что-то кроме русских
        /// или английских букв. Например, цифры или символы
        /// </returns>
        private static bool IsNameValid(string name)
        {
            return Regex.IsMatch(name, @_rusNamePattern) 
                || Regex.IsMatch(name, @_engNamePattern);
        }

        /// <summary>
        /// Метод, проверяющий, что имя и фамилия 
        /// состоят из букв одного и того же алфавита
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <param name="secondName"> Фамилия </param>
        /// <returns>
        /// true, если имя и фамилия написаны на одном и том же языке
        /// false, если нет
        /// </returns>
        private static bool IsLanguageSame(string name, string secondName)
        {
            return (Regex.IsMatch(name, @_rusNamePattern)
                && Regex.IsMatch(secondName, @_rusNamePattern))
                || (Regex.IsMatch(name, @_engNamePattern)
                && Regex.IsMatch(secondName, @_engNamePattern));
        }

        //TODO: RSDN
        /// <summary>
        /// экземпляр класса <see cref="TextInfo"/>
        /// </summary>
        private static TextInfo _textInfo = CultureInfo.CurrentCulture.TextInfo;

        /// <summary>
        /// Свойство класса - Имя
        /// </summary>
        public string FirstName 
        {
            get { return _firstName;} 
            set 
            {
                if (IsNameValid(value))
                {
                    _firstName = _textInfo.ToTitleCase(value);
                }
                else
                {
                    throw new ArgumentException("Имя должно содержать " +
                        "только русские или английские символы");
                }
            }
        }

        /// <summary>
        /// Свойство класса - Фамилия
        /// </summary>
        public string SecondName
        {
            get { return _secondName; }
            set
            {
                if (IsNameValid(value) && IsLanguageSame(FirstName, value))
                {
                    _secondName = _textInfo.ToTitleCase(value);
                }
                else
                {
                    throw new ArgumentException("Фамилия должна содержать " +
                        "только русские или английские символы ");
                }
            }
        }

        /// <summary>
        /// Свойство класса - Возраст
        /// </summary>
        public int Age
        {
            get { return _age; }
            set 
            {
                if (value < _minAge)
                {
                    throw new ArgumentException("Возраст не может быть " +
                        "отрицательным");
                }
 
                if (value > _maxAge)
                {
                    throw new ArgumentException("Возраст не может быть " + 
                        $"больше {_maxAge}");
                }
                else
                {
                    _age = value;
                }
            }
        }

        /// <summary>
        /// Автосвойство класса Gender - Пол
        /// </summary>
        public Gender Gender
        { 
            get; set; 
        }

        /// <summary>
        /// Метод, показывающий информацию об объекте класса <see cref="Person"/> 
        /// </summary>
        /// <returns> 
        /// строка с информацией об объекте класса <see cref="Person"/> 
        /// </returns>
        public string GetPersonInfo()
        {
            return ($"{FirstName} {SecondName},Возраст {Age}, " +
                $"Пол {Gender}\n");
        }

        /// <summary>
        /// Метод, создающий случайный объект класса <see cref="Person"/>
        /// </summary>
        /// <returns>
        /// объект класса Person
        /// </returns>
        public static Person GetRandomPerson()
        {
            List<string> maleNames = new List<string>() { 
                "Андрей", "Артемий","Александр", "Владимир", 
                "Вячеслав","Владлен","Глеб","Георгий",
                "Григорий","Ерофей","Евгений","Егор" };
            List<string> femaleNames = new List<string>() { 
                "Анастасия","Анна","Александра","Валентина",
                "Валерия","Василиса","Галина","Дарья",
                "Оксана","Елена","Евгения","Екатерина" };
            List<string> maleSecondNames = new List<string>() { 
                "Попов","Лебедев","Петров","Ленин",
                "Русский","Татарский","Дугин","Сковорода",
                "Путин","Копцев","Кац","Сорокин" };
            List<string> femaleSecondNames = new List<string>() { 
                "Попова","Лебедева","Петрова","Ленина",
                "Русская","Татарская","Дугина","Сковорода",
                "Путина","Копцева","Кац","Сорокина" };
            
            Random random = new Random();

            Person person = new Person();

            person.Age = random.Next(_minAge, _maxAge);

            person.Gender = 
                (Gender)random.Next(Enum.GetValues(typeof(Gender)).Length); 
            
            switch(person.Gender)
            {
                case Gender.Male:
                    //TODO+: {}
                    {
                        person.FirstName =
                        maleNames[random.Next(maleNames.Count)];
                        person.SecondName =
                            maleSecondNames[random.Next(maleSecondNames.Count)];
                    }
                    break;

                case Gender.Female:
                    //TODO+: {}
                    {
                        person.FirstName =
                        femaleNames[random.Next(femaleNames.Count)];
                        person.SecondName =
                            femaleSecondNames[random.Next(femaleSecondNames.Count)];
                    }
                    break;
            }
            return person;
        }
    }
}