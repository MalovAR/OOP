using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Passive_electrical_circuit_elements_Model
{
    public class Capacitor : CircuitElement
    {
        private double _capacity;

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

        public override Complex Impedance()
        {
            Complex result = new Complex(0, 1 / (2 * Math.PI * Frequency * Capacity / 1000000));
            return result;
        }
        public override string GetInfo()
        {
            return ($"Комплексное сопротивление конденсатора: {Impedance().Real}-j{Impedance().Imaginary} Ом");
        }
    }
}
