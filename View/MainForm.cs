using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElecticalElementsModel;

namespace View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список элементов электрической цепи на форме.
        /// </summary>
        private BindingList<CircuitElementBase> _elementsList = 
            new BindingList<CircuitElementBase>();

        /// <summary>
        /// Состояние формы добавления.
        /// </summary>
        private bool _isAddFormOpened = false;

        /// <summary>
        /// Состояние формы фильтра.
        /// </summary>
        private bool _isFilterFormOpened = false;

        private bool _isFiltered = false;



        public MainForm()
        {
            InitializeComponent();

            _addElementButton.Click += ClickAddElementButton;
        }

        private void ClickAddElementButton(object sender, EventArgs e)
        {
            if (_isAddFormOpened == false && _isFiltered == false)
            {
                _isAddFormOpened = true;
                AddElementForm addElementForm = new AddElementForm();
                addElementForm.FormClosed += (s, args) =>
                { _isAddFormOpened = false; };
                addElementForm.ElementAdded += AddedElement;
                addElementForm.Show();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Инициализируйте столбцы DataGridView
            _elementsList
        }

        private void CreateTable(BindingList<CircuitElementBase> elements, 
            DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(elements, null);
            dataGridView.DataSource = source;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Обработчик добавления данных.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="circuitElementBase">Объект класса 
        /// CircuitElementBase.</param>
        private void AddedElement(object sender, 
            EventArgs circuitElementBase)
        {
            ElementAddedEvent addedEventArgs =
                circuitElementBase as ElementAddedEvent;

            _elementsList.Add(addedEventArgs?.CircuitElementBase);
        }

        
    }
}
