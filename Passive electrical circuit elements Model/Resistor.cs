﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Passive_electrical_circuit_elements_Model
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
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Комплексное сопротивление конденсатора.</returns>
        public override Complex Impedance()
        {
            Complex result = new Complex(Resistance, 0);
            return result;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Комплексное сопротивление конденсатора.</returns>
        public override string GetInfo()
        {
            //TODO: RSDN
            return ($"Комплексное сопротивление резистора: {Impedance().Real}+j{Impedance().Imaginary} Ом");
        }
    }
}
