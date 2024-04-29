using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EverythingAboutPerson
{
    public class Adult : Person
    {
        /// <summary>
        /// поле класса - серия паспорта
        /// </summary>
        private string _passportSeries;

        /// <summary>
        ///  поле класса - номер паспорта
        /// </summary>
        private string _passportNumber;

        /// <summary>
        /// поле класса - партнер, с которым <see cref="Adult"/> 
        /// состоит в браке
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// поле класса - место работы
        /// </summary>
        private string _job;

        private const string _onlyNumbersPattern = @"^\d+$";

        /// <summary>
        /// Свойство - минимальный возраст
        /// </summary>
        public override int MinAge { get; } = 18;

        /// <summary>
        /// Мужской пенсионный возраст
        /// </summary>
        public const int MalePensionAge = 65;

        /// <summary>
        /// Мужской пенсионный возраст
        /// </summary>
        public const int FemalePensionAge = 60;

        /// <summary>
        /// Экземпляр класса <see cref="Adult"/> по умолчанию
        /// </summary>
        public Adult() : this("Неизвестно", "Неизвестно", 18,
            Gender.Male, "0000", "000000", null , "") { }

        /// <summary>
        /// Конструктор класса <see cref="Adult"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="secondName"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="passportSeries"></param>
        /// <param name="passportNumber"></param>
        /// <param name="partner"></param>
        /// <param name="job"></param>
        public Adult(string name, string secondName,
            int age, Gender gender, string passportSeries, 
            string passportNumber, Adult partner, string job) 
            : base(name, secondName, age, gender)
        {
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            Partner = partner;
            Job = job;
        }

        /// <summary>
        /// Свойство класса - серия паспорта
        /// </summary>
        public string PassportSeries
        {
            get { return _passportSeries; }
            set
            {
                if (value.Length == 4 && 
                    Regex.IsMatch(value, _onlyNumbersPattern))
                {
                    _passportSeries = value;
                }
                else
                {
                    throw new ArgumentException
                        ("Серия должна состоять из 4 цифр");
                }
            }

        }

        /// <summary>
        /// Свойство класса - номер паспорта
        /// </summary>
        public string PassportNumber
        {
            get { return _passportNumber; }
            set
            {
                if (value.Length == 6 && 
                    Regex.IsMatch(value, _onlyNumbersPattern))
                {
                    _passportNumber = value;                    
                }
                else
                {
                    throw new ArgumentException
                        ("Номер должен состоять из 6 цифр");
                }
            }

        }

        /// <summary>
        /// Свойство класса - партнер, с которым 
        /// <see cref="Adult"/> состоит в браке
        /// </summary>
        public Adult Partner
        {
            get { return _partner; }
            set
            {
                if (value?.Gender != Gender) 
                {
                    _partner = value; 
                }
                else 
                {
                    throw new ArgumentException("Однополый брак невозможен");
                }
            }

        }

        /// <summary>
        /// Свойство класса - место работы
        /// состоит в браке
        /// </summary>
        public string Job
        {
            get { return _job; }
            set
            {
                _job = value;
                if (value == null)
                {
                    _job = "";
                }
            }
        }

        /// <summary>
        /// Метод, показывающий информацию об 
        /// объекте класса <see cref="Adult"/>
        /// </summary>
        /// <returns>
        /// Cтрока с информацией об объекте класса <see cref="Adult"/> 
        /// </returns>
        public override string GetInfo()
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string job = "";
            string partner = "";

            if (Partner == null)
            {
                partner = $"В браке не состоит";
            }
            else
            {
                partner = $"Супруг(а): " +
                    $"{Partner.FirstName} {Partner.SecondName}";
            }

            job = $"Место работы: {Job}";
            switch (textInfo.ToUpper(Job))
            {
                case "":
                    {
                        job = "Нигде не работает";
                        break;
                    }
                case "ПЕНСИОНЕР":
                    {
                        job = "Пенсионер";
                        break;
                    }
            }

            return ($"{base.GetInfo()}" +
                $"серия и номер паспорта: " +
                $"{PassportSeries} {PassportNumber} " +
                $"{job} {partner} \n");
        }

        /// <summary>
        /// Метод, уникальный для класса <see cref="Adult"/>
        /// </summary>
        /// <returns></returns>
        public string ProveImAdult()
        {
            return $"Я cегодня за чеpвонец две смены отпахал\r\n" +
                $"И я устал, я устал";
        }
    }

}
