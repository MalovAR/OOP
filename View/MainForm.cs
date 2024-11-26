using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraEditors.Filtering;
using ElecticalElementsModel;
using static DevExpress.Data.Helpers.ExpressiveSortInfo;

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
            _elementTypeComboBox.SelectedIndexChanged += ApplyFilter;
            checkedListBox1.ItemCheck += FilterByType;
            _clearFilterButton.Click += RemoveFilter;
            _deleteElementButton.Click += ClickDeleteElementButton;
#if DEBUG
            randomButton.Click += ClickRandomButton;
#endif

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
            foreach (DataGridViewRow item in calculateImpedanceDataGridView.SelectedRows)
            {
                if (item.DataBoundItem is CircuitElementBase element)
                {
                    _elementsList.Remove(element);
                }
            }
            if (_isFiltered == true)
            {
                ApplyFilter(sender, e);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateTable(_elementsList, calculateImpedanceDataGridView);
        }

        private void CreateTable(BindingList<CircuitElementBase> elements, 
            DataGridView dataGridView)
        {
            dataGridView.DataSource = elements;
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

        private void ApplyFilter(object sender, EventArgs e)
        {
            string filterCriteria = _elementTypeComboBox.SelectedItem.ToString();

            _isFiltered = true;

            if (filterCriteria == _elementTypeComboBox.Items[0].ToString())
            {
                Resistor element = new Resistor();
                calculateImpedanceDataGridView.DataSource =
                    _elementsList.Where(obj => obj.ElementType == element.ElementType).ToList();
            }
            if (filterCriteria == _elementTypeComboBox.Items[1].ToString())
            {
                Inductor element = new Inductor();
                calculateImpedanceDataGridView.DataSource =
                    _elementsList.Where(obj => obj.ElementType == element.ElementType).ToList();
            }
            if (filterCriteria == _elementTypeComboBox.Items[2].ToString())
            {
                Capacitor element = new Capacitor();
                calculateImpedanceDataGridView.DataSource =
                    _elementsList.Where(obj => obj.ElementType == element.ElementType).ToList();
            }
        }

        private void RemoveFilter(object sender, EventArgs e)
        {
            if (_isFiltered == true) 
            {
                calculateImpedanceDataGridView.DataSource = _elementsList;
                _isFiltered = false;
            }
        }
       
        private void ClickRandomButton(object sender, EventArgs e)
        {

            _elementsList.Add(RandomElement.GetRandomElement());
            if (_isFiltered == true)
            {
                ApplyFilter(sender, e);
            }
        }


        private void FilterByType(object sender, EventArgs e)
        {

            var selectedItems = checkedListBox1.CheckedItems.Cast<string>().ToList();
            _isFiltered = true;
           
            if (selectedItems.Count == 0)
            {
                calculateImpedanceDataGridView.DataSource = _elementsList;
                _isFiltered = false;
            }

            var filteredElements = _elementsList.Where
                (element => selectedItems.Contains(element.ElementType)).ToList();

            calculateImpedanceDataGridView.DataSource = filteredElements;
        }
    }
}
