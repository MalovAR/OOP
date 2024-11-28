using ElecticalElementsModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма программы для добавления элемента.
    /// </summary>
    public partial class AddElementForm : Form
    {
        /// <summary>
        /// Список добавленных элементов.
        /// </summary>
        private List<IElementAddable> _elementAddableControls; 

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

            _resistorRadioButton.CheckedChanged +=
                ChooseElement;

            _inductorRadioButton.CheckedChanged +=
                ChooseElement;

            _capacitorRadioButton.CheckedChanged +=
                ChooseElement;

            _addButton.Click += ClickAddButton;

            _elementAddableControls = new List<IElementAddable>()
            {
                _addResistorUserControl,
                _addInductorUserControl,
                _addCapacitorUserControl
            };
        }

        /// <summary>
        /// Метод отображения полей для ввода данных резистора.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChooseElement(object sender, EventArgs e)
        {
            _addResistorUserControl.Visible = _resistorRadioButton.Checked;
            _addInductorUserControl.Visible = _inductorRadioButton.Checked;
            _addCapacitorUserControl.Visible = _capacitorRadioButton.Checked;
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
                CircuitElementBase circuitElementBase = null;
                foreach (var userControl in _elementAddableControls)
                {
                    if (((UserControl)userControl).Visible)
                    {
                        circuitElementBase = userControl.Element;
                    }
                }

                ElementAdded?.Invoke(this,
                    new ElementAddedEvent(circuitElementBase));
               }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}. Введите корректные данные.",
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
