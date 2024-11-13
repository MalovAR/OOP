using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Filtering;
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
        /// Состояние фильтрации.
        /// </summary>
        private bool _isFiltered = false;

        public MainForm()
        {
            InitializeComponent();

            _addElementButton.Click += ClickAddElementButton;
            _elementTypeComboBox.SelectedIndexChanged += elementTypeComboBoxSelectedIndexChanged;
            _clearFilterButton.Click += RemoveFilter;
        }

        private void ClickAddElementButton(object sender, EventArgs e)
        {
            if (_isAddFormOpened == false)
            {
                _isAddFormOpened = true;
                AddElementForm addElementForm = new AddElementForm();
                addElementForm.FormClosed += (s, args) =>
                { _isAddFormOpened = false; };
                addElementForm.ElementAdded += AddedElement;
                addElementForm.Show();
            }

        }

        private void ClickDeleteElementButton(object sender, EventArgs e)
        {

           

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _elementsList = new BindingList<CircuitElementBase>();
            CreateTable(_elementsList, calculateImpedanceDataGridView);
        }

        private void CreateTable(BindingList<CircuitElementBase> elements, 
            DataGridView dataGridView)
        {
            dataGridView.DataSource = elements;
            dataGridView.Columns.Remove("Impedance");
            dataGridView.RowHeadersVisible = false; 
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

        private void ApplyFilter()
        {
            string filterCriteria = _elementTypeComboBox.SelectedItem.ToString();

            if (filterCriteria == "Резистор")
            {
                _isFiltered = true;
                calculateImpedanceDataGridView.DataSource =
                    _elementsList.Where(obj => obj.ElementType == "Резистор").ToList();
            }
            if (filterCriteria == "Катушка индуктивности")
            {
                _isFiltered = true;
                calculateImpedanceDataGridView.DataSource =
                    _elementsList.Where(obj => obj.ElementType == "Катушка индуктивности").ToList();
            }
            if (filterCriteria == "Конденсатор")
            {
                _isFiltered = true;
                calculateImpedanceDataGridView.DataSource =
                    _elementsList.Where(obj => obj.ElementType == "Конденсатор").ToList();
            }
        }

        private void RemoveFilter(object sender, EventArgs e)
        {
            if (_isFiltered == true) 
            {

                _isFiltered = false;
            }
        }
        private void elementTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
            calculateImpedanceDataGridView.Columns.Remove("Impedance");
        }
    }
}
