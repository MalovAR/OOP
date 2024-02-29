using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EverythingAboutPerson
{
   
    public class Person
    {
        private string _firstName;
        private string _secondName;
        private int _age;
        private Gender _gender;

        public Person() : this("Unknown", "Unknown", 0, Gender.Male) { }

        public Person(string name, string secondName, int age, Gender gender)
        {

            _firstName = name;
            _secondName = secondName;
            _age = age;
            _gender =  gender;

        }

                private static bool NameCheck(string name)
        {
            if (Regex.IsMatch(name, @"^[а-яА-Я]*-?[а-яА-Я]+$") |
                Regex.IsMatch(name, @"^[a-zA-Z]*-?[a-zA-Z]*$") |
                Regex.IsMatch(name, @"^[a-zA-Z]*-?[а-яА-Я]*$") |
                Regex.IsMatch(name, @"^[а-яА-Я]*-?[a-zA-Z]*$"))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        public string FirstName 
        {
            get { return _firstName;} 
            set 
            {
                if (NameCheck(value) == true)
                {
                    _firstName = ti.ToTitleCase(value);
                }
                else
                {
                    throw new Exception("Имя должно содержать только " +
                        "русские или английские символы");
                }

            }
        }

        public string SecondName
        {
            get { return _secondName; }
            set
            {
                if (NameCheck(value) == true)
                {
                    _secondName = ti.ToTitleCase(value);
                }
                else
                {
                    throw new Exception("Фамилия должна содержать только " +
                        "русские или английские символы");
                }

            }
        }

        public int Age
        {
            get { return _age; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException( "Возраст не может быть " +
                        "отрицательным");
                if (value > 150)
                    throw new ArgumentException("Возраст не может быть " +
                        "настолько большим");
                else
                    _age = value; 
            }
        }

        public Gender Gender
        { 
            get; set; 
        }

        public string GetPersonInfo()
        {
            return ($"{FirstName} {SecondName},Возраст {Age}, " +
                $"Пол {Gender}\n");
        }

        public static Person GetRandomPerson()
        {
            
            List<string> maleNames = new List<string>() { "Андрей","Артемий",
                "Александр","Владимир","Вячеслав","Владлен","Глеб","Георгий",
                "Григорий","Ерофей","Евгений","Егор" };
            List<string> femaleNames = new List<string>() { "Анастасия",
                "Анна","Александра","Валентина","Валерия","Василиса",
                "Галина","Дарья","Оксана","Елена","Евгения","Екатерина" };
            List<string> maleSecondNames = new List<string>() { "Попов",
                "Лебедев","Петров","Ленин","Русский","Татарский","Дугин",
                "Сковорода","Путин","Копцев","Кац","Сорокин" };
            List<string> femaleSecondNames = new List<string>() { "Попова",
                "Лебедева","Петрова","Ленина","Русская","Татарская","Дугина",
                "Сковорода","Путина","Копцева","Кац","Сорокина" };
            
            Random random = new Random();

            Person person = new Person();

            person.Age = random.Next(0, 100);

            person.Gender = 
                (Gender)random.Next(Enum.GetValues(typeof(Gender)).Length); 
            
            if (person.Gender == Gender.Male)
            {
                person.FirstName = 
                    maleNames[random.Next(maleNames.Count)];
                person.SecondName = 
                    maleSecondNames[random.Next(maleSecondNames.Count)];
            }
            if (person.Gender == Gender.Female)
            {
                person.FirstName = 
                    femaleNames[random.Next(femaleNames.Count)];
                person.SecondName = 
                    femaleSecondNames[random.Next(femaleSecondNames.Count)];
            }
            return person;
        }
    }
}