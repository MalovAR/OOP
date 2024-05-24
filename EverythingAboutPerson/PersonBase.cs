using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EverythingAboutPerson
{
    /// <summary>
    /// Базовый класс Person
    /// </summary>
    public abstract class PersonBase
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
        /// Свойство - минимальный возраст
        /// </summary>
        public virtual int MinAge { get; } = 0;

        /// <summary>
        /// Свойство - максимальный возраст
        /// </summary>
        public virtual int MaxAge { get; } = 110;

        /// <summary>
        /// Шаблон задания имен на русском языке
        /// </summary>
        private const string _rusNamePattern = "^[а-яА-Я]+-?[а-яА-Я]+$";

        /// <summary>
        /// Шаблон задания имен на английском языке
        /// </summary>
        private const string _engNamePattern = "^[a-zA-Z]+-?[a-zA-Z]*$";

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name"></param>
        /// <param name="secondName"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public PersonBase(string name, string secondName, int age, Gender gender)
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
                if (value < MinAge)
                {
                    throw new ArgumentException("Возраст не может быть " +
                        "отрицательным");
                }
 
                if (value > MaxAge)
                {
                    throw new ArgumentException("Возраст не может быть " + 
                        $"больше {MaxAge}");
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
        /// Метод, показывающий информацию об 
        /// объекте класса <see cref="PersonBase"/> 
        /// </summary>
        /// <returns> 
        /// Cтрока с информацией об объекте класса <see cref="PersonBase"/> 
        /// </returns>
        public virtual string GetInfo()
        {
            return ($"{FirstName} {SecondName}," +
                $"Возраст {Age}, Пол {Gender} ");
        }

    }
}