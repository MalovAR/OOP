using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ElecticalElementsModel
{
    //TODO: RSDN
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
        /// Частота электрического тока в цепи.
        /// </summary>
        [DisplayName("Частота, Гц")]
        public double Frequency 
        {
            get  
            {
                return _frequency; 
            }
            set
            {
                _frequency = CheckValue(value);
            }
        }

        [DisplayName("Тип элемента")]
        public abstract string ElementType
        {
            get;
        }

        [Browsable(false)]
        public abstract Complex Impedance
        {
            get; 
        }

        [DisplayName("Сопротивление, Ом")]
        public string ImpedanceShow
        {
            get {
                if (Impedance.Imaginary < 0)
                {
                    return $"{Impedance.Real} - j{-Impedance.Imaginary}";
                }
                else
                {
                    return $"{Impedance.Real} + j{Impedance.Imaginary}";
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
            if (value < _minValue)
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
