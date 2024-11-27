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
            this._inductanceNumBox = new View.NumBox();
            this.label1 = new System.Windows.Forms.Label();
            this._frequencyNumBox = new View.NumBox();
            this.frequency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _inductanceNumBox
            // 
            this._inductanceNumBox.Location = new System.Drawing.Point(115, 15);
            this._inductanceNumBox.Name = "_inductanceNumBox";
            this._inductanceNumBox.Size = new System.Drawing.Size(100, 20);
            this._inductanceNumBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Индуктивность";
            // 
            // _frequencyNumBox
            // 
            this._frequencyNumBox.Location = new System.Drawing.Point(115, 41);
            this._frequencyNumBox.Name = "_frequencyNumBox";
            this._frequencyNumBox.Size = new System.Drawing.Size(100, 20);
            this._frequencyNumBox.TabIndex = 3;
            // 
            // frequency
            // 
            this.frequency.AutoSize = true;
            this.frequency.Location = new System.Drawing.Point(25, 43);
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
            this.Controls.Add(this._frequencyNumBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._inductanceNumBox);
            this.Name = "AddInductorUserControl";
            this.Size = new System.Drawing.Size(225, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal NumBox _inductanceNumBox;
        private System.Windows.Forms.Label label1;
        internal NumBox _frequencyNumBox;
        private System.Windows.Forms.Label frequency;
    }
}
