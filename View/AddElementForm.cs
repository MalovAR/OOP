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
    public partial class AddElementForm : Form
    {
        /// <summary>
        /// Событие добавления движения.
        /// </summary>
        public EventHandler ElementAdded;

        public AddElementForm()
        {
            InitializeComponent();

            closeButton.Click += ClickCancelButton;

            resistorRadioButton.CheckedChanged +=
                ChooseResistor;

            inductorRadioButton.CheckedChanged +=
                ChooseInductor;

            capacitorRadioButton.CheckedChanged +=
                ChooseCapacitor;

            addButton.Click += ClickAddButton;
        }

        /// <summary>
        /// Метод 
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChooseResistor(object sender, EventArgs e)
        {
            addResistorUserControl.Visible = true;
            addInductorUserControl.Visible = false;
            addCapacitorUserControl.Visible = false;
        }

        /// <summary>
        /// Метод 
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChooseInductor(object sender, EventArgs e)
        {
            addResistorUserControl.Visible = false;
            addInductorUserControl.Visible = true;
            addCapacitorUserControl.Visible = false;
        }

        /// <summary>
        /// Метод 
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChooseCapacitor(object sender, EventArgs e)
        {
            addResistorUserControl.Visible = false;
            addInductorUserControl.Visible = false;
            addCapacitorUserControl.Visible = true;
        }

        private void ClickAddButton(object sender, EventArgs e)
        {
            try
            {
                CircuitElementBase CircuitElementBase = null;

                if (addResistorUserControl.Visible)
                {
                    CircuitElementBase = new Resistor()
                    {
                        Resistance = Convert.ToDouble(
                            addResistorUserControl.
                            resistanceNumBox.Text)
                    };
                }

                if (addInductorUserControl.Visible)
                {
                    CircuitElementBase = new Inductor()
                    {
                        Inductance = Convert.ToDouble(
                            addInductorUserControl.inductanceNumBox.Text),
                        Frequency = Convert.ToDouble(
                            addInductorUserControl.frequencyNumBox.Text)
                    };
                }

                if (addCapacitorUserControl.Visible)
                {
                    CircuitElementBase = new Capacitor()
                    {
                        Capacity = Convert.ToDouble(
                            addCapacitorUserControl.capacityNumBox.Text),
                        Frequency = Convert.ToDouble(
                            addCapacitorUserControl.frequencyNumBox.Text)
                    };
                }

                ElementAdded?.Invoke(this,
                    new ElementAddedEvent(CircuitElementBase));
               }
            catch
            {
                MessageBox.Show("Введите корректные данные.",
                    "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void ClickCancelButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}
