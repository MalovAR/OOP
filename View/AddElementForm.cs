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
    /// Форма программы для добавления элемента.
    /// </summary>
    public partial class AddElementForm : Form
    {
        /// <summary>
        /// Событие добавления движения.
        /// </summary>
        public EventHandler ElementAdded;

        /// <summary>
        /// Конструктор класса AddElementForm.
        /// </summary>
        public AddElementForm()
        {
            InitializeComponent();

            _closeButton.Click += ClickCancelButton;

            resistorRadioButton.CheckedChanged +=
                ChooseResistor;

            _inductorRadioButton.CheckedChanged +=
                ChooseInductor;

            _capacitorRadioButton.CheckedChanged +=
                ChooseCapacitor;

            _addButton.Click += ClickAddButton;
        }

        /// <summary>
        /// Метод отображения полей для ввода данных резистора.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChooseResistor(object sender, EventArgs e)
        {
            _addResistorUserControl.Visible = true;
            _addInductorUserControl.Visible = false;
            _addCapacitorUserControl.Visible = false;
        }

        /// <summary>
        /// Метод отображения полей для ввода данных катушки индуктивности. 
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChooseInductor(object sender, EventArgs e)
        {
            _addResistorUserControl.Visible = false;
            _addInductorUserControl.Visible = true;
            _addCapacitorUserControl.Visible = false;
        }

        /// <summary>
        /// Метод отображения полей для ввода данных конденсатора.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChooseCapacitor(object sender, EventArgs e)
        {
            _addResistorUserControl.Visible = false;
            _addInductorUserControl.Visible = false;
            _addCapacitorUserControl.Visible = true;
        }

        /// <summary>
        /// Метод нажатия на кнопку "Рассчитать".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickAddButton(object sender, EventArgs e)
        {
            try
            {
                CircuitElementBase CircuitElementBase = null;

                if (_addResistorUserControl.Visible)
                {
                    CircuitElementBase = new Resistor()
                    {
                        Resistance = Convert.ToDouble(
                            _addResistorUserControl.
                            resistanceNumBox.Text)
                    };
                }

                if (_addInductorUserControl.Visible)
                {
                    CircuitElementBase = new Inductor()
                    {
                        Inductance = Convert.ToDouble(
                            _addInductorUserControl.inductanceNumBox.Text),
                        Frequency = Convert.ToDouble(
                            _addInductorUserControl.frequencyNumBox.Text)
                    };
                }

                if (_addCapacitorUserControl.Visible)
                {
                    CircuitElementBase = new Capacitor()
                    {
                        Capacity = Convert.ToDouble(
                            _addCapacitorUserControl.capacityNumBox.Text),
                        Frequency = Convert.ToDouble(
                            _addCapacitorUserControl.frequencyNumBox.Text)
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

        /// <summary>
        /// Метод нажатия на кнопку "Закрыть".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCancelButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}
