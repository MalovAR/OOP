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
    /// Форма для ввода параметров конденсатора.
    /// </summary>
    public partial class AddCapacitorUserControl : UserControl, IElementAddable
    {
        //TODO: XML+
        /// <summary>
        /// Конструктор класса AddCapacitorUserControl.
        /// </summary>
        public AddCapacitorUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляемый элемент цепи - конденсатор.
        /// </summary>
        public CircuitElementBase Element 
        {
            get
            {
                return new Capacitor()
                {
                    Capacity = Convert.ToDouble(
                            capacityNumBox.Text),
                    Frequency = Convert.ToDouble(
                            frequencyNumBox.Text)
                };
            }        
        }
    }
}
