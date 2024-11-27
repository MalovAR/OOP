using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public class NegativeNumBox : NumBox
    {
        /// <summary>
        /// Конструктор класса NegativeNumBox.
        /// </summary>
        public NegativeNumBox()
        {
            KeyPress += new KeyPressEventHandler(CheckInput);
        }
        /// <summary>
        /// Корректировка ввода данных.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        public override void CheckInput(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol == '.' || symbol == ',' || symbol == '-')
                && (Text.IndexOf(',') != -1))
            {
                e.Handled = true;
                return;
            }

            if ((symbol == '-')
                && Text.IndexOf('-') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(symbol) && symbol != (char)Keys.Back
                && symbol != ',' && symbol != '.' && symbol != '-')
            {
                e.Handled = true;
            }

            if (symbol == '.')
            {
                e.KeyChar = ',';
            }
        }
    }
}
