
namespace UretimIsletmesi
{
    partial class isci_paneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(isci_paneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_isciTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iscigorusmeleritblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uretimIsletmesiDataSet2 = new UretimIsletmesi.UretimIsletmesiDataSet2();
            this.btnGorusmeAl = new System.Windows.Forms.Button();
            this.txtGorusmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtGorusulecekMudur = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formengorusmeleritblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iscigorusmeleri_tblTableAdapter = new UretimIsletmesi.UretimIsletmesiDataSet2TableAdapters.iscigorusmeleri_tblTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscigorusmeleritblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uretimIsletmesiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formengorusmeleritblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lbl_isciTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşçi Bilgileri";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(93, 86);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(108, 21);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "______________";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1005, 124);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbl_isciTC
            // 
            this.lbl_isciTC.AutoSize = true;
            this.lbl_isciTC.Location = new System.Drawing.Point(93, 54);
            this.lbl_isciTC.Name = "lbl_isciTC";
            this.lbl_isciTC.Size = new System.Drawing.Size(109, 21);
            this.lbl_isciTC.TabIndex = 2;
            this.lbl_isciTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşçi TC :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnGorusmeAl);
            this.groupBox2.Controls.Add(this.txtGorusmeTarihi);
            this.groupBox2.Controls.Add(this.txtGorusulecekMudur);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1213, 292);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Görüşme Sayfası";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1064, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.DataSource = this.iscigorusmeleritblBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(411, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(647, 184);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "gorusme_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "gorusme_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ad";
            this.dataGridViewTextBoxColumn2.HeaderText = "ad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "soyad";
            this.dataGridViewTextBoxColumn3.HeaderText = "soyad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gorusulecek_mudur";
            this.dataGridViewTextBoxColumn4.HeaderText = "gorusulecek_mudur";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gorusme_tarihi";
            this.dataGridViewTextBoxColumn5.HeaderText = "gorusme_tarihi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iscigorusmeleritblBindingSource
            // 
            this.iscigorusmeleritblBindingSource.DataMember = "iscigorusmeleri_tbl";
            this.iscigorusmeleritblBindingSource.DataSource = this.uretimIsletmesiDataSet2;
            // 
            // uretimIsletmesiDataSet2
            // 
            this.uretimIsletmesiDataSet2.DataSetName = "UretimIsletmesiDataSet2";
            this.uretimIsletmesiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGorusmeAl
            // 
            this.btnGorusmeAl.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGorusmeAl.Location = new System.Drawing.Point(294, 208);
            this.btnGorusmeAl.Name = "btnGorusmeAl";
            this.btnGorusmeAl.Size = new System.Drawing.Size(111, 29);
            this.btnGorusmeAl.TabIndex = 9;
            this.btnGorusmeAl.Text = "Görüşme Al";
            this.btnGorusmeAl.UseVisualStyleBackColor = false;
            this.btnGorusmeAl.Click += new System.EventHandler(this.btnGorusmeAl_Click);
            // 
            // txtGorusmeTarihi
            // 
            this.txtGorusmeTarihi.Location = new System.Drawing.Point(171, 173);
            this.txtGorusmeTarihi.Name = "txtGorusmeTarihi";
            this.txtGorusmeTarihi.Size = new System.Drawing.Size(234, 29);
            this.txtGorusmeTarihi.TabIndex = 7;
            // 
            // txtGorusulecekMudur
            // 
            this.txtGorusulecekMudur.Location = new System.Drawing.Point(170, 133);
            this.txtGorusulecekMudur.Name = "txtGorusulecekMudur";
            this.txtGorusulecekMudur.Size = new System.Drawing.Size(235, 29);
            this.txtGorusulecekMudur.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(170, 96);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(235, 29);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(170, 53);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(235, 29);
            this.txtAd.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Görüşme Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Görüşülecek Müdür :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad :";
            // 
            // formengorusmeleritblBindingSource
            // 
            this.formengorusmeleritblBindingSource.DataMember = "formengorusmeleri_tbl";
            // 
            // iscigorusmeleri_tblTableAdapter
            // 
            this.iscigorusmeleri_tblTableAdapter.ClearBeforeFill = true;
            // 
            // isci_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1237, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "isci_paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşçi Panel Sayfası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.isci_paneli_FormClosed);
            this.Load += new System.EventHandler(this.isci_paneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscigorusmeleritblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uretimIsletmesiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formengorusmeleritblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lbl_isciTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker txtGorusmeTarihi;
        private System.Windows.Forms.TextBox txtGorusulecekMudur;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGorusmeAl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private UretimIsletmesiDataSet2 uretimIsletmesiDataSet2;
        private System.Windows.Forms.BindingSource iscigorusmeleritblBindingSource;
        private UretimIsletmesiDataSet2TableAdapters.iscigorusmeleri_tblTableAdapter iscigorusmeleri_tblTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusmeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusulecekmudurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusmetarihiDataGridViewTextBoxColumn;
       // private UretimIsletmesiDataSet1 uretimIsletmesiDataSet1;
        private System.Windows.Forms.BindingSource formengorusmeleritblBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        // private UretimIsletmesiDataSet1TableAdapters.formengorusmeleri_tblTableAdapter formengorusmeleri_tblTableAdapter;
    }
}