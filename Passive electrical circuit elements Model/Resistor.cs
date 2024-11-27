using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ElecticalElementsModel
{
    /// <summary>
    /// Класс элемента электрической цепи: Резистор
    /// </summary>
    public class Resistor : CircuitElementBase
    {
        /// <summary>
        /// Поле класса - активное сопротивление
        /// </summary>
        private double _resistance;

        /// <summary>
        /// Свойство класса - активное сопротивление
        /// </summary>
        public double Resistance 
        { 
            get 
            { 
                return _resistance; 
            } 
            set 
            {
                _resistance = CheckValue(value);
            } 
        }

        /// <summary>
        /// Свойство класса - тип элемента цепи.
        /// </summary>
        public override string ElementType
        {
            get { return "Резистор"; }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Комплексное сопротивление конденсатора.</returns>
        public override Complex Impedance
        {
            get {
                Complex result = new Complex(Resistance, 0);
                return result;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Комплексное сопротивление конденсатора.</returns>
        public override string GetInfo(int accuracy)
        {
            return ($"Комплексное сопротивление резистора: " +
                $"{Math.Round(Impedance.Real, accuracy)}" +
                $"+j{Math.Round(Impedance.Imaginary, accuracy)} Ом");
        }
    }
}
