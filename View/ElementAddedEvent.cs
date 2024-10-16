using ElecticalElementsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class ElementAddedEvent : EventArgs
    {
        /// <summary>
        /// Свойство 
        /// </summary>
        public CircuitElementBase CircuitElementBase { get; }

        /// <summary>
        /// Конструктор класса ElementAddedEvent.
        /// </summary>
        /// <param name="circuitElementBase">Объект класса CircuitElementBase.</param>
        /// <exception cref="ArgumentNullException">Исключение.</exception>
        public ElementAddedEvent(CircuitElementBase circuitElementBase)
        {
            if (circuitElementBase == null)
            {
                throw new ArgumentNullException();
            }

            CircuitElementBase = circuitElementBase;
        }
    }
}
