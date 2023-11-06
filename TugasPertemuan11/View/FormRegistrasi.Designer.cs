namespace TugasPertemuan11.View
{
    partial class Form_Registrasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Registrasi));
            this.dataGridViewREG = new System.Windows.Forms.DataGridView();
            this.panelJudulreg = new System.Windows.Forms.Panel();
            this.labelRegistrasi = new System.Windows.Forms.Label();
            this.panelTutupREG = new System.Windows.Forms.Panel();
            this.labelREGID = new System.Windows.Forms.Label();
            this.labelREGIDP = new System.Windows.Forms.Label();
            this.labelIDPLR = new System.Windows.Forms.Label();
            this.txtIDREG = new System.Windows.Forms.TextBox();
            this.txtIDPSREG = new System.Windows.Forms.TextBox();
            this.txtIDPLREG = new System.Windows.Forms.TextBox();
            this.btnADDREG = new System.Windows.Forms.Button();
            this.btnCLEARREG = new System.Windows.Forms.Button();
            this.btnCCREG = new System.Windows.Forms.Button();
            this.labelCREG = new System.Windows.Forms.Label();
            this.txtCREG = new System.Windows.Forms.TextBox();
            this.btnSearchREG = new System.Windows.Forms.Button();
            this.btnPrintREG = new System.Windows.Forms.Button();
            this.labelPrintREG = new System.Windows.Forms.Label();
            this.printDocumentREG = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogREG = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewREG)).BeginInit();
            this.panelJudulreg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewREG
            // 
            this.dataGridViewREG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewREG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewREG.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewREG.Name = "dataGridViewREG";
            this.dataGridViewREG.RowHeadersWidth = 51;
            this.dataGridViewREG.RowTemplate.Height = 24;
            this.dataGridViewREG.Size = new System.Drawing.Size(614, 275);
            this.dataGridViewREG.TabIndex = 0;
            // 
            // panelJudulreg
            // 
            this.panelJudulreg.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelJudulreg.Controls.Add(this.labelPrintREG);
            this.panelJudulreg.Controls.Add(this.labelRegistrasi);
            this.panelJudulreg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJudulreg.Location = new System.Drawing.Point(0, 0);
            this.panelJudulreg.Name = "panelJudulreg";
            this.panelJudulreg.Size = new System.Drawing.Size(637, 57);
            this.panelJudulreg.TabIndex = 1;
            // 
            // labelRegistrasi
            // 
            this.labelRegistrasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRegistrasi.AutoSize = true;
            this.labelRegistrasi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrasi.ForeColor = System.Drawing.Color.White;
            this.labelRegistrasi.Location = new System.Drawing.Point(211, 9);
            this.labelRegistrasi.Name = "labelRegistrasi";
            this.labelRegistrasi.Size = new System.Drawing.Size(199, 28);
            this.labelRegistrasi.TabIndex = 0;
            this.labelRegistrasi.Text = "Registrasi Pelatihan";
            // 
            // panelTutupREG
            // 
            this.panelTutupREG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTutupREG.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelTutupREG.Location = new System.Drawing.Point(12, 338);
            this.panelTutupREG.Name = "panelTutupREG";
            this.panelTutupREG.Size = new System.Drawing.Size(615, 10);
            this.panelTutupREG.TabIndex = 2;
            // 
            // labelREGID
            // 
            this.labelREGID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelREGID.AutoSize = true;
            this.labelREGID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelREGID.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelREGID.Location = new System.Drawing.Point(12, 355);
            this.labelREGID.Name = "labelREGID";
            this.labelREGID.Size = new System.Drawing.Size(151, 23);
            this.labelREGID.TabIndex = 3;
            this.labelREGID.Text = "ID Registrasi       :";
            // 
            // labelREGIDP
            // 
            this.labelREGIDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelREGIDP.AutoSize = true;
            this.labelREGIDP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelREGIDP.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelREGIDP.Location = new System.Drawing.Point(12, 391);
            this.labelREGIDP.Name = "labelREGIDP";
            this.labelREGIDP.Size = new System.Drawing.Size(150, 23);
            this.labelREGIDP.TabIndex = 4;
            this.labelREGIDP.Text = "ID Peserta           :";
            // 
            // labelIDPLR
            // 
            this.labelIDPLR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIDPLR.AutoSize = true;
            this.labelIDPLR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDPLR.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelIDPLR.Location = new System.Drawing.Point(12, 430);
            this.labelIDPLR.Name = "labelIDPLR";
            this.labelIDPLR.Size = new System.Drawing.Size(151, 23);
            this.labelIDPLR.TabIndex = 5;
            this.labelIDPLR.Text = "ID Pelatihan        :";
            // 
            // txtIDREG
            // 
            this.txtIDREG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDREG.Location = new System.Drawing.Point(184, 357);
            this.txtIDREG.Multiline = true;
            this.txtIDREG.Name = "txtIDREG";
            this.txtIDREG.Size = new System.Drawing.Size(226, 22);
            this.txtIDREG.TabIndex = 6;
            this.txtIDREG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDREG_KeyPress);
            // 
            // txtIDPSREG
            // 
            this.txtIDPSREG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDPSREG.Location = new System.Drawing.Point(184, 393);
            this.txtIDPSREG.Multiline = true;
            this.txtIDPSREG.Name = "txtIDPSREG";
            this.txtIDPSREG.Size = new System.Drawing.Size(226, 22);
            this.txtIDPSREG.TabIndex = 7;
            this.txtIDPSREG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPSREG_KeyPress);
            // 
            // txtIDPLREG
            // 
            this.txtIDPLREG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDPLREG.Location = new System.Drawing.Point(184, 432);
            this.txtIDPLREG.Multiline = true;
            this.txtIDPLREG.Name = "txtIDPLREG";
            this.txtIDPLREG.Size = new System.Drawing.Size(226, 22);
            this.txtIDPLREG.TabIndex = 8;
            this.txtIDPLREG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPLREG_KeyPress);
            // 
            // btnADDREG
            // 
            this.btnADDREG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADDREG.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnADDREG.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDREG.ForeColor = System.Drawing.Color.White;
            this.btnADDREG.Location = new System.Drawing.Point(417, 357);
            this.btnADDREG.Name = "btnADDREG";
            this.btnADDREG.Size = new System.Drawing.Size(102, 44);
            this.btnADDREG.TabIndex = 9;
            this.btnADDREG.Text = "ADD";
            this.btnADDREG.UseVisualStyleBackColor = false;
            this.btnADDREG.Click += new System.EventHandler(this.btnADDREG_Click);
            // 
            // btnCLEARREG
            // 
            this.btnCLEARREG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLEARREG.BackColor = System.Drawing.Color.Orange;
            this.btnCLEARREG.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEARREG.ForeColor = System.Drawing.Color.White;
            this.btnCLEARREG.Location = new System.Drawing.Point(524, 357);
            this.btnCLEARREG.Name = "btnCLEARREG";
            this.btnCLEARREG.Size = new System.Drawing.Size(102, 44);
            this.btnCLEARREG.TabIndex = 12;
            this.btnCLEARREG.Text = "CLEAR";
            this.btnCLEARREG.UseVisualStyleBackColor = false;
            this.btnCLEARREG.Click += new System.EventHandler(this.btnCLEARREG_Click);
            // 
            // btnCCREG
            // 
            this.btnCCREG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCCREG.BackColor = System.Drawing.Color.Red;
            this.btnCCREG.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCREG.ForeColor = System.Drawing.Color.White;
            this.btnCCREG.Location = new System.Drawing.Point(468, 406);
            this.btnCCREG.Name = "btnCCREG";
            this.btnCCREG.Size = new System.Drawing.Size(102, 44);
            this.btnCCREG.TabIndex = 13;
            this.btnCCREG.Text = "CANCEL";
            this.btnCCREG.UseVisualStyleBackColor = false;
            this.btnCCREG.Click += new System.EventHandler(this.btnCCREG_Click);
            // 
            // labelCREG
            // 
            this.labelCREG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCREG.AutoSize = true;
            this.labelCREG.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCREG.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelCREG.Location = new System.Drawing.Point(12, 467);
            this.labelCREG.Name = "labelCREG";
            this.labelCREG.Size = new System.Drawing.Size(150, 23);
            this.labelCREG.TabIndex = 14;
            this.labelCREG.Text = "Cari Registrasi    :";
            // 
            // txtCREG
            // 
            this.txtCREG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCREG.Location = new System.Drawing.Point(184, 467);
            this.txtCREG.Multiline = true;
            this.txtCREG.Name = "txtCREG";
            this.txtCREG.Size = new System.Drawing.Size(226, 22);
            this.txtCREG.TabIndex = 15;
            // 
            // btnSearchREG
            // 
            this.btnSearchREG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchREG.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearchREG.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchREG.ForeColor = System.Drawing.Color.White;
            this.btnSearchREG.Location = new System.Drawing.Point(417, 454);
            this.btnSearchREG.Name = "btnSearchREG";
            this.btnSearchREG.Size = new System.Drawing.Size(102, 44);
            this.btnSearchREG.TabIndex = 16;
            this.btnSearchREG.Text = "SEARCH";
            this.btnSearchREG.UseVisualStyleBackColor = false;
            this.btnSearchREG.Click += new System.EventHandler(this.btnSearchREG_Click);
            // 
            // btnPrintREG
            // 
            this.btnPrintREG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintREG.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrintREG.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintREG.ForeColor = System.Drawing.Color.White;
            this.btnPrintREG.Location = new System.Drawing.Point(525, 454);
            this.btnPrintREG.Name = "btnPrintREG";
            this.btnPrintREG.Size = new System.Drawing.Size(102, 44);
            this.btnPrintREG.TabIndex = 17;
            this.btnPrintREG.Text = "PRINT";
            this.btnPrintREG.UseVisualStyleBackColor = false;
            this.btnPrintREG.Click += new System.EventHandler(this.btnPrintREG_Click);
            // 
            // labelPrintREG
            // 
            this.labelPrintREG.AutoSize = true;
            this.labelPrintREG.Location = new System.Drawing.Point(-3, 0);
            this.labelPrintREG.Name = "labelPrintREG";
            this.labelPrintREG.Size = new System.Drawing.Size(0, 16);
            this.labelPrintREG.TabIndex = 1;
            // 
            // printDocumentREG
            // 
            this.printDocumentREG.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentREG_PrintPage);
            // 
            // printPreviewDialogREG
            // 
            this.printPreviewDialogREG.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogREG.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogREG.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogREG.Enabled = true;
            this.printPreviewDialogREG.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogREG.Icon")));
            this.printPreviewDialogREG.Name = "printPreviewDialogREG";
            this.printPreviewDialogREG.Visible = false;
            // 
            // Form_Registrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 508);
            this.Controls.Add(this.btnPrintREG);
            this.Controls.Add(this.btnSearchREG);
            this.Controls.Add(this.txtCREG);
            this.Controls.Add(this.labelCREG);
            this.Controls.Add(this.btnCCREG);
            this.Controls.Add(this.btnCLEARREG);
            this.Controls.Add(this.btnADDREG);
            this.Controls.Add(this.txtIDPLREG);
            this.Controls.Add(this.txtIDPSREG);
            this.Controls.Add(this.txtIDREG);
            this.Controls.Add(this.labelIDPLR);
            this.Controls.Add(this.labelREGIDP);
            this.Controls.Add(this.labelREGID);
            this.Controls.Add(this.panelTutupREG);
            this.Controls.Add(this.panelJudulreg);
            this.Controls.Add(this.dataGridViewREG);
            this.Name = "Form_Registrasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Registrasi";
            this.Load += new System.EventHandler(this.Form_Registrasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewREG)).EndInit();
            this.panelJudulreg.ResumeLayout(false);
            this.panelJudulreg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewREG;
        private System.Windows.Forms.Panel panelJudulreg;
        private System.Windows.Forms.Label labelRegistrasi;
        private System.Windows.Forms.Panel panelTutupREG;
        private System.Windows.Forms.Label labelREGID;
        private System.Windows.Forms.Label labelREGIDP;
        private System.Windows.Forms.Label labelIDPLR;
        private System.Windows.Forms.TextBox txtIDREG;
        private System.Windows.Forms.TextBox txtIDPSREG;
        private System.Windows.Forms.TextBox txtIDPLREG;
        private System.Windows.Forms.Button btnADDREG;
        private System.Windows.Forms.Button btnCLEARREG;
        private System.Windows.Forms.Button btnCCREG;
        private System.Windows.Forms.Label labelCREG;
        private System.Windows.Forms.TextBox txtCREG;
        private System.Windows.Forms.Button btnSearchREG;
        private System.Windows.Forms.Button btnPrintREG;
        private System.Windows.Forms.Label labelPrintREG;
        private System.Drawing.Printing.PrintDocument printDocumentREG;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogREG;
    }
}