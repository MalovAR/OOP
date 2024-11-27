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
            this._calculateImpedanceGroupBox = new System.Windows.Forms.GroupBox();
            this._calculateImpedanceDataGridView = new System.Windows.Forms.DataGridView();
            this._setFilterButton = new System.Windows.Forms.Button();
            this._clearFilterButton = new System.Windows.Forms.Button();
            this._randomButton = new System.Windows.Forms.Button();
            this._editElementsListGroupBox = new System.Windows.Forms.GroupBox();
            this._deleteElementButton = new System.Windows.Forms.Button();
            this._addElementButton = new System.Windows.Forms.Button();
            this._capacitorCheckBox = new System.Windows.Forms.CheckBox();
            this._inductorCheckBox = new System.Windows.Forms.CheckBox();
            this._resistorCheckBox = new System.Windows.Forms.CheckBox();
            this._filterGroupBox = new System.Windows.Forms.GroupBox();
            this._jLabel = new System.Windows.Forms.Label();
            this._ohmLabel = new System.Windows.Forms.Label();
            this._hzLabel = new System.Windows.Forms.Label();
            this._frequencyNumBox = new View.NumBox();
            this._frequencyCheckBox = new System.Windows.Forms.CheckBox();
            this._impedanceRealNumBox = new View.NumBox();
            this._impedanceCheckBox = new System.Windows.Forms.CheckBox();
            this._impedanceImgNumBox = new View.NegativeNumBox();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._fileMenuStrip = new System.Windows.Forms.MenuStrip();
            this._calculateImpedanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._calculateImpedanceDataGridView)).BeginInit();
            this._editElementsListGroupBox.SuspendLayout();
            this._filterGroupBox.SuspendLayout();
            this._fileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _calculateImpedanceGroupBox
            // 
            this._calculateImpedanceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._calculateImpedanceGroupBox.AutoSize = true;
            this._calculateImpedanceGroupBox.Controls.Add(this._calculateImpedanceDataGridView);
            this._calculateImpedanceGroupBox.Location = new System.Drawing.Point(0, 27);
            this._calculateImpedanceGroupBox.Name = "_calculateImpedanceGroupBox";
            this._calculateImpedanceGroupBox.Size = new System.Drawing.Size(584, 370);
            this._calculateImpedanceGroupBox.TabIndex = 0;
            this._calculateImpedanceGroupBox.TabStop = false;
            this._calculateImpedanceGroupBox.Text = "Отображение списка элементов";
            // 
            // _calculateImpedanceDataGridView
            // 
            this._calculateImpedanceDataGridView.AllowUserToAddRows = false;
            this._calculateImpedanceDataGridView.AllowUserToDeleteRows = false;
            this._calculateImpedanceDataGridView.AllowUserToOrderColumns = true;
            this._calculateImpedanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._calculateImpedanceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._calculateImpedanceDataGridView.Location = new System.Drawing.Point(3, 17);
            this._calculateImpedanceDataGridView.Name = "_calculateImpedanceDataGridView";
            this._calculateImpedanceDataGridView.ReadOnly = true;
            this._calculateImpedanceDataGridView.Size = new System.Drawing.Size(578, 350);
            this._calculateImpedanceDataGridView.TabIndex = 0;
            // 
            // _setFilterButton
            // 
            this._setFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._setFilterButton.Location = new System.Drawing.Point(449, 16);
            this._setFilterButton.Name = "_setFilterButton";
            this._setFilterButton.Size = new System.Drawing.Size(120, 30);
            this._setFilterButton.TabIndex = 2;
            this._setFilterButton.Text = "Отфильтровать";
            this._setFilterButton.UseVisualStyleBackColor = true;
            // 
            // _clearFilterButton
            // 
            this._clearFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._clearFilterButton.Location = new System.Drawing.Point(449, 52);
            this._clearFilterButton.Name = "_clearFilterButton";
            this._clearFilterButton.Size = new System.Drawing.Size(120, 30);
            this._clearFilterButton.TabIndex = 3;
            this._clearFilterButton.Text = "Сбросить фильтр";
            this._clearFilterButton.UseVisualStyleBackColor = true;
            // 
            // _randomButton
            // 
            this._randomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._randomButton.Location = new System.Drawing.Point(444, 20);
            this._randomButton.Name = "_randomButton";
            this._randomButton.Size = new System.Drawing.Size(134, 40);
            this._randomButton.TabIndex = 3;
            this._randomButton.Text = "Добавить случайный элемент";
            this._randomButton.UseVisualStyleBackColor = true;
            // 
            // _editElementsListGroupBox
            // 
            this._editElementsListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._editElementsListGroupBox.Controls.Add(this._randomButton);
            this._editElementsListGroupBox.Controls.Add(this._deleteElementButton);
            this._editElementsListGroupBox.Controls.Add(this._addElementButton);
            this._editElementsListGroupBox.Location = new System.Drawing.Point(0, 501);
            this._editElementsListGroupBox.Name = "_editElementsListGroupBox";
            this._editElementsListGroupBox.Size = new System.Drawing.Size(584, 70);
            this._editElementsListGroupBox.TabIndex = 1;
            this._editElementsListGroupBox.TabStop = false;
            this._editElementsListGroupBox.Text = "Редактирование списка";
            // 
            // _deleteElementButton
            // 
            this._deleteElementButton.Location = new System.Drawing.Point(132, 20);
            this._deleteElementButton.Name = "_deleteElementButton";
            this._deleteElementButton.Size = new System.Drawing.Size(120, 40);
            this._deleteElementButton.TabIndex = 1;
            this._deleteElementButton.Text = "Удалить \r\nэлемент";
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
            // _capacitorCheckBox
            // 
            this._capacitorCheckBox.AutoSize = true;
            this._capacitorCheckBox.Location = new System.Drawing.Point(6, 70);
            this._capacitorCheckBox.Name = "_capacitorCheckBox";
            this._capacitorCheckBox.Size = new System.Drawing.Size(103, 19);
            this._capacitorCheckBox.TabIndex = 7;
            this._capacitorCheckBox.Text = "Конденсатор";
            this._capacitorCheckBox.UseVisualStyleBackColor = true;
            // 
            // _inductorCheckBox
            // 
            this._inductorCheckBox.AutoSize = true;
            this._inductorCheckBox.Location = new System.Drawing.Point(6, 37);
            this._inductorCheckBox.Name = "_inductorCheckBox";
            this._inductorCheckBox.Size = new System.Drawing.Size(113, 34);
            this._inductorCheckBox.TabIndex = 6;
            this._inductorCheckBox.Text = "Катушка \r\nиндуктивности";
            this._inductorCheckBox.UseVisualStyleBackColor = true;
            // 
            // _resistorCheckBox
            // 
            this._resistorCheckBox.AutoSize = true;
            this._resistorCheckBox.Location = new System.Drawing.Point(6, 20);
            this._resistorCheckBox.Name = "_resistorCheckBox";
            this._resistorCheckBox.Size = new System.Drawing.Size(81, 19);
            this._resistorCheckBox.TabIndex = 5;
            this._resistorCheckBox.Text = "Резистор";
            this._resistorCheckBox.UseVisualStyleBackColor = true;
            // 
            // _filterGroupBox
            // 
            this._filterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filterGroupBox.Controls.Add(this._jLabel);
            this._filterGroupBox.Controls.Add(this._ohmLabel);
            this._filterGroupBox.Controls.Add(this._hzLabel);
            this._filterGroupBox.Controls.Add(this._frequencyNumBox);
            this._filterGroupBox.Controls.Add(this._frequencyCheckBox);
            this._filterGroupBox.Controls.Add(this._impedanceRealNumBox);
            this._filterGroupBox.Controls.Add(this._impedanceCheckBox);
            this._filterGroupBox.Controls.Add(this._impedanceImgNumBox);
            this._filterGroupBox.Controls.Add(this._inductorCheckBox);
            this._filterGroupBox.Controls.Add(this._capacitorCheckBox);
            this._filterGroupBox.Controls.Add(this._resistorCheckBox);
            this._filterGroupBox.Controls.Add(this._clearFilterButton);
            this._filterGroupBox.Controls.Add(this._setFilterButton);
            this._filterGroupBox.Location = new System.Drawing.Point(6, 403);
            this._filterGroupBox.Name = "_filterGroupBox";
            this._filterGroupBox.Size = new System.Drawing.Size(578, 92);
            this._filterGroupBox.TabIndex = 8;
            this._filterGroupBox.TabStop = false;
            this._filterGroupBox.Text = "Найтройка фильтрации";
            // 
            // _jLabel
            // 
            this._jLabel.AutoSize = true;
            this._jLabel.Location = new System.Drawing.Point(313, 20);
            this._jLabel.Name = "_jLabel";
            this._jLabel.Size = new System.Drawing.Size(10, 15);
            this._jLabel.TabIndex = 18;
            this._jLabel.Text = "j";
            // 
            // _ohmLabel
            // 
            this._ohmLabel.AutoSize = true;
            this._ohmLabel.Location = new System.Drawing.Point(379, 20);
            this._ohmLabel.Name = "_ohmLabel";
            this._ohmLabel.Size = new System.Drawing.Size(25, 15);
            this._ohmLabel.TabIndex = 17;
            this._ohmLabel.Text = "Ом";
            // 
            // _hzLabel
            // 
            this._hzLabel.AutoSize = true;
            this._hzLabel.Location = new System.Drawing.Point(312, 46);
            this._hzLabel.Name = "_hzLabel";
            this._hzLabel.Size = new System.Drawing.Size(21, 15);
            this._hzLabel.TabIndex = 16;
            this._hzLabel.Text = "Гц";
            // 
            // _frequencyNumBox
            // 
            this._frequencyNumBox.Location = new System.Drawing.Point(256, 43);
            this._frequencyNumBox.Name = "_frequencyNumBox";
            this._frequencyNumBox.Size = new System.Drawing.Size(50, 21);
            this._frequencyNumBox.TabIndex = 13;
            // 
            // _frequencyCheckBox
            // 
            this._frequencyCheckBox.AutoSize = true;
            this._frequencyCheckBox.Location = new System.Drawing.Point(129, 45);
            this._frequencyCheckBox.Name = "_frequencyCheckBox";
            this._frequencyCheckBox.Size = new System.Drawing.Size(78, 19);
            this._frequencyCheckBox.TabIndex = 11;
            this._frequencyCheckBox.Text = "Частота:";
            this._frequencyCheckBox.UseVisualStyleBackColor = true;
            // 
            // _impedanceRealNumBox
            // 
            this._impedanceRealNumBox.Location = new System.Drawing.Point(256, 16);
            this._impedanceRealNumBox.Name = "_impedanceRealNumBox";
            this._impedanceRealNumBox.Size = new System.Drawing.Size(50, 21);
            this._impedanceRealNumBox.TabIndex = 10;
            // 
            // _impedanceCheckBox
            // 
            this._impedanceCheckBox.AutoSize = true;
            this._impedanceCheckBox.Location = new System.Drawing.Point(129, 20);
            this._impedanceCheckBox.Name = "_impedanceCheckBox";
            this._impedanceCheckBox.Size = new System.Drawing.Size(121, 19);
            this._impedanceCheckBox.TabIndex = 9;
            this._impedanceCheckBox.Text = "Сопротивление:";
            this._impedanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // _impedanceImgNumBox
            // 
            this._impedanceImgNumBox.Location = new System.Drawing.Point(323, 16);
            this._impedanceImgNumBox.Name = "_impedanceImgNumBox";
            this._impedanceImgNumBox.Size = new System.Drawing.Size(50, 21);
            this._impedanceImgNumBox.TabIndex = 8;
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._saveToolStripMenuItem,
            this._loadToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this._fileToolStripMenuItem.Text = "Файл";
            // 
            // _saveToolStripMenuItem
            // 
            this._saveToolStripMenuItem.Name = "_saveToolStripMenuItem";
            this._saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this._saveToolStripMenuItem.Text = "Сохранить";
            // 
            // _loadToolStripMenuItem
            // 
            this._loadToolStripMenuItem.Name = "_loadToolStripMenuItem";
            this._loadToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this._loadToolStripMenuItem.Text = "Загрузить";
            // 
            // _fileMenuStrip
            // 
            this._fileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem});
            this._fileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._fileMenuStrip.Name = "_fileMenuStrip";
            this._fileMenuStrip.Size = new System.Drawing.Size(584, 24);
            this._fileMenuStrip.TabIndex = 2;
            this._fileMenuStrip.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 571);
            this.Controls.Add(this._filterGroupBox);
            this.Controls.Add(this._editElementsListGroupBox);
            this.Controls.Add(this._calculateImpedanceGroupBox);
            this.Controls.Add(this._fileMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this._fileMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Расчет комплексного сопротивления";
            this.Load += new System.EventHandler(this.LoadMainForm);
            this._calculateImpedanceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._calculateImpedanceDataGridView)).EndInit();
            this._editElementsListGroupBox.ResumeLayout(false);
            this._filterGroupBox.ResumeLayout(false);
            this._filterGroupBox.PerformLayout();
            this._fileMenuStrip.ResumeLayout(false);
            this._fileMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private GroupBox _calculateImpedanceGroupBox;
        private DataGridView _calculateImpedanceDataGridView;
        private GroupBox _editElementsListGroupBox;
        private Button _addElementButton;
        private Button _deleteElementButton;
        private Button _clearFilterButton;
        private Button _setFilterButton;
#if DEBUG
        private Button _randomButton;
#endif
        private CheckBox _capacitorCheckBox;
        private CheckBox _inductorCheckBox;
        private CheckBox _resistorCheckBox;
        private GroupBox _filterGroupBox;
        private NegativeNumBox _impedanceImgNumBox;
        private CheckBox _impedanceCheckBox;
        private NumBox _impedanceRealNumBox;
        private CheckBox _frequencyCheckBox;
        private NumBox _frequencyNumBox;
        private Label _jLabel;
        private Label _ohmLabel;
        private Label _hzLabel;
        private ToolStripMenuItem _fileToolStripMenuItem;
        private ToolStripMenuItem _saveToolStripMenuItem;
        private ToolStripMenuItem _loadToolStripMenuItem;
        private MenuStrip _fileMenuStrip;
    }
}

