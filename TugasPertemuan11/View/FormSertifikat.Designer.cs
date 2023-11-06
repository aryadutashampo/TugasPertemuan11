namespace TugasPertemuan11.View
{
    partial class Form_Sertifikat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sertifikat));
            this.panelJudulS = new System.Windows.Forms.Panel();
            this.labelSertifikat = new System.Windows.Forms.Label();
            this.dataGridViewS = new System.Windows.Forms.DataGridView();
            this.btnCCS = new System.Windows.Forms.Button();
            this.btnCLEARS = new System.Windows.Forms.Button();
            this.btnADDS = new System.Windows.Forms.Button();
            this.txtDS = new System.Windows.Forms.TextBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtIDS = new System.Windows.Forms.TextBox();
            this.labelDS = new System.Windows.Forms.Label();
            this.labelNS = new System.Windows.Forms.Label();
            this.labelIDS = new System.Windows.Forms.Label();
            this.panelS = new System.Windows.Forms.Panel();
            this.labelIDPS = new System.Windows.Forms.Label();
            this.txtIDPS = new System.Windows.Forms.TextBox();
            this.labelCST = new System.Windows.Forms.Label();
            this.txtSearchS = new System.Windows.Forms.TextBox();
            this.btnSearchS = new System.Windows.Forms.Button();
            this.btnPrintS = new System.Windows.Forms.Button();
            this.labelPrintS = new System.Windows.Forms.Label();
            this.printDocumentS = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogS = new System.Windows.Forms.PrintPreviewDialog();
            this.panelJudulS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJudulS
            // 
            this.panelJudulS.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelJudulS.Controls.Add(this.labelPrintS);
            this.panelJudulS.Controls.Add(this.labelSertifikat);
            this.panelJudulS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJudulS.Location = new System.Drawing.Point(0, 0);
            this.panelJudulS.Name = "panelJudulS";
            this.panelJudulS.Size = new System.Drawing.Size(637, 57);
            this.panelJudulS.TabIndex = 15;
            // 
            // labelSertifikat
            // 
            this.labelSertifikat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSertifikat.AutoSize = true;
            this.labelSertifikat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSertifikat.ForeColor = System.Drawing.Color.White;
            this.labelSertifikat.Location = new System.Drawing.Point(211, 9);
            this.labelSertifikat.Name = "labelSertifikat";
            this.labelSertifikat.Size = new System.Drawing.Size(183, 28);
            this.labelSertifikat.TabIndex = 0;
            this.labelSertifikat.Text = "Manage Sertifikat";
            // 
            // dataGridViewS
            // 
            this.dataGridViewS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewS.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewS.Name = "dataGridViewS";
            this.dataGridViewS.RowHeadersWidth = 51;
            this.dataGridViewS.RowTemplate.Height = 24;
            this.dataGridViewS.Size = new System.Drawing.Size(614, 271);
            this.dataGridViewS.TabIndex = 14;
            // 
            // btnCCS
            // 
            this.btnCCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCCS.BackColor = System.Drawing.Color.Red;
            this.btnCCS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCS.ForeColor = System.Drawing.Color.White;
            this.btnCCS.Location = new System.Drawing.Point(466, 465);
            this.btnCCS.Name = "btnCCS";
            this.btnCCS.Size = new System.Drawing.Size(102, 44);
            this.btnCCS.TabIndex = 25;
            this.btnCCS.Text = "CANCEL";
            this.btnCCS.UseVisualStyleBackColor = false;
            this.btnCCS.Click += new System.EventHandler(this.btnCCS_Click);
            // 
            // btnCLEARS
            // 
            this.btnCLEARS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLEARS.BackColor = System.Drawing.Color.Orange;
            this.btnCLEARS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEARS.ForeColor = System.Drawing.Color.White;
            this.btnCLEARS.Location = new System.Drawing.Point(524, 361);
            this.btnCLEARS.Name = "btnCLEARS";
            this.btnCLEARS.Size = new System.Drawing.Size(102, 44);
            this.btnCLEARS.TabIndex = 24;
            this.btnCLEARS.Text = "CLEAR";
            this.btnCLEARS.UseVisualStyleBackColor = false;
            this.btnCLEARS.Click += new System.EventHandler(this.btnCLEARS_Click);
            // 
            // btnADDS
            // 
            this.btnADDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADDS.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnADDS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDS.ForeColor = System.Drawing.Color.White;
            this.btnADDS.Location = new System.Drawing.Point(417, 361);
            this.btnADDS.Name = "btnADDS";
            this.btnADDS.Size = new System.Drawing.Size(102, 44);
            this.btnADDS.TabIndex = 23;
            this.btnADDS.Text = "ADD";
            this.btnADDS.UseVisualStyleBackColor = false;
            this.btnADDS.Click += new System.EventHandler(this.btnADDS_Click);
            // 
            // txtDS
            // 
            this.txtDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDS.Location = new System.Drawing.Point(184, 436);
            this.txtDS.Multiline = true;
            this.txtDS.Name = "txtDS";
            this.txtDS.Size = new System.Drawing.Size(226, 22);
            this.txtDS.TabIndex = 22;
            this.txtDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDS_KeyPress);
            // 
            // txtNS
            // 
            this.txtNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNS.Location = new System.Drawing.Point(184, 397);
            this.txtNS.Multiline = true;
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(226, 22);
            this.txtNS.TabIndex = 21;
            this.txtNS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNS_KeyPress);
            // 
            // txtIDS
            // 
            this.txtIDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDS.Location = new System.Drawing.Point(184, 361);
            this.txtIDS.Multiline = true;
            this.txtIDS.Name = "txtIDS";
            this.txtIDS.Size = new System.Drawing.Size(226, 22);
            this.txtIDS.TabIndex = 20;
            this.txtIDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDS_KeyPress);
            // 
            // labelDS
            // 
            this.labelDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDS.AutoSize = true;
            this.labelDS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDS.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelDS.Location = new System.Drawing.Point(12, 434);
            this.labelDS.Name = "labelDS";
            this.labelDS.Size = new System.Drawing.Size(154, 23);
            this.labelDS.TabIndex = 19;
            this.labelDS.Text = "Deskripsi             :";
            // 
            // labelNS
            // 
            this.labelNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNS.AutoSize = true;
            this.labelNS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNS.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelNS.Location = new System.Drawing.Point(12, 395);
            this.labelNS.Name = "labelNS";
            this.labelNS.Size = new System.Drawing.Size(153, 23);
            this.labelNS.TabIndex = 18;
            this.labelNS.Text = "Nama Sertifikat  :";
            // 
            // labelIDS
            // 
            this.labelIDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIDS.AutoSize = true;
            this.labelIDS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDS.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelIDS.Location = new System.Drawing.Point(12, 359);
            this.labelIDS.Name = "labelIDS";
            this.labelIDS.Size = new System.Drawing.Size(154, 23);
            this.labelIDS.TabIndex = 17;
            this.labelIDS.Text = "ID Sertifikat        :";
            // 
            // panelS
            // 
            this.panelS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelS.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelS.Location = new System.Drawing.Point(12, 334);
            this.panelS.Name = "panelS";
            this.panelS.Size = new System.Drawing.Size(615, 10);
            this.panelS.TabIndex = 16;
            // 
            // labelIDPS
            // 
            this.labelIDPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIDPS.AutoSize = true;
            this.labelIDPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDPS.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelIDPS.Location = new System.Drawing.Point(15, 476);
            this.labelIDPS.Name = "labelIDPS";
            this.labelIDPS.Size = new System.Drawing.Size(151, 23);
            this.labelIDPS.TabIndex = 26;
            this.labelIDPS.Text = "ID Pelatihan        :";
            // 
            // txtIDPS
            // 
            this.txtIDPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDPS.Location = new System.Drawing.Point(184, 478);
            this.txtIDPS.Multiline = true;
            this.txtIDPS.Name = "txtIDPS";
            this.txtIDPS.Size = new System.Drawing.Size(226, 22);
            this.txtIDPS.TabIndex = 27;
            this.txtIDPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPS_KeyPress);
            // 
            // labelCST
            // 
            this.labelCST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCST.AutoSize = true;
            this.labelCST.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCST.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelCST.Location = new System.Drawing.Point(11, 515);
            this.labelCST.Name = "labelCST";
            this.labelCST.Size = new System.Drawing.Size(153, 23);
            this.labelCST.TabIndex = 28;
            this.labelCST.Text = "Cari Sertifikat     :";
            // 
            // txtSearchS
            // 
            this.txtSearchS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchS.Location = new System.Drawing.Point(184, 517);
            this.txtSearchS.Multiline = true;
            this.txtSearchS.Name = "txtSearchS";
            this.txtSearchS.Size = new System.Drawing.Size(226, 22);
            this.txtSearchS.TabIndex = 29;
            // 
            // btnSearchS
            // 
            this.btnSearchS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchS.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearchS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchS.ForeColor = System.Drawing.Color.White;
            this.btnSearchS.Location = new System.Drawing.Point(416, 411);
            this.btnSearchS.Name = "btnSearchS";
            this.btnSearchS.Size = new System.Drawing.Size(102, 44);
            this.btnSearchS.TabIndex = 30;
            this.btnSearchS.Text = "SEARCH";
            this.btnSearchS.UseVisualStyleBackColor = false;
            this.btnSearchS.Click += new System.EventHandler(this.btnSearchS_Click);
            // 
            // btnPrintS
            // 
            this.btnPrintS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintS.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrintS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintS.ForeColor = System.Drawing.Color.White;
            this.btnPrintS.Location = new System.Drawing.Point(525, 411);
            this.btnPrintS.Name = "btnPrintS";
            this.btnPrintS.Size = new System.Drawing.Size(102, 44);
            this.btnPrintS.TabIndex = 31;
            this.btnPrintS.Text = "PRINT";
            this.btnPrintS.UseVisualStyleBackColor = false;
            this.btnPrintS.Click += new System.EventHandler(this.btnPrintS_Click);
            // 
            // labelPrintS
            // 
            this.labelPrintS.AutoSize = true;
            this.labelPrintS.Location = new System.Drawing.Point(6, 9);
            this.labelPrintS.Name = "labelPrintS";
            this.labelPrintS.Size = new System.Drawing.Size(0, 16);
            this.labelPrintS.TabIndex = 1;
            // 
            // printDocumentS
            // 
            this.printDocumentS.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentS_PrintPage);
            // 
            // printPreviewDialogS
            // 
            this.printPreviewDialogS.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogS.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogS.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogS.Enabled = true;
            this.printPreviewDialogS.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogS.Icon")));
            this.printPreviewDialogS.Name = "printPreviewDialogS";
            this.printPreviewDialogS.Visible = false;
            // 
            // Form_Sertifikat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 547);
            this.Controls.Add(this.btnPrintS);
            this.Controls.Add(this.btnSearchS);
            this.Controls.Add(this.txtSearchS);
            this.Controls.Add(this.labelCST);
            this.Controls.Add(this.txtIDPS);
            this.Controls.Add(this.labelIDPS);
            this.Controls.Add(this.panelJudulS);
            this.Controls.Add(this.dataGridViewS);
            this.Controls.Add(this.btnCCS);
            this.Controls.Add(this.btnCLEARS);
            this.Controls.Add(this.btnADDS);
            this.Controls.Add(this.txtDS);
            this.Controls.Add(this.txtNS);
            this.Controls.Add(this.txtIDS);
            this.Controls.Add(this.labelDS);
            this.Controls.Add(this.labelNS);
            this.Controls.Add(this.labelIDS);
            this.Controls.Add(this.panelS);
            this.Name = "Form_Sertifikat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Sertifikat";
            this.Load += new System.EventHandler(this.Form_Sertifikat_Load);
            this.panelJudulS.ResumeLayout(false);
            this.panelJudulS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelJudulS;
        private System.Windows.Forms.Label labelSertifikat;
        private System.Windows.Forms.DataGridView dataGridViewS;
        private System.Windows.Forms.Button btnCCS;
        private System.Windows.Forms.Button btnCLEARS;
        private System.Windows.Forms.Button btnADDS;
        private System.Windows.Forms.TextBox txtDS;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtIDS;
        private System.Windows.Forms.Label labelDS;
        private System.Windows.Forms.Label labelNS;
        private System.Windows.Forms.Label labelIDS;
        private System.Windows.Forms.Panel panelS;
        private System.Windows.Forms.Label labelIDPS;
        private System.Windows.Forms.TextBox txtIDPS;
        private System.Windows.Forms.Label labelPrintS;
        private System.Windows.Forms.Label labelCST;
        private System.Windows.Forms.TextBox txtSearchS;
        private System.Windows.Forms.Button btnSearchS;
        private System.Windows.Forms.Button btnPrintS;
        private System.Drawing.Printing.PrintDocument printDocumentS;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogS;
    }
}