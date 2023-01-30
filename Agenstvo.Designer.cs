namespace Agenstvo
{
    partial class Agenstvo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mr_CoasterG", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в\r\nАгенство по недвижимости";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Для продолжения кликните на эту надпись";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("mr_CoasterG", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(458, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 42);
            this.label16.TabIndex = 73;
            this.label16.Text = "X";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // Agenstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 287);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agenstvo";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Agenstvo_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
    }
}

