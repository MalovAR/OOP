namespace View
{
    partial class AddInductorUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inductanceNumBox = new View.NumBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frequencyNumBox = new View.NumBox();
            this.frequency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inductanceNumBox
            // 
            this.inductanceNumBox.Location = new System.Drawing.Point(240, 15);
            this.inductanceNumBox.Name = "inductanceNumBox";
            this.inductanceNumBox.Size = new System.Drawing.Size(100, 20);
            this.inductanceNumBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Индуктивность";
            // 
            // frequencyNumBox
            // 
            this.frequencyNumBox.Location = new System.Drawing.Point(240, 41);
            this.frequencyNumBox.Name = "frequencyNumBox";
            this.frequencyNumBox.Size = new System.Drawing.Size(100, 20);
            this.frequencyNumBox.TabIndex = 3;
            // 
            // frequency
            // 
            this.frequency.AutoSize = true;
            this.frequency.Location = new System.Drawing.Point(25, 44);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(49, 13);
            this.frequency.TabIndex = 4;
            this.frequency.Text = "Частота";
            // 
            // AddInductorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.frequencyNumBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inductanceNumBox);
            this.Name = "AddInductorUserControl";
            this.Size = new System.Drawing.Size(360, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal NumBox inductanceNumBox;
        private System.Windows.Forms.Label label1;
        internal NumBox frequencyNumBox;
        private System.Windows.Forms.Label frequency;
    }
}
