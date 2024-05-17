﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Passive_electrical_circuit_elements_Model
{
    public class Inductor : CircuitElement
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

        public override Complex Impedance()
        {
            Complex result = new Complex(0, 2*Math.PI*Frecuency*Inductance);
            return result;
        }

        public override string GetInfo()
        {
            return ($"Полное сопротивление элемента {Impedance().Real}+j{Impedance().Imaginary}");
        }
    }
}
