namespace AdoNetDataTable
{
    partial class Form1
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
            this.guncelle = new System.Windows.Forms.Button();
            this.soyisimTxt = new System.Windows.Forms.TextBox();
            this.isimGunTxt = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.unvanEkleTxt = new System.Windows.Forms.TextBox();
            this.isimEkleTxt = new System.Windows.Forms.TextBox();
            this.soyisimEkleTxt = new System.Windows.Forms.TextBox();
            this.idEkleTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sil = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.filtrele = new System.Windows.Forms.Button();
            this.araTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guncelle);
            this.groupBox1.Controls.Add(this.soyisimTxt);
            this.groupBox1.Controls.Add(this.isimGunTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 148);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelleme İşlemleri";
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(220, 43);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(97, 58);
            this.guncelle.TabIndex = 5;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // soyisimTxt
            // 
            this.soyisimTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisimTxt.Location = new System.Drawing.Point(25, 75);
            this.soyisimTxt.Name = "soyisimTxt";
            this.soyisimTxt.Size = new System.Drawing.Size(189, 26);
            this.soyisimTxt.TabIndex = 4;
            // 
            // isimGunTxt
            // 
            this.isimGunTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimGunTxt.Location = new System.Drawing.Point(25, 43);
            this.isimGunTxt.Name = "isimGunTxt";
            this.isimGunTxt.Size = new System.Drawing.Size(189, 26);
            this.isimGunTxt.TabIndex = 3;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(211, 32);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(97, 122);
            this.ekle.TabIndex = 14;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.unvanEkleTxt);
            this.groupBox2.Controls.Add(this.isimEkleTxt);
            this.groupBox2.Controls.Add(this.soyisimEkleTxt);
            this.groupBox2.Controls.Add(this.idEkleTxt);
            this.groupBox2.Controls.Add(this.ekle);
            this.groupBox2.Location = new System.Drawing.Point(370, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 163);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekleme İşlemleri";
            // 
            // unvanEkleTxt
            // 
            this.unvanEkleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unvanEkleTxt.Location = new System.Drawing.Point(16, 128);
            this.unvanEkleTxt.Name = "unvanEkleTxt";
            this.unvanEkleTxt.Size = new System.Drawing.Size(189, 26);
            this.unvanEkleTxt.TabIndex = 18;
            // 
            // isimEkleTxt
            // 
            this.isimEkleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimEkleTxt.Location = new System.Drawing.Point(16, 64);
            this.isimEkleTxt.Name = "isimEkleTxt";
            this.isimEkleTxt.Size = new System.Drawing.Size(189, 26);
            this.isimEkleTxt.TabIndex = 16;
            // 
            // soyisimEkleTxt
            // 
            this.soyisimEkleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisimEkleTxt.Location = new System.Drawing.Point(16, 96);
            this.soyisimEkleTxt.Name = "soyisimEkleTxt";
            this.soyisimEkleTxt.Size = new System.Drawing.Size(189, 26);
            this.soyisimEkleTxt.TabIndex = 17;
            // 
            // idEkleTxt
            // 
            this.idEkleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idEkleTxt.Location = new System.Drawing.Point(16, 32);
            this.idEkleTxt.Name = "idEkleTxt";
            this.idEkleTxt.Size = new System.Drawing.Size(189, 26);
            this.idEkleTxt.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sil);
            this.groupBox3.Controls.Add(this.listele);
            this.groupBox3.Controls.Add(this.filtrele);
            this.groupBox3.Controls.Add(this.araTxt);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 300);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Görüntüleme / Silme İşlemleri";
            // 
            // sil
            // 
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sil.Location = new System.Drawing.Point(528, 36);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(148, 26);
            this.sil.TabIndex = 15;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // listele
            // 
            this.listele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listele.Location = new System.Drawing.Point(374, 36);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(148, 26);
            this.listele.TabIndex = 14;
            this.listele.Text = "Tümünü Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // filtrele
            // 
            this.filtrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filtrele.Location = new System.Drawing.Point(220, 36);
            this.filtrele.Name = "filtrele";
            this.filtrele.Size = new System.Drawing.Size(148, 26);
            this.filtrele.TabIndex = 13;
            this.filtrele.Text = "Filtrele";
            this.filtrele.UseVisualStyleBackColor = true;
            this.filtrele.Click += new System.EventHandler(this.filtrele_Click);
            // 
            // araTxt
            // 
            this.araTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araTxt.Location = new System.Drawing.Point(25, 36);
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(189, 26);
            this.araTxt.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(651, 198);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.TextBox soyisimTxt;
        private System.Windows.Forms.TextBox isimGunTxt;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button filtrele;
        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idEkleTxt;
        private System.Windows.Forms.TextBox unvanEkleTxt;
        private System.Windows.Forms.TextBox isimEkleTxt;
        private System.Windows.Forms.TextBox soyisimEkleTxt;
    }
}

