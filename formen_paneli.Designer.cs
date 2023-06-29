
namespace UretimIsletmesi
{
    partial class formen_paneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formen_paneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblFormenTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uretimIsletmesiDataSet21 = new UretimIsletmesi.UretimIsletmesiDataSet2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGorusmeAl = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gorusmeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorusulecekmudurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorusmetarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formengorusmeleritblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uretimIsletmesiDataSet = new UretimIsletmesi.UretimIsletmesiDataSet();
            this.txtGorusmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtGorusulecekMudur = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formengorusmeleri_tblTableAdapter = new UretimIsletmesi.UretimIsletmesiDataSetTableAdapters.formengorusmeleri_tblTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uretimIsletmesiDataSet21)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formengorusmeleritblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uretimIsletmesiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblFormenTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formen Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1005, 120);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(104, 83);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(108, 21);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "______________";
            // 
            // lblFormenTC
            // 
            this.lblFormenTC.AutoSize = true;
            this.lblFormenTC.Location = new System.Drawing.Point(104, 47);
            this.lblFormenTC.Name = "lblFormenTC";
            this.lblFormenTC.Size = new System.Drawing.Size(109, 21);
            this.lblFormenTC.TabIndex = 2;
            this.lblFormenTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formen TC :";
            // 
            // uretimIsletmesiDataSet21
            // 
            this.uretimIsletmesiDataSet21.DataSetName = "UretimIsletmesiDataSet2";
            this.uretimIsletmesiDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnGorusmeAl);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.txtGorusmeTarihi);
            this.groupBox2.Controls.Add(this.txtGorusulecekMudur);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1222, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Görüşme Sayfası";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1105, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnGorusmeAl
            // 
            this.btnGorusmeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGorusmeAl.Location = new System.Drawing.Point(259, 186);
            this.btnGorusmeAl.Name = "btnGorusmeAl";
            this.btnGorusmeAl.Size = new System.Drawing.Size(106, 32);
            this.btnGorusmeAl.TabIndex = 9;
            this.btnGorusmeAl.Text = "Görüşme Al";
            this.btnGorusmeAl.UseVisualStyleBackColor = false;
            this.btnGorusmeAl.Click += new System.EventHandler(this.btnGorusmeAl_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gorusmeidDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.gorusulecekmudurDataGridViewTextBoxColumn,
            this.gorusmetarihiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.formengorusmeleritblBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(372, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(727, 174);
            this.dataGridView2.TabIndex = 8;
            // 
            // gorusmeidDataGridViewTextBoxColumn
            // 
            this.gorusmeidDataGridViewTextBoxColumn.DataPropertyName = "gorusme_id";
            this.gorusmeidDataGridViewTextBoxColumn.HeaderText = "gorusme_id";
            this.gorusmeidDataGridViewTextBoxColumn.Name = "gorusmeidDataGridViewTextBoxColumn";
            this.gorusmeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // gorusulecekmudurDataGridViewTextBoxColumn
            // 
            this.gorusulecekmudurDataGridViewTextBoxColumn.DataPropertyName = "gorusulecek_mudur";
            this.gorusulecekmudurDataGridViewTextBoxColumn.HeaderText = "gorusulecek_mudur";
            this.gorusulecekmudurDataGridViewTextBoxColumn.Name = "gorusulecekmudurDataGridViewTextBoxColumn";
            // 
            // gorusmetarihiDataGridViewTextBoxColumn
            // 
            this.gorusmetarihiDataGridViewTextBoxColumn.DataPropertyName = "gorusme_tarihi";
            this.gorusmetarihiDataGridViewTextBoxColumn.HeaderText = "gorusme_tarihi";
            this.gorusmetarihiDataGridViewTextBoxColumn.Name = "gorusmetarihiDataGridViewTextBoxColumn";
            // 
            // formengorusmeleritblBindingSource
            // 
            this.formengorusmeleritblBindingSource.DataMember = "formengorusmeleri_tbl";
            this.formengorusmeleritblBindingSource.DataSource = this.uretimIsletmesiDataSet;
            // 
            // uretimIsletmesiDataSet
            // 
            this.uretimIsletmesiDataSet.DataSetName = "UretimIsletmesiDataSet";
            this.uretimIsletmesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGorusmeTarihi
            // 
            this.txtGorusmeTarihi.Location = new System.Drawing.Point(166, 151);
            this.txtGorusmeTarihi.Name = "txtGorusmeTarihi";
            this.txtGorusmeTarihi.Size = new System.Drawing.Size(200, 29);
            this.txtGorusmeTarihi.TabIndex = 7;
            // 
            // txtGorusulecekMudur
            // 
            this.txtGorusulecekMudur.Location = new System.Drawing.Point(166, 116);
            this.txtGorusulecekMudur.Name = "txtGorusulecekMudur";
            this.txtGorusulecekMudur.Size = new System.Drawing.Size(200, 29);
            this.txtGorusulecekMudur.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(166, 80);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 29);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(166, 44);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 29);
            this.txtAd.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Görüşme Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Görüşülecek Müdür :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad :";
            // 
            // formengorusmeleri_tblTableAdapter
            // 
            this.formengorusmeleri_tblTableAdapter.ClearBeforeFill = true;
            // 
            // formen_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1244, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formen_paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formen Panel Sayfası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formen_paneli_FormClosed);
            this.Load += new System.EventHandler(this.formen_paneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uretimIsletmesiDataSet21)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formengorusmeleritblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uretimIsletmesiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblFormenTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UretimIsletmesiDataSet2 uretimIsletmesiDataSet21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtGorusmeTarihi;
        private System.Windows.Forms.TextBox txtGorusulecekMudur;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnGorusmeAl;
        private UretimIsletmesiDataSet uretimIsletmesiDataSet;
        private System.Windows.Forms.BindingSource formengorusmeleritblBindingSource;
        private UretimIsletmesiDataSetTableAdapters.formengorusmeleri_tblTableAdapter formengorusmeleri_tblTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iscitcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusmeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusulecekmudurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusmetarihiDataGridViewTextBoxColumn;
    }
}