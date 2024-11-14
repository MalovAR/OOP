using System.Windows.Forms;

namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.calculateImpedanceGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateImpedanceDataGridView = new System.Windows.Forms.DataGridView();
            this.editElementsListGroupBox = new System.Windows.Forms.GroupBox();
            this._clearFilterButton = new System.Windows.Forms.Button();
            this._setFilterButton = new System.Windows.Forms.Button();
            this._deleteElementButton = new System.Windows.Forms.Button();
            this._addElementButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._elementTypeComboBox = new System.Windows.Forms.ComboBox();
            this.resistorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circuitElementBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resistorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
#if DEBUG
            this.randomButton = new System.Windows.Forms.Button();
#endif
            this.calculateImpedanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculateImpedanceDataGridView)).BeginInit();
            this.editElementsListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resistorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circuitElementBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateImpedanceGroupBox
            // 
            this.calculateImpedanceGroupBox.AutoSize = true;
            this.calculateImpedanceGroupBox.Controls.Add(this.calculateImpedanceDataGridView);
            this.calculateImpedanceGroupBox.Location = new System.Drawing.Point(0, 38);
            this.calculateImpedanceGroupBox.Name = "calculateImpedanceGroupBox";
            this.calculateImpedanceGroupBox.Size = new System.Drawing.Size(584, 347);
            this.calculateImpedanceGroupBox.TabIndex = 0;
            this.calculateImpedanceGroupBox.TabStop = false;
            this.calculateImpedanceGroupBox.Text = "Расчет комплексного сопротивления";
            // 
            // calculateImpedanceDataGridView
            // 
            this.calculateImpedanceDataGridView.AllowUserToOrderColumns = true;
            this.calculateImpedanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculateImpedanceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateImpedanceDataGridView.Location = new System.Drawing.Point(3, 17);
            this.calculateImpedanceDataGridView.Name = "calculateImpedanceDataGridView";
            this.calculateImpedanceDataGridView.Size = new System.Drawing.Size(578, 327);
            this.calculateImpedanceDataGridView.TabIndex = 0;
            // 
            // editElementsListGroupBox
            // 
            this.editElementsListGroupBox.Controls.Add(this._clearFilterButton);
            this.editElementsListGroupBox.Controls.Add(this._setFilterButton);
            this.editElementsListGroupBox.Controls.Add(this._deleteElementButton);
            this.editElementsListGroupBox.Controls.Add(this._addElementButton);
            this.editElementsListGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editElementsListGroupBox.Location = new System.Drawing.Point(0, 391);
            this.editElementsListGroupBox.Name = "editElementsListGroupBox";
            this.editElementsListGroupBox.Size = new System.Drawing.Size(584, 70);
            this.editElementsListGroupBox.TabIndex = 1;
            this.editElementsListGroupBox.TabStop = false;
            this.editElementsListGroupBox.Text = "Редактирование списка";
            // 
            // _clearFilterButton
            // 
            this._clearFilterButton.Location = new System.Drawing.Point(384, 20);
            this._clearFilterButton.Name = "_clearFilterButton";
            this._clearFilterButton.Size = new System.Drawing.Size(120, 40);
            this._clearFilterButton.TabIndex = 3;
            this._clearFilterButton.Text = "Сбросить фильтр";
            this._clearFilterButton.UseVisualStyleBackColor = true;
            // 
            // _setFilterButton
            // 
            this._setFilterButton.Location = new System.Drawing.Point(258, 20);
            this._setFilterButton.Name = "_setFilterButton";
            this._setFilterButton.Size = new System.Drawing.Size(120, 40);
            this._setFilterButton.TabIndex = 2;
            this._setFilterButton.Text = "Настроить фильтр";
            this._setFilterButton.UseVisualStyleBackColor = true;
            // 
            // _deleteElementButton
            // 
            this._deleteElementButton.Location = new System.Drawing.Point(132, 20);
            this._deleteElementButton.Name = "_deleteElementButton";
            this._deleteElementButton.Size = new System.Drawing.Size(120, 40);
            this._deleteElementButton.TabIndex = 1;
            this._deleteElementButton.Text = "Удалить";
            this._deleteElementButton.UseVisualStyleBackColor = true;
            // 
            // _addElementButton
            // 
            this._addElementButton.Location = new System.Drawing.Point(6, 20);
            this._addElementButton.Name = "_addElementButton";
            this._addElementButton.Size = new System.Drawing.Size(120, 40);
            this._addElementButton.TabIndex = 0;
            this._addElementButton.Text = "Добавить элемент";
            this._addElementButton.UseVisualStyleBackColor = true;
            this._addElementButton.Click += new System.EventHandler(this.ClickAddElementButton);
            // 
            // _elementTypeComboBox
            // 
            this._elementTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.resistorBindingSource, "ElementType", true));
            this._elementTypeComboBox.FormattingEnabled = true;
            this._elementTypeComboBox.Items.AddRange(new object[] {
            "Резистор",
            "Катушка индуктивности",
            "Конденсатор"});
            this._elementTypeComboBox.Location = new System.Drawing.Point(442, 12);
            this._elementTypeComboBox.Name = "_elementTypeComboBox";
            this._elementTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this._elementTypeComboBox.TabIndex = 2;
            this._elementTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.elementTypeComboBoxSelectedIndexChanged);
            // 
            // resistorBindingSource
            // 
            this.resistorBindingSource.DataSource = typeof(ElecticalElementsModel.Resistor);
            // 
            // circuitElementBaseBindingSource
            // 
            this.circuitElementBaseBindingSource.DataSource = typeof(ElecticalElementsModel.CircuitElementBase);
            // 
            // resistorBindingSource1
            // 
            this.resistorBindingSource1.DataSource = typeof(ElecticalElementsModel.Resistor);
#if DEBUG
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(6, 7);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(227, 30);
            this.randomButton.TabIndex = 3;
            this.randomButton.Text = "Добавить случайный элемент";
            this.randomButton.UseVisualStyleBackColor = true;
#endif
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 461);
#if DEBUG
            this.Controls.Add(this.randomButton);
#endif
            this.Controls.Add(this._elementTypeComboBox);
            this.Controls.Add(this.editElementsListGroupBox);
            this.Controls.Add(this.calculateImpedanceGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Расчет комплексного сопротивления";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.calculateImpedanceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculateImpedanceDataGridView)).EndInit();
            this.editElementsListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resistorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circuitElementBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private GroupBox calculateImpedanceGroupBox;
        private DataGridView calculateImpedanceDataGridView;
        private GroupBox editElementsListGroupBox;
        private Button _addElementButton;
        private Button _deleteElementButton;
        private Button _clearFilterButton;
        private Button _setFilterButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox _elementTypeComboBox;
        private BindingSource circuitElementBaseBindingSource;
        private BindingSource resistorBindingSource;
        private BindingSource resistorBindingSource1;
#if DEBUG
        private Button randomButton;
#endif
    }
}

