using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Xml.Serialization;

namespace ElecticalElementsModel
{
    /// <summary>
    /// Абстрактный класс элемента электрической цепи.
    /// </summary>
    [XmlInclude(typeof(Resistor))]
    [XmlInclude(typeof(Inductor))]
    [XmlInclude(typeof(Capacitor))]
    //TODO: RSDN+
    /// <summary>
    /// Абстрактный базовый класс элемента электрической цепи.
    /// </summary>
    public abstract class CircuitElementBase
    {
        /// <summary>
        /// Поле класса - частота электрического тока в цепи.
        /// </summary>
        private double _frequency;

        /// <summary>
        /// Поле класса - минимальное значение величины.
        /// </summary>
        private const int _minValue = 0;

        /// <summary>
        /// Свойство класса - частота электрического тока в цепи.
        /// </summary>
        [DisplayName("Частота, Гц")]
        public double Frequency 
        {
            get  
            {
                return Math.Round(_frequency,4); 
            }
            set
            {
                _frequency = CheckValue(value);
            }
        }

        /// <summary>
        /// Свойство класса - тип элемента
        /// </summary>
        [DisplayName("Тип элемента")]
        public abstract string ElementType
        {
            get;
        }

        /// <summary>
        /// Неотображаемое свойство класса - комплексное сопротивление
        /// </summary>
        [Browsable(false)]
        public abstract Complex Impedance
        {
            get; 
        }

        /// <summary>
        /// Отображаемое свойство класса - комплексное сопротивление
        /// </summary>
        [DisplayName("Сопротивление, Ом")]
        public string ImpedanceShow
        {
            get {
                if (Impedance.Imaginary < 0)
                {
                    return $"{Math.Round(Impedance.Real,2)} " +
                           $"- j{-Math.Round(Impedance.Imaginary,2)}";
                }
                else
                {
                    return $"{Math.Round(Impedance.Real,2)} " +
                           $"+ j{Math.Round(Impedance.Imaginary,2)}";
                }
            }
        }

        /// <summary>
        /// Метод, проверяющий, что значение величины не отрицательное.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double CheckValue(double value)
        {
            if (value < _minValue || double.IsNaN(value))
            {
                throw new ArgumentException
                    ("Не может быть отрицательной величиной");
            }
            else
            {
                return value;
            }
        }
        
        /// <summary>
        /// Метод вывода комплексного сопротивления
        /// элемента электрической цепи.
        /// </summary>
        /// <returns></returns>
        public abstract string GetInfo(int accuracy);
    }
}
