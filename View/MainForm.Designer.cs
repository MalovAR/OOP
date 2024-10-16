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
            this.calculateImpedanceGruopBox = new System.Windows.Forms.GroupBox();
            this.calculateImpedanceDataGridView = new System.Windows.Forms.DataGridView();
            this.editElementsListGroupBox = new System.Windows.Forms.GroupBox();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.setFilterButton = new System.Windows.Forms.Button();
            this.deleteElementButton = new System.Windows.Forms.Button();
            this._addElementButton = new System.Windows.Forms.Button();
            this.calculateImpedanceGruopBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculateImpedanceDataGridView)).BeginInit();
            this.editElementsListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateImpedanceGruopBox
            // 
            this.calculateImpedanceGruopBox.AutoSize = true;
            this.calculateImpedanceGruopBox.Controls.Add(this.calculateImpedanceDataGridView);
            this.calculateImpedanceGruopBox.Location = new System.Drawing.Point(0, 38);
            this.calculateImpedanceGruopBox.Name = "calculateImpedanceGruopBox";
            this.calculateImpedanceGruopBox.Size = new System.Drawing.Size(584, 347);
            this.calculateImpedanceGruopBox.TabIndex = 0;
            this.calculateImpedanceGruopBox.TabStop = false;
            this.calculateImpedanceGruopBox.Text = "Расчет комплексного сопротивления";
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
            this.editElementsListGroupBox.Controls.Add(this.clearFilterButton);
            this.editElementsListGroupBox.Controls.Add(this.setFilterButton);
            this.editElementsListGroupBox.Controls.Add(this.deleteElementButton);
            this.editElementsListGroupBox.Controls.Add(this._addElementButton);
            this.editElementsListGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editElementsListGroupBox.Location = new System.Drawing.Point(0, 391);
            this.editElementsListGroupBox.Name = "editElementsListGroupBox";
            this.editElementsListGroupBox.Size = new System.Drawing.Size(584, 70);
            this.editElementsListGroupBox.TabIndex = 1;
            this.editElementsListGroupBox.TabStop = false;
            this.editElementsListGroupBox.Text = "Редактирование списка";
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Location = new System.Drawing.Point(384, 20);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(120, 40);
            this.clearFilterButton.TabIndex = 3;
            this.clearFilterButton.Text = "Сбросить фильтр";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            // 
            // setFilterButton
            // 
            this.setFilterButton.Location = new System.Drawing.Point(258, 20);
            this.setFilterButton.Name = "setFilterButton";
            this.setFilterButton.Size = new System.Drawing.Size(120, 40);
            this.setFilterButton.TabIndex = 2;
            this.setFilterButton.Text = "Настроить фильтр";
            this.setFilterButton.UseVisualStyleBackColor = true;
            // 
            // deleteElementButton
            // 
            this.deleteElementButton.Location = new System.Drawing.Point(132, 20);
            this.deleteElementButton.Name = "deleteElementButton";
            this.deleteElementButton.Size = new System.Drawing.Size(120, 40);
            this.deleteElementButton.TabIndex = 1;
            this.deleteElementButton.Text = "Удалить элемент";
            this.deleteElementButton.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.editElementsListGroupBox);
            this.Controls.Add(this.calculateImpedanceGruopBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Расчет комплексного сопротивления";
            this.calculateImpedanceGruopBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculateImpedanceDataGridView)).EndInit();
            this.editElementsListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private GroupBox calculateImpedanceGruopBox;
        private DataGridView calculateImpedanceDataGridView;
        private GroupBox editElementsListGroupBox;
        private Button _addElementButton;
        private Button deleteElementButton;
        private Button clearFilterButton;
        private Button setFilterButton;
    }
}

