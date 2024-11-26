namespace View
{
    partial class AddElementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._typesGroupBox = new System.Windows.Forms.GroupBox();
            this._capacitorRadioButton = new System.Windows.Forms.RadioButton();
            this._inductorRadioButton = new System.Windows.Forms.RadioButton();
            this.resistorRadioButton = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._parametersGroupBox = new System.Windows.Forms.GroupBox();
            this._addCapacitorUserControl = new View.AddCapacitorUserControl();
            this._addInductorUserControl = new View.AddInductorUserControl();
            this._addResistorUserControl = new View.AddResistorUserControl();
            this._btnGroupBox3 = new System.Windows.Forms.GroupBox();
            this._closeButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this._typesGroupBox.SuspendLayout();
            this._parametersGroupBox.SuspendLayout();
            this._btnGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _typesGroupBox
            // 
            this._typesGroupBox.Controls.Add(this._capacitorRadioButton);
            this._typesGroupBox.Controls.Add(this._inductorRadioButton);
            this._typesGroupBox.Controls.Add(this.resistorRadioButton);
            this._typesGroupBox.Location = new System.Drawing.Point(12, 15);
            this._typesGroupBox.Name = "_typesGroupBox";
            this._typesGroupBox.Size = new System.Drawing.Size(253, 105);
            this._typesGroupBox.TabIndex = 0;
            this._typesGroupBox.TabStop = false;
            this._typesGroupBox.Text = "Тип элемента";
            // 
            // _capacitorRadioButton
            // 
            this._capacitorRadioButton.AutoSize = true;
            this._capacitorRadioButton.Location = new System.Drawing.Point(22, 76);
            this._capacitorRadioButton.Name = "_capacitorRadioButton";
            this._capacitorRadioButton.Size = new System.Drawing.Size(91, 17);
            this._capacitorRadioButton.TabIndex = 2;
            this._capacitorRadioButton.TabStop = true;
            this._capacitorRadioButton.Text = "Конденсатор";
            this._capacitorRadioButton.UseVisualStyleBackColor = true;
            // 
            // _inductorRadioButton
            // 
            this._inductorRadioButton.AutoSize = true;
            this._inductorRadioButton.Location = new System.Drawing.Point(22, 53);
            this._inductorRadioButton.Name = "_inductorRadioButton";
            this._inductorRadioButton.Size = new System.Drawing.Size(146, 17);
            this._inductorRadioButton.TabIndex = 1;
            this._inductorRadioButton.TabStop = true;
            this._inductorRadioButton.Text = "Катушка индуктивности";
            this._inductorRadioButton.UseVisualStyleBackColor = true;
            // 
            // resistorRadioButton
            // 
            this.resistorRadioButton.AutoSize = true;
            this.resistorRadioButton.Location = new System.Drawing.Point(22, 30);
            this.resistorRadioButton.Name = "resistorRadioButton";
            this.resistorRadioButton.Size = new System.Drawing.Size(73, 17);
            this.resistorRadioButton.TabIndex = 0;
            this.resistorRadioButton.TabStop = true;
            this.resistorRadioButton.Text = "Резистор";
            this.resistorRadioButton.UseVisualStyleBackColor = true;
            // 
            // _parametersGroupBox
            // 
            this._parametersGroupBox.Controls.Add(this._addCapacitorUserControl);
            this._parametersGroupBox.Controls.Add(this._addInductorUserControl);
            this._parametersGroupBox.Controls.Add(this._addResistorUserControl);
            this._parametersGroupBox.Location = new System.Drawing.Point(12, 126);
            this._parametersGroupBox.Name = "_parametersGroupBox";
            this._parametersGroupBox.Size = new System.Drawing.Size(253, 104);
            this._parametersGroupBox.TabIndex = 1;
            this._parametersGroupBox.TabStop = false;
            this._parametersGroupBox.Text = "Параметры элемента";
            // 
            // _addCapacitorUserControl
            // 
            this._addCapacitorUserControl.Location = new System.Drawing.Point(8, 19);
            this._addCapacitorUserControl.Name = "_addCapacitorUserControl";
            this._addCapacitorUserControl.Size = new System.Drawing.Size(225, 80);
            this._addCapacitorUserControl.TabIndex = 2;
            // 
            // _addInductorUserControl
            // 
            this._addInductorUserControl.Location = new System.Drawing.Point(8, 18);
            this._addInductorUserControl.Name = "_addInductorUserControl";
            this._addInductorUserControl.Size = new System.Drawing.Size(225, 80);
            this._addInductorUserControl.TabIndex = 1;
            // 
            // _addResistorUserControl
            // 
            this._addResistorUserControl.Location = new System.Drawing.Point(8, 28);
            this._addResistorUserControl.Name = "_addResistorUserControl";
            this._addResistorUserControl.Size = new System.Drawing.Size(225, 50);
            this._addResistorUserControl.TabIndex = 0;
            // 
            // _btnGroupBox3
            // 
            this._btnGroupBox3.Controls.Add(this._closeButton);
            this._btnGroupBox3.Controls.Add(this._addButton);
            this._btnGroupBox3.Location = new System.Drawing.Point(12, 236);
            this._btnGroupBox3.Name = "_btnGroupBox3";
            this._btnGroupBox3.Size = new System.Drawing.Size(253, 57);
            this._btnGroupBox3.TabIndex = 2;
            this._btnGroupBox3.TabStop = false;
            // 
            // _closeButton
            // 
            this._closeButton.Location = new System.Drawing.Point(22, 19);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(75, 23);
            this._closeButton.TabIndex = 1;
            this._closeButton.Text = "Закрыть";
            this._closeButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(158, 19);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 23);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "Рассчитать";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // AddElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 297);
            this.Controls.Add(this._btnGroupBox3);
            this.Controls.Add(this._parametersGroupBox);
            this.Controls.Add(this._typesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddElementForm";
            this.Text = "AddElementForm";
            this._typesGroupBox.ResumeLayout(false);
            this._typesGroupBox.PerformLayout();
            this._parametersGroupBox.ResumeLayout(false);
            this._btnGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _typesGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox _parametersGroupBox;
        private System.Windows.Forms.RadioButton _capacitorRadioButton;
        private System.Windows.Forms.RadioButton _inductorRadioButton;
        private System.Windows.Forms.RadioButton resistorRadioButton;
        private System.Windows.Forms.GroupBox _btnGroupBox3;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _closeButton;
        private AddCapacitorUserControl _addCapacitorUserControl;
        private AddInductorUserControl _addInductorUserControl;
        private AddResistorUserControl _addResistorUserControl;
    }
}