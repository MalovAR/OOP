using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Passive_electrical_circuit_elements_Model
{
    public abstract class BaseCircuitElement
    {
        /// <summary>
        /// Поле класса - частота электрического тока в цепи
        /// </summary>
        private double _frequency;

        /// <summary>
        /// Поле класса - минимальное значение величины
        /// </summary>
        private const int _minValue = 0;

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
        /// Метод, проверяющий, что значение величины не отрицательное
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
        /// Расчет комплексного сопротивления элемента
        /// </summary>
        /// <returns></returns>
        public abstract Complex Impedance();

        public abstract string GetInfo();
    }
}
