namespace Agenstvo
{
    partial class Vxod
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
            this.label1 = new System.Windows.Forms.Label();
            this.EP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Vlad = new System.Windows.Forms.RadioButton();
            this.Pok = new System.Windows.Forms.RadioButton();
            this.adm = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mr_CoasterG", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход";
            // 
            // EP
            // 
            this.EP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EP.Location = new System.Drawing.Point(248, 153);
            this.EP.Name = "EP";
            this.EP.Size = new System.Drawing.Size(511, 44);
            this.EP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mr_CoasterG", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Эл. Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mr_CoasterG", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // Pas
            // 
            this.Pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pas.Location = new System.Drawing.Point(248, 207);
            this.Pas.Name = "Pas";
            this.Pas.Size = new System.Drawing.Size(511, 44);
            this.Pas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mr_CoasterG", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Войти";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("mr_CoasterG", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Регистрация";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("mr_CoasterG", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(749, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 42);
            this.label6.TabIndex = 8;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Vlad
            // 
            this.Vlad.AutoSize = true;
            this.Vlad.Font = new System.Drawing.Font("mr_CoasterG", 18F);
            this.Vlad.Location = new System.Drawing.Point(248, 253);
            this.Vlad.Name = "Vlad";
            this.Vlad.Size = new System.Drawing.Size(126, 35);
            this.Vlad.TabIndex = 9;
            this.Vlad.TabStop = true;
            this.Vlad.Text = "Владелец";
            this.Vlad.UseVisualStyleBackColor = true;
            // 
            // Pok
            // 
            this.Pok.AutoSize = true;
            this.Pok.Font = new System.Drawing.Font("mr_CoasterG", 18F);
            this.Pok.Location = new System.Drawing.Point(380, 253);
            this.Pok.Name = "Pok";
            this.Pok.Size = new System.Drawing.Size(156, 35);
            this.Pok.TabIndex = 10;
            this.Pok.TabStop = true;
            this.Pok.Text = "Покупатель";
            this.Pok.UseVisualStyleBackColor = true;
            // 
            // adm
            // 
            this.adm.AutoSize = true;
            this.adm.Font = new System.Drawing.Font("mr_CoasterG", 18F);
            this.adm.Location = new System.Drawing.Point(542, 253);
            this.adm.Name = "adm";
            this.adm.Size = new System.Drawing.Size(217, 35);
            this.adm.TabIndex = 11;
            this.adm.TabStop = true;
            this.adm.Text = "Админимстратор";
            this.adm.UseVisualStyleBackColor = true;
            // 
            // Vxod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.adm);
            this.Controls.Add(this.Pok);
            this.Controls.Add(this.Vlad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vxod";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Vlad;
        private System.Windows.Forms.RadioButton Pok;
        private System.Windows.Forms.RadioButton adm;
    }
}