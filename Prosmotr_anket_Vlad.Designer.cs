namespace Agenstvo
{
    partial class Prosmotr_anket_Vlad
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
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_D = new System.Windows.Forms.TextBox();
            this.Deleted = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("mr_CoasterG", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(677, 83);
            this.label8.TabIndex = 44;
            this.label8.Text = "Просмотр Своих анкет";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("mr_CoasterG", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(749, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 42);
            this.label16.TabIndex = 73;
            this.label16.Text = "X";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 331);
            this.dataGridView1.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mr_CoasterG", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 42);
            this.label1.TabIndex = 75;
            this.label1.Text = "ID Анкеты";
            // 
            // ID_D
            // 
            this.ID_D.Font = new System.Drawing.Font("mr_CoasterG", 20F);
            this.ID_D.Location = new System.Drawing.Point(228, 95);
            this.ID_D.Name = "ID_D";
            this.ID_D.Size = new System.Drawing.Size(54, 42);
            this.ID_D.TabIndex = 76;
            // 
            // Deleted
            // 
            this.Deleted.AutoSize = true;
            this.Deleted.Font = new System.Drawing.Font("mr_CoasterG", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deleted.Location = new System.Drawing.Point(288, 95);
            this.Deleted.Name = "Deleted";
            this.Deleted.Size = new System.Drawing.Size(137, 42);
            this.Deleted.TabIndex = 77;
            this.Deleted.Text = "Удалить";
            this.Deleted.Click += new System.EventHandler(this.Deleted_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mr_CoasterG", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 42);
            this.label2.TabIndex = 79;
            this.label2.Text = "Создать";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("mr_CoasterG", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(300, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 42);
            this.label13.TabIndex = 49;
            this.label13.Text = "Выйти";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Prosmotr_anket_Vlad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Deleted);
            this.Controls.Add(this.ID_D);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prosmotr_anket_Vlad";
            this.Text = "Prosmotr_anket";
            this.Load += new System.EventHandler(this.Prosmotr_anket_Vlad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_D;
        private System.Windows.Forms.Label Deleted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
    }
}