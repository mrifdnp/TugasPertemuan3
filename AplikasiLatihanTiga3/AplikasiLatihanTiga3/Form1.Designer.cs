namespace AplikasiLatihanTiga3
{
    partial class frmLatihanTiga3
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
            this.textNama = new System.Windows.Forms.TextBox();
            this.listPekerjaan = new System.Windows.Forms.ListBox();
            this.comboPendidikan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pesan3 = new System.Windows.Forms.TextBox();
            this.Pesan2 = new System.Windows.Forms.TextBox();
            this.Pesan1 = new System.Windows.Forms.TextBox();
            this.tblOK = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(77, 3);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(231, 20);
            this.textNama.TabIndex = 1;
            // 
            // listPekerjaan
            // 
            this.listPekerjaan.FormattingEnabled = true;
            this.listPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.listPekerjaan.Location = new System.Drawing.Point(77, 57);
            this.listPekerjaan.Name = "listPekerjaan";
            this.listPekerjaan.Size = new System.Drawing.Size(234, 108);
            this.listPekerjaan.TabIndex = 2;
            // 
            // comboPendidikan
            // 
            this.comboPendidikan.FormattingEnabled = true;
            this.comboPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "PascaSarjana"});
            this.comboPendidikan.Location = new System.Drawing.Point(77, 30);
            this.comboPendidikan.Name = "comboPendidikan";
            this.comboPendidikan.Size = new System.Drawing.Size(231, 21);
            this.comboPendidikan.TabIndex = 3;
            this.comboPendidikan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pekerjaan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pendidikan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pesan3
            // 
            this.Pesan3.Enabled = false;
            this.Pesan3.Location = new System.Drawing.Point(3, 57);
            this.Pesan3.Name = "Pesan3";
            this.Pesan3.Size = new System.Drawing.Size(305, 20);
            this.Pesan3.TabIndex = 7;
            // 
            // Pesan2
            // 
            this.Pesan2.Enabled = false;
            this.Pesan2.Location = new System.Drawing.Point(3, 30);
            this.Pesan2.Name = "Pesan2";
            this.Pesan2.Size = new System.Drawing.Size(305, 20);
            this.Pesan2.TabIndex = 8;
            // 
            // Pesan1
            // 
            this.Pesan1.Enabled = false;
            this.Pesan1.Location = new System.Drawing.Point(3, 3);
            this.Pesan1.Name = "Pesan1";
            this.Pesan1.Size = new System.Drawing.Size(305, 20);
            this.Pesan1.TabIndex = 9;
            this.Pesan1.TextChanged += new System.EventHandler(this.txtPesan1_TextChanged);
            // 
            // tblOK
            // 
            this.tblOK.Location = new System.Drawing.Point(3, 103);
            this.tblOK.Name = "tblOK";
            this.tblOK.Size = new System.Drawing.Size(305, 23);
            this.tblOK.TabIndex = 10;
            this.tblOK.Text = "Ok";
            this.tblOK.UseVisualStyleBackColor = true;
            this.tblOK.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(321, 319);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.56688F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.43312F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboPendidikan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textNama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listPekerjaan, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.10714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.89286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Pesan1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tblOK, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Pesan2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Pesan3, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 178);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 131);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // frmLatihanTiga3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 352);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmLatihanTiga3";
            this.Text = "Latihan 3.3";
            this.Load += new System.EventHandler(this.frmLatihanTiga3_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.ListBox listPekerjaan;
        private System.Windows.Forms.ComboBox comboPendidikan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pesan3;
        private System.Windows.Forms.TextBox Pesan2;
        private System.Windows.Forms.TextBox Pesan1;
        private System.Windows.Forms.Button tblOK;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

