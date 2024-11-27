using ElecticalElementsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма для ввода параметров катушки индуктивности.
    /// </summary>
    public partial class AddInductorUserControl : UserControl, IElementAddable
    {
        /// <summary>
        /// Конструктор класса AddInductorUserControl.
        /// </summary>
        public AddInductorUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляемый элемент цепи - катушка индуктивности.
        /// </summary>
        public CircuitElementBase Element
        {
            get
            {
                return new Inductor()
                {
                    Inductance = Convert.ToDouble(
                            _inductanceNumBox.Text),
                    Frequency = Convert.ToDouble(
                            _frequencyNumBox.Text)
                };
            }
        }
    }
}
