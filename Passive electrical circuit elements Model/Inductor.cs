using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ElecticalElementsModel
{
    /// <summary>
    /// Класс элемента электрической цепи: Катушка индуктивности
    /// </summary>
    public class Inductor : CircuitElementBase
    {
        /// <summary>
        /// Поле класса - индуктивность
        /// </summary>
        private double _inductance;

        /// <summary>
        /// Свойство класса - индуктивность
        /// </summary>
        public double Inductance
        {
            get 
            { 
                return _inductance; 
            }
            set 
            {
                _inductance = CheckValue(value);
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Комплексное сопротивление 
        /// катушки индуктивности.</returns>
        public override Complex Impedance()
        {
            Complex result = 
                new Complex(0, 2 * Math.PI * Frequency * Inductance);
            return result;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Комплексное сопротивление 
        /// катушки индуктивности.</returns>
        public override string GetInfo(int accuracy)
        {
            return ($"Комплексное сопротивление катушки индуктивности: " +
                $"{Math.Round(Impedance().Real, accuracy)}" +
                $"+j{Math.Round(Impedance().Imaginary, accuracy)} Ом");
        }
    }
}
