
namespace UretimIsletmesi
{
    partial class mudur_paneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mudur_paneli));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblMudurTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnisci_islemleri = new System.Windows.Forms.Button();
            this.btnformen_islemleri = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblMudurTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müdür Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(255, 96);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(108, 21);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "______________";
            // 
            // lblMudurTC
            // 
            this.lblMudurTC.AutoSize = true;
            this.lblMudurTC.Location = new System.Drawing.Point(255, 57);
            this.lblMudurTC.Name = "lblMudurTC";
            this.lblMudurTC.Size = new System.Drawing.Size(109, 21);
            this.lblMudurTC.TabIndex = 3;
            this.lblMudurTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Müdür TC :";
            // 
            // btnisci_islemleri
            // 
            this.btnisci_islemleri.BackColor = System.Drawing.Color.Turquoise;
            this.btnisci_islemleri.Location = new System.Drawing.Point(12, 199);
            this.btnisci_islemleri.Name = "btnisci_islemleri";
            this.btnisci_islemleri.Size = new System.Drawing.Size(588, 60);
            this.btnisci_islemleri.TabIndex = 5;
            this.btnisci_islemleri.Text = "İşçi İşlemleri";
            this.btnisci_islemleri.UseVisualStyleBackColor = false;
            this.btnisci_islemleri.Click += new System.EventHandler(this.btnisci_islemleri_Click);
            // 
            // btnformen_islemleri
            // 
            this.btnformen_islemleri.BackColor = System.Drawing.Color.Turquoise;
            this.btnformen_islemleri.Location = new System.Drawing.Point(606, 199);
            this.btnformen_islemleri.Name = "btnformen_islemleri";
            this.btnformen_islemleri.Size = new System.Drawing.Size(588, 60);
            this.btnformen_islemleri.TabIndex = 6;
            this.btnformen_islemleri.Text = "Formen İşlemleri";
            this.btnformen_islemleri.UseVisualStyleBackColor = false;
            this.btnformen_islemleri.Click += new System.EventHandler(this.btnformen_islemleri_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.Turquoise;
            this.btnCikisYap.Location = new System.Drawing.Point(12, 265);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(1176, 60);
            this.btnCikisYap.TabIndex = 7;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // mudur_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1199, 332);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnformen_islemleri);
            this.Controls.Add(this.btnisci_islemleri);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mudur_paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müdür Paneli Sayfası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mudur_paneli_FormClosed);
            this.Load += new System.EventHandler(this.mudur_paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblMudurTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnisci_islemleri;
        private System.Windows.Forms.Button btnformen_islemleri;
        private System.Windows.Forms.Button btnCikisYap;
    }
}