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
        private string _firstName;
        private string _secondName;
        private int _age;
        private const int _minAge = 0;
        private const int _maxAge = 150;
        
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Person"/>
        /// </summary>
        public Person() : this("Unknown", "Unknown", 0, Gender.Male) { }

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
        /// <param name="name">//TODO: XML</param>
        /// <returns> true, если имя состовит из русских 
        /// или англиских символов
        /// false, если имя содержит что-то кроме русских
        /// или английских букв. Например, цифры или символы.</returns>
        private static bool NameCheck(string name)
        {
            return Regex.IsMatch(name, @"^[а-яА-Я]+-?[а-яА-Я]+$") 
                || Regex.IsMatch(name, @"^[a-zA-Z]+-?[a-zA-Z]*$");
        }

        //TODO: RSDN
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        public string FirstName 
        {
            get { return _firstName;} 
            set 
            {
                if (NameCheck(value))
                {
                    _firstName = textInfo.ToTitleCase(value);
                }
                else
                {
                    throw new ArgumentException("Имя должно содержать " +
                        "только русские или английские символы");
                }

            }
        }

        public string SecondName
        {
            get { return _secondName; }
            set
            {
                if (NameCheck(value))
                {
                    _secondName = textInfo.ToTitleCase(value);
                }
                else
                {
                    throw new ArgumentException("Фамилия должна содержать " +
                        "только русские или английские символы");
                }

            }
        }

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

        public Gender Gender
        { 
            get; set; 
        }

        /// <summary>
        /// Метод, показывающий информацию об объекте класса Person 
        /// </summary>
        /// <returns> строку с информацией об объекте 
        /// класса Person. </returns>
        public string GetPersonInfo()
        {
            return ($"{FirstName} {SecondName},Возраст {Age}, " +
                $"Пол {Gender}\n");
        }

        /// <summary>
        /// Метод, создающий случайный объект класса Person
        /// </summary>
        /// <returns>объект класса Person</returns>
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
                    //TODO: {}
                    person.FirstName =
                        maleNames[random.Next(maleNames.Count)];
                    person.SecondName =
                        maleSecondNames[random.Next(maleSecondNames.Count)];
                    break;

                case Gender.Female:
                    //TODO: {}
                    person.FirstName =
                        femaleNames[random.Next(femaleNames.Count)];
                    person.SecondName =
                        femaleSecondNames[random.Next(femaleSecondNames.Count)];
                    break;
            }

            return person;
        }
    }
}