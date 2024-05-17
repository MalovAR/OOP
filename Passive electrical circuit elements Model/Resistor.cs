using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Passive_electrical_circuit_elements_Model
{
    public class Resistor : CircuitElement
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

        public override Complex Impedance()
        {
            Complex result = new Complex(Resistance, 0);
            return result;
        }
        public override string GetInfo()
        {
            return ($"Полное сопротивление элемента {Impedance().Real}+j{Impedance().Imaginary}");
        }
    }
}
