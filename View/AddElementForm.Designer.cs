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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.capacitorRadioButton = new System.Windows.Forms.RadioButton();
            this.inductorRadioButton = new System.Windows.Forms.RadioButton();
            this.resistorRadioButton = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addResistorUserControl = new View.AddResistorUserControl();
            this.addInductorUserControl = new View.AddInductorUserControl();
            this.addCapacitorUserControl = new View.AddCapacitorUserControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.capacitorRadioButton);
            this.groupBox1.Controls.Add(this.inductorRadioButton);
            this.groupBox1.Controls.Add(this.resistorRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // capacitorRadioButton
            // 
            this.capacitorRadioButton.AutoSize = true;
            this.capacitorRadioButton.Location = new System.Drawing.Point(22, 110);
            this.capacitorRadioButton.Name = "capacitorRadioButton";
            this.capacitorRadioButton.Size = new System.Drawing.Size(91, 17);
            this.capacitorRadioButton.TabIndex = 2;
            this.capacitorRadioButton.TabStop = true;
            this.capacitorRadioButton.Text = "Конденсатор";
            this.capacitorRadioButton.UseVisualStyleBackColor = true;
            // 
            // inductorRadioButton
            // 
            this.inductorRadioButton.AutoSize = true;
            this.inductorRadioButton.Location = new System.Drawing.Point(22, 70);
            this.inductorRadioButton.Name = "inductorRadioButton";
            this.inductorRadioButton.Size = new System.Drawing.Size(146, 17);
            this.inductorRadioButton.TabIndex = 1;
            this.inductorRadioButton.TabStop = true;
            this.inductorRadioButton.Text = "Катушка индуктивности";
            this.inductorRadioButton.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addResistorUserControl);
            this.groupBox2.Controls.Add(this.addInductorUserControl);
            this.groupBox2.Controls.Add(this.addCapacitorUserControl);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // addResistorUserControl
            // 
            this.addResistorUserControl.Location = new System.Drawing.Point(-1, 19);
            this.addResistorUserControl.Name = "addResistorUserControl";
            this.addResistorUserControl.Size = new System.Drawing.Size(360, 50);
            this.addResistorUserControl.TabIndex = 2;
            // 
            // addInductorUserControl
            // 
            this.addInductorUserControl.Location = new System.Drawing.Point(0, 30);
            this.addInductorUserControl.Name = "addInductorUserControl";
            this.addInductorUserControl.Size = new System.Drawing.Size(360, 50);
            this.addInductorUserControl.TabIndex = 1;
            // 
            // addCapacitorUserControl
            // 
            this.addCapacitorUserControl.Location = new System.Drawing.Point(0, 30);
            this.addCapacitorUserControl.Name = "addCapacitorUserControl";
            this.addCapacitorUserControl.Size = new System.Drawing.Size(360, 50);
            this.addCapacitorUserControl.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.closeButton);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Location = new System.Drawing.Point(11, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(23, 40);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Рассчитать";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(131, 39);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // AddElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddElementForm";
            this.Text = "AddElementForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton capacitorRadioButton;
        private System.Windows.Forms.RadioButton inductorRadioButton;
        private System.Windows.Forms.RadioButton resistorRadioButton;
        private AddCapacitorUserControl addCapacitorUserControl;
        private AddResistorUserControl addResistorUserControl;
        private AddInductorUserControl addInductorUserControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
    }
}