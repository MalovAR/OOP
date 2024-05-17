using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EverythingAboutPerson
{
    /// <summary>
    /// Класс Child (наследник класса Person).
    /// </summary>
    public class Child : Person
    {
        /// <summary>
        /// Поле отца
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Поле матери
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Поле учебного заведения (детский сад/школа)
        /// </summary>
        private string _institute;

        /// <summary>
        /// константа - максимальный возраст ребенка
        /// </summary>
        public override int MaxAge { get; } = 17;

        /// <summary>
        /// Экземпляр класса <see cref="Child"/> по умолчанию
        /// </summary>
        public Child() : this("Неизвестно", "Неизвестно", 0, 
            Gender.Male, null, null, "") { }

        /// <summary>
        /// Конструктор класса <see cref="Child"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="secondName"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="father"></param>
        /// <param name="mother"></param>
        /// <param name="institute"></param>
        public Child(string name, string secondName, 
            int age, Gender gender, 
            Adult father, Adult mother, 
            string institute) : base(name, secondName, age, gender)
        {
           Father = father;
           Mother = mother;
           Institute = institute;
        }

        /// <summary>
        /// Свойство класса - Отец
        /// </summary>
        public Adult Father
        {
            get { return _father; }
            set
            {
                if (value == null || value.Gender == Gender.Male)
                {
                    _father = value;
                }
                else
                {
                    throw new ArgumentException
                        ("Отец должен быть мужского пола");
                }
            }
        }

        /// <summary>
        /// Свойство класса - Мать
        /// </summary>
        public Adult Mother
        {
            get { return _mother; }
            set
            {
                if (value == null || value.Gender == Gender.Female)
                {
                    _mother = value;
                }
                else
                {
                    throw new ArgumentException
                        ("Мать должна быть женского пола");
                }
            }
        }

        /// <summary>
        /// Свойство класса - Учебное заведение
        /// </summary>
        public string Institute
        {
            get { return _institute; }
            set
            {
                _institute = $"Учебное заведение: {value} ";
                if (string.IsNullOrEmpty(value))
                {
                    _institute = "Нигде не учится";
                }
            }
        }

        /// <summary>
        /// Метод, показывающий информацию об 
        /// объекте класса <see cref="Child"/>
        /// </summary>
        /// <returns>
        /// Cтрока с информацией об объекте класса <see cref="Child"/> 
        /// </returns>
        public override string GetInfo()
        {
            string father = "";
            string mother = "";

            if (Father == null)
            {
                father = $"Отца нет";
            }
            else
            {
                father = $"Отец: {Father.FirstName} {Father.SecondName} ";
            }

            if (Mother == null)
            {
                mother = $"Матери нет";
            }
            else
            {
                mother = $"Мать: {Mother.FirstName} {Mother.SecondName} ";
            }
 
            return ($"{base.GetInfo()} " +
                $"{Institute} " +
                $"{father} " +
                $"{mother} \n");
        }

        /// <summary>
        /// Метод, уникальный для класса <see cref="Child"/>
        /// </summary>
        /// <returns></returns>
        public string ProveImChild()
        {
            return $"Не хочу в школу";
        }
    }
}
