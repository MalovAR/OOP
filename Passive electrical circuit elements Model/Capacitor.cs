using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//TODO: XML
namespace Passive_electrical_circuit_elements_Model
{
    /// <summary>
    /// Класс элемента электрической цепи: Конденсатор
    /// </summary>
    public class Capacitor : CircuitElementBase
    {
        /// <summary>
        /// Поле класса - ёмкость
        /// </summary>
        private double _capacity;

        /// <summary>
        /// Свойство класса - ёмкость
        /// </summary>
        public double Capacity 
        { 
            get 
            { 
                return _capacity; 
            } 
            set 
            {
                _capacity = CheckValue(value);
            } 
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Комплексное сопротивление резистора.</returns>
        public override Complex Impedance()
        {
            Complex result = 
                new Complex(0, 1 / (2 * Math.PI * Frequency * Capacity));
            return result;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Комплексное сопротивление резистора.</returns>
        public override string GetInfo()
        {
            return ($"Комплексное сопротивление конденсатора: " +
                $"{Impedance().Real}" +
                $"-j{Math.Round(Impedance().Imaginary,3)} Ом");
        }
    }
}
