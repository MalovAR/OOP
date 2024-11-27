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
    public partial class AddResistorUserControl : UserControl, IElementAddable
    {
        public AddResistorUserControl()
        {
            InitializeComponent();
        }

        public CircuitElementBase Element
        {
            get
            {
                return new Resistor()
                {
                    Resistance = Convert.ToDouble(
                            _resistanceNumBox.Text)
                };
            }
        }
    }
}
