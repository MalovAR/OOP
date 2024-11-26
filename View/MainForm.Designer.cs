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
            this.calculateImpedanceGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateImpedanceDataGridView = new System.Windows.Forms.DataGridView();
            this._setFilterButton = new System.Windows.Forms.Button();
            this._clearFilterButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.editElementsListGroupBox = new System.Windows.Forms.GroupBox();
            this._deleteElementButton = new System.Windows.Forms.Button();
            this._addElementButton = new System.Windows.Forms.Button();
            this.CapacitorCheckBox = new System.Windows.Forms.CheckBox();
            this.InductorCheckBox = new System.Windows.Forms.CheckBox();
            this.ResistorCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.frequencyCheckBox = new System.Windows.Forms.CheckBox();
            this.ImpedanceCheckBox = new System.Windows.Forms.CheckBox();
            this.frequencyNumBox = new View.NumBox();
            this.impedanceRealNumBox = new View.NumBox();
            this.impedanceImgNumBox = new View.NumBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateImpedanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculateImpedanceDataGridView)).BeginInit();
            this.editElementsListGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateImpedanceGroupBox
            // 
            this.calculateImpedanceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateImpedanceGroupBox.AutoSize = true;
            this.calculateImpedanceGroupBox.Controls.Add(this.calculateImpedanceDataGridView);
            this.calculateImpedanceGroupBox.Location = new System.Drawing.Point(0, 27);
            this.calculateImpedanceGroupBox.Name = "calculateImpedanceGroupBox";
            this.calculateImpedanceGroupBox.Size = new System.Drawing.Size(584, 370);
            this.calculateImpedanceGroupBox.TabIndex = 0;
            this.calculateImpedanceGroupBox.TabStop = false;
            this.calculateImpedanceGroupBox.Text = "Отображение списка элементов";
            // 
            // calculateImpedanceDataGridView
            // 
            this.calculateImpedanceDataGridView.AllowUserToAddRows = false;
            this.calculateImpedanceDataGridView.AllowUserToDeleteRows = false;
            this.calculateImpedanceDataGridView.AllowUserToOrderColumns = true;
            this.calculateImpedanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculateImpedanceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateImpedanceDataGridView.Location = new System.Drawing.Point(3, 17);
            this.calculateImpedanceDataGridView.Name = "calculateImpedanceDataGridView";
            this.calculateImpedanceDataGridView.ReadOnly = true;
            this.calculateImpedanceDataGridView.Size = new System.Drawing.Size(578, 350);
            this.calculateImpedanceDataGridView.TabIndex = 0;
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
            // randomButton
            // 
            this.randomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.randomButton.Location = new System.Drawing.Point(444, 20);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(134, 40);
            this.randomButton.TabIndex = 3;
            this.randomButton.Text = "Добавить случайный элемент";
            this.randomButton.UseVisualStyleBackColor = true;
            // 
            // editElementsListGroupBox
            // 
            this.editElementsListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editElementsListGroupBox.Controls.Add(this.randomButton);
            this.editElementsListGroupBox.Controls.Add(this._deleteElementButton);
            this.editElementsListGroupBox.Controls.Add(this._addElementButton);
            this.editElementsListGroupBox.Location = new System.Drawing.Point(0, 501);
            this.editElementsListGroupBox.Name = "editElementsListGroupBox";
            this.editElementsListGroupBox.Size = new System.Drawing.Size(584, 70);
            this.editElementsListGroupBox.TabIndex = 1;
            this.editElementsListGroupBox.TabStop = false;
            this.editElementsListGroupBox.Text = "Редактирование списка";
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
            // CapacitorCheckBox
            // 
            this.CapacitorCheckBox.AutoSize = true;
            this.CapacitorCheckBox.Location = new System.Drawing.Point(6, 70);
            this.CapacitorCheckBox.Name = "CapacitorCheckBox";
            this.CapacitorCheckBox.Size = new System.Drawing.Size(103, 19);
            this.CapacitorCheckBox.TabIndex = 7;
            this.CapacitorCheckBox.Text = "Конденсатор";
            this.CapacitorCheckBox.UseVisualStyleBackColor = true;
            // 
            // InductorCheckBox
            // 
            this.InductorCheckBox.AutoSize = true;
            this.InductorCheckBox.Location = new System.Drawing.Point(6, 37);
            this.InductorCheckBox.Name = "InductorCheckBox";
            this.InductorCheckBox.Size = new System.Drawing.Size(113, 34);
            this.InductorCheckBox.TabIndex = 6;
            this.InductorCheckBox.Text = "Катушка \r\nиндуктивности";
            this.InductorCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResistorCheckBox
            // 
            this.ResistorCheckBox.AutoSize = true;
            this.ResistorCheckBox.Location = new System.Drawing.Point(6, 20);
            this.ResistorCheckBox.Name = "ResistorCheckBox";
            this.ResistorCheckBox.Size = new System.Drawing.Size(81, 19);
            this.ResistorCheckBox.TabIndex = 5;
            this.ResistorCheckBox.Text = "Резистор";
            this.ResistorCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.frequencyNumBox);
            this.groupBox1.Controls.Add(this.frequencyCheckBox);
            this.groupBox1.Controls.Add(this.impedanceRealNumBox);
            this.groupBox1.Controls.Add(this.ImpedanceCheckBox);
            this.groupBox1.Controls.Add(this.impedanceImgNumBox);
            this.groupBox1.Controls.Add(this.InductorCheckBox);
            this.groupBox1.Controls.Add(this.CapacitorCheckBox);
            this.groupBox1.Controls.Add(this.ResistorCheckBox);
            this.groupBox1.Controls.Add(this._clearFilterButton);
            this.groupBox1.Controls.Add(this._setFilterButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Найтройка фильтрации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "j";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ом";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Гц";
            // 
            // frequencyCheckBox
            // 
            this.frequencyCheckBox.AutoSize = true;
            this.frequencyCheckBox.Location = new System.Drawing.Point(129, 45);
            this.frequencyCheckBox.Name = "frequencyCheckBox";
            this.frequencyCheckBox.Size = new System.Drawing.Size(78, 19);
            this.frequencyCheckBox.TabIndex = 11;
            this.frequencyCheckBox.Text = "Частота:";
            this.frequencyCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImpedanceCheckBox
            // 
            this.ImpedanceCheckBox.AutoSize = true;
            this.ImpedanceCheckBox.Location = new System.Drawing.Point(129, 20);
            this.ImpedanceCheckBox.Name = "ImpedanceCheckBox";
            this.ImpedanceCheckBox.Size = new System.Drawing.Size(121, 19);
            this.ImpedanceCheckBox.TabIndex = 9;
            this.ImpedanceCheckBox.Text = "Сопротивление:";
            this.ImpedanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // frequencyNumBox
            // 
            this.frequencyNumBox.Location = new System.Drawing.Point(256, 43);
            this.frequencyNumBox.Name = "frequencyNumBox";
            this.frequencyNumBox.Size = new System.Drawing.Size(50, 21);
            this.frequencyNumBox.TabIndex = 13;
            // 
            // impedanceRealNumBox
            // 
            this.impedanceRealNumBox.Location = new System.Drawing.Point(256, 16);
            this.impedanceRealNumBox.Name = "impedanceRealNumBox";
            this.impedanceRealNumBox.Size = new System.Drawing.Size(50, 21);
            this.impedanceRealNumBox.TabIndex = 10;
            // 
            // impedanceImgNumBox
            // 
            this.impedanceImgNumBox.Location = new System.Drawing.Point(323, 16);
            this.impedanceImgNumBox.Name = "impedanceImgNumBox";
            this.impedanceImgNumBox.Size = new System.Drawing.Size(50, 21);
            this.impedanceImgNumBox.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editElementsListGroupBox);
            this.Controls.Add(this.calculateImpedanceGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Расчет комплексного сопротивления";
            this.Load += new System.EventHandler(this.LoadMainForm);
            this.calculateImpedanceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculateImpedanceDataGridView)).EndInit();
            this.editElementsListGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
#if DEBUG
        private Button randomButton;
        private CheckBox CapacitorCheckBox;
        private CheckBox InductorCheckBox;
        private CheckBox ResistorCheckBox;
        private GroupBox groupBox1;
        private NumBox impedanceImgNumBox;
        private CheckBox ImpedanceCheckBox;
        private NumBox impedanceRealNumBox;
        private CheckBox frequencyCheckBox;
        private NumBox frequencyNumBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
#endif
    }
}

