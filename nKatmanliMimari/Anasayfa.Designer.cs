namespace nKatmanliMimari
{
    partial class Anasayfa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_Mission = new System.Windows.Forms.TextBox();
            this.lbl_Mission = new System.Windows.Forms.Label();
            this.txt_Wage = new System.Windows.Forms.TextBox();
            this.lbl_Wage = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 326);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(40, 45);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(32, 22);
            this.lbl_Id.TabIndex = 30;
            this.lbl_Id.Text = "ID:";
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(133, 39);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(123, 28);
            this.txt_Id.TabIndex = 0;
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(312, 40);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(85, 37);
            this.btn_Listele.TabIndex = 6;
            this.btn_Listele.Text = "List";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(133, 73);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(123, 28);
            this.txt_Name.TabIndex = 1;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(40, 79);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(62, 22);
            this.lbl_Name.TabIndex = 31;
            this.lbl_Name.Text = "Name:";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(133, 107);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(123, 28);
            this.txt_Surname.TabIndex = 2;
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(40, 113);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(87, 22);
            this.lbl_Surname.TabIndex = 32;
            this.lbl_Surname.Text = "Surname:";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(133, 141);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(123, 28);
            this.txt_City.TabIndex = 3;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(40, 147);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(46, 22);
            this.lbl_City.TabIndex = 33;
            this.lbl_City.Text = "City:";
            // 
            // txt_Mission
            // 
            this.txt_Mission.Location = new System.Drawing.Point(133, 175);
            this.txt_Mission.Name = "txt_Mission";
            this.txt_Mission.Size = new System.Drawing.Size(123, 28);
            this.txt_Mission.TabIndex = 4;
            // 
            // lbl_Mission
            // 
            this.lbl_Mission.AutoSize = true;
            this.lbl_Mission.Location = new System.Drawing.Point(40, 181);
            this.lbl_Mission.Name = "lbl_Mission";
            this.lbl_Mission.Size = new System.Drawing.Size(75, 22);
            this.lbl_Mission.TabIndex = 34;
            this.lbl_Mission.Text = "Mission:";
            // 
            // txt_Wage
            // 
            this.txt_Wage.Location = new System.Drawing.Point(133, 209);
            this.txt_Wage.Name = "txt_Wage";
            this.txt_Wage.Size = new System.Drawing.Size(123, 28);
            this.txt_Wage.TabIndex = 5;
            // 
            // lbl_Wage
            // 
            this.lbl_Wage.AutoSize = true;
            this.lbl_Wage.Location = new System.Drawing.Point(40, 215);
            this.lbl_Wage.Name = "lbl_Wage";
            this.lbl_Wage.Size = new System.Drawing.Size(62, 22);
            this.lbl_Wage.TabIndex = 35;
            this.lbl_Wage.Text = "Wage:";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(312, 83);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(85, 36);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "Add";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(312, 167);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(85, 36);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Delete";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(312, 125);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(85, 36);
            this.btn_Guncelle.TabIndex = 37;
            this.btn_Guncelle.Text = "Update";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(554, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 198);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Location = new System.Drawing.Point(312, 209);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(85, 38);
            this.btn_Cikis.TabIndex = 9;
            this.btn_Cikis.Text = "Exit";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_Wage);
            this.Controls.Add(this.lbl_Wage);
            this.Controls.Add(this.txt_Mission);
            this.Controls.Add(this.lbl_Mission);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nKatmanliMimari";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_Mission;
        private System.Windows.Forms.Label lbl_Mission;
        private System.Windows.Forms.TextBox txt_Wage;
        private System.Windows.Forms.Label lbl_Wage;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cikis;
    }
}

