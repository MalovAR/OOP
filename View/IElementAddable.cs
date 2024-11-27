namespace View
{
    using ElecticalElementsModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Интерфейс добавления элементов электрической цепи.
    /// </summary>
    public interface IElementAddable
    {
        /// <summary>
        /// Добавляемый элемент цепи.
        /// </summary>
        CircuitElementBase Element { get; }
    }
}
