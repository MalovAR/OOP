namespace View
{
    partial class AddResistorUserControl
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
            this.resistanceNumBox = new NumBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.resistanceNumBox.Location = new System.Drawing.Point(240, 15);
            this.resistanceNumBox.Name = "textBox1";
            this.resistanceNumBox.Size = new System.Drawing.Size(100, 20);
            this.resistanceNumBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сопротивление";
            // 
            // AddResistorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resistanceNumBox);
            this.Name = "AddResistorUserControl";
            this.Size = new System.Drawing.Size(360, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal NumBox resistanceNumBox;
        private System.Windows.Forms.Label label1;
    }
}
