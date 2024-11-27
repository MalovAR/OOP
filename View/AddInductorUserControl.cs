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
    public partial class AddInductorUserControl : UserControl, IElementAddable
    {
        public AddInductorUserControl()
        {
            InitializeComponent();
        }

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
