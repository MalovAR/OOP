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
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;
using DevExpress.Data.Browsing;
using System.Xml.Serialization;
using System.IO;

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

        /// <summary>
        /// Для файлов.
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<CircuitElementBase>));

        public MainForm()
        {
            InitializeComponent();
            frequencyNumBox.Enabled = false;
            impedanceRealNumBox.Enabled = false;
            impedanceImgNumBox.Enabled = false;
            frequencyCheckBox.CheckedChanged += CheckChange;
            ImpedanceCheckBox.CheckedChanged += CheckChange;
            _addElementButton.Click += ClickAddElementButton;
            _clearFilterButton.Click += RemoveFilter;
            _deleteElementButton.Click += ClickDeleteElementButton;
            _setFilterButton.Click += ApplyFilter;
            saveToolStripMenuItem.Click += SaveFile;
            loadToolStripMenuItem.Click += LoadFile;
#if DEBUG
            randomButton.Click += ClickRandomButton;
#endif
        }

        private void CheckChange(object sender, EventArgs e)
        {
            frequencyNumBox.Enabled = frequencyCheckBox.Checked;
            impedanceRealNumBox.Enabled = ImpedanceCheckBox.Checked;
            impedanceImgNumBox.Enabled = ImpedanceCheckBox.Checked;
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
            if (_isFiltered == true)
            {
                ApplyFilter(sender, circuitElementBase);
            }
        }

        private void ApplyFilter(object sender, EventArgs e)
        {
            _isFiltered = true;
            List<CircuitElementBase> filterdElements = null;
            List<string> typeFilterCriteria = new List<string>();
            CircuitElementBase element = new Resistor();
            double? frequency = GetValueFromNumBox(frequencyNumBox);
            double? impedanceReal = GetValueFromNumBox(impedanceRealNumBox);
            double? impedanceImg = GetValueFromNumBox(impedanceImgNumBox);
            if (ResistorCheckBox.Checked) 
            {
                typeFilterCriteria.Add(element.ElementType);
            } 
            if (InductorCheckBox.Checked)
            {
                element = new Inductor();
                typeFilterCriteria.Add(element.ElementType);
            }
            if (CapacitorCheckBox.Checked)
            {
                element = new Capacitor();
                typeFilterCriteria.Add(element.ElementType);
            }

            filterdElements = _elementsList.Where(obj =>
               (typeFilterCriteria.Count == 0 ||
               typeFilterCriteria.Contains(obj.ElementType))
               &&
               (!frequency.HasValue || obj.Frequency == frequency)
               &&
               (!impedanceReal.HasValue || obj.Impedance.Real == impedanceReal)
               &&
               (!impedanceImg.HasValue || obj.Impedance.Imaginary == impedanceImg)
               ).ToList();

            calculateImpedanceDataGridView.DataSource = filterdElements;

            if (filterdElements.Count == 0)
            {
                MessageBox.Show("Нет элементов, удовлетворяющих критериям фильтрации");
            }
     
        }

        private void RemoveFilter(object sender, EventArgs e)
        {
            if (_isFiltered == true) 
            {
                calculateImpedanceDataGridView.DataSource = _elementsList;
                _isFiltered = false;
                ResetControls(sender,e);
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

        private double? GetValueFromNumBox(NumBox numBox)
        {
            if (!numBox.Enabled)
            {
                return null;
            }
            if (string.IsNullOrWhiteSpace(numBox.Text))
            {
                return null;
            }
            else 
            {
               return Convert.ToDouble(numBox.Text);
            }
        }

        private void ResetControls(object sender, EventArgs e)
        {
            frequencyCheckBox.Checked = false;
            ImpedanceCheckBox.Checked = false;
            ResistorCheckBox.Checked = false;
            CapacitorCheckBox.Checked = false;
            InductorCheckBox.Checked = false;    
        }

        /// <summary>
        /// Сохранение файла.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void SaveFile(object sender, EventArgs e)
        {
            if (_elementsList.Count == 0)
            {
                MessageBox.Show("Отсутствуют данные для сохранения.",
                    "Данные не сохранены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*.elm)|*.elm|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream file = System.IO.File.Create(path))
                {
                    _serializer.Serialize(file, _elementsList);
                }
                MessageBox.Show("Файл успешно сохранён.",
                    "Сохранение завершено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Открытие файла.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void LoadFile(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.elm)|*.elm|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog.FileName.ToString();
            try
            {
                using (var file = new StreamReader(path))
                {
                    _elementsList =
                        (BindingList<CircuitElementBase>)_serializer.Deserialize(file);
                }

                calculateImpedanceDataGridView.DataSource = _elementsList;
                calculateImpedanceDataGridView.CurrentCell = null;
                MessageBox.Show("Файл успешно загружен.",
                    "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить файл.\n" +
                    "Файл повреждён или не соответствует формату.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
