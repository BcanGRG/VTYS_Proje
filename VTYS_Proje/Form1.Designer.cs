namespace VTYS_Proje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_KatID = new System.Windows.Forms.TextBox();
            this.Btn_Listele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_KatAd = new System.Windows.Forms.TextBox();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_adet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrchid;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_KatID
            // 
            this.Txt_KatID.Location = new System.Drawing.Point(584, 36);
            this.Txt_KatID.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_KatID.Name = "Txt_KatID";
            this.Txt_KatID.Size = new System.Drawing.Size(148, 24);
            this.Txt_KatID.TabIndex = 2;
            // 
            // Btn_Listele
            // 
            this.Btn_Listele.BackColor = System.Drawing.Color.Blue;
            this.Btn_Listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Listele.ForeColor = System.Drawing.Color.White;
            this.Btn_Listele.Location = new System.Drawing.Point(671, 106);
            this.Btn_Listele.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Listele.Name = "Btn_Listele";
            this.Btn_Listele.Size = new System.Drawing.Size(112, 32);
            this.Btn_Listele.TabIndex = 3;
            this.Btn_Listele.Text = "Listele";
            this.Btn_Listele.UseVisualStyleBackColor = false;
            this.Btn_Listele.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrchid;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori Ad";
            // 
            // Txt_KatAd
            // 
            this.Txt_KatAd.Location = new System.Drawing.Point(584, 74);
            this.Txt_KatAd.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_KatAd.Name = "Txt_KatAd";
            this.Txt_KatAd.Size = new System.Drawing.Size(148, 24);
            this.Txt_KatAd.TabIndex = 5;
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.BackColor = System.Drawing.Color.Blue;
            this.Btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.Btn_Ekle.Location = new System.Drawing.Point(671, 146);
            this.Btn_Ekle.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(112, 32);
            this.Btn_Ekle.TabIndex = 6;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = false;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.BackColor = System.Drawing.Color.Blue;
            this.Btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guncelle.ForeColor = System.Drawing.Color.White;
            this.Btn_Guncelle.Location = new System.Drawing.Point(671, 226);
            this.Btn_Guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(112, 32);
            this.Btn_Guncelle.TabIndex = 7;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = false;
            this.Btn_Guncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.BackColor = System.Drawing.Color.Blue;
            this.Btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sil.ForeColor = System.Drawing.Color.White;
            this.Btn_Sil.Location = new System.Drawing.Point(671, 186);
            this.Btn_Sil.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(112, 32);
            this.Btn_Sil.TabIndex = 8;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = false;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_adet
            // 
            this.Btn_adet.BackColor = System.Drawing.Color.Blue;
            this.Btn_adet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_adet.ForeColor = System.Drawing.Color.White;
            this.Btn_adet.Location = new System.Drawing.Point(514, 116);
            this.Btn_adet.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_adet.Name = "Btn_adet";
            this.Btn_adet.Size = new System.Drawing.Size(112, 32);
            this.Btn_adet.TabIndex = 9;
            this.Btn_adet.Text = "AdetListele";
            this.Btn_adet.UseVisualStyleBackColor = false;
            this.Btn_adet.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(796, 305);
            this.Controls.Add(this.Btn_adet);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Btn_Ekle);
            this.Controls.Add(this.Txt_KatAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Listele);
            this.Controls.Add(this.Txt_KatID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_KatID;
        private System.Windows.Forms.Button Btn_Listele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_KatAd;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_adet;
    }
}

