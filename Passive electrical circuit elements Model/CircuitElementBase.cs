using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ElecticalElementsModel
{
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
        /// Расчет комплексного сопротивления элемента.
        /// </summary>
        /// <returns></returns>
        public abstract Complex Impedance();

        /// <summary>
        /// Метод вывода комплексного сопротивления
        /// элемента электрической цепи.
        /// </summary>
        /// <returns></returns>
        public abstract string GetInfo(int accuracy);
    }
}
