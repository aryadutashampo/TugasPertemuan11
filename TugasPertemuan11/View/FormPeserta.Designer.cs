namespace TugasPertemuan11.View
{
    partial class Form_Peserta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Peserta));
            this.panelJudulPS = new System.Windows.Forms.Panel();
            this.labelJudulPS = new System.Windows.Forms.Label();
            this.dataGridViewPS = new System.Windows.Forms.DataGridView();
            this.btnCCPS = new System.Windows.Forms.Button();
            this.btnCLEARPS = new System.Windows.Forms.Button();
            this.btnADDPS = new System.Windows.Forms.Button();
            this.txtEMAILPS = new System.Windows.Forms.TextBox();
            this.txtNAMAPS = new System.Windows.Forms.TextBox();
            this.txtIDPSPS = new System.Windows.Forms.TextBox();
            this.labelEmailPS = new System.Windows.Forms.Label();
            this.labelNamaPS = new System.Windows.Forms.Label();
            this.panelTutupPS = new System.Windows.Forms.Panel();
            this.labelIDPSPS = new System.Windows.Forms.Label();
            this.labelNTPS = new System.Windows.Forms.Label();
            this.txtNTPS = new System.Windows.Forms.TextBox();
            this.btnREADPS = new System.Windows.Forms.Button();
            this.btnUPDPS = new System.Windows.Forms.Button();
            this.btnDELPS = new System.Windows.Forms.Button();
            this.btnSearchPS = new System.Windows.Forms.Button();
            this.btnPrintPS = new System.Windows.Forms.Button();
            this.printPreviewDialogPS = new System.Windows.Forms.PrintPreviewDialog();
            this.labelPPS = new System.Windows.Forms.Label();
            this.labelCPS = new System.Windows.Forms.Label();
            this.txtCPS = new System.Windows.Forms.TextBox();
            this.printDocumentPS = new System.Drawing.Printing.PrintDocument();
            this.panelJudulPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJudulPS
            // 
            this.panelJudulPS.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelJudulPS.Controls.Add(this.labelPPS);
            this.panelJudulPS.Controls.Add(this.labelJudulPS);
            this.panelJudulPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJudulPS.Location = new System.Drawing.Point(0, 0);
            this.panelJudulPS.Name = "panelJudulPS";
            this.panelJudulPS.Size = new System.Drawing.Size(899, 57);
            this.panelJudulPS.TabIndex = 15;
            // 
            // labelJudulPS
            // 
            this.labelJudulPS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelJudulPS.AutoSize = true;
            this.labelJudulPS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudulPS.ForeColor = System.Drawing.Color.White;
            this.labelJudulPS.Location = new System.Drawing.Point(390, 9);
            this.labelJudulPS.Name = "labelJudulPS";
            this.labelJudulPS.Size = new System.Drawing.Size(164, 28);
            this.labelJudulPS.TabIndex = 0;
            this.labelJudulPS.Text = "Manage Peserta";
            // 
            // dataGridViewPS
            // 
            this.dataGridViewPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPS.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewPS.Name = "dataGridViewPS";
            this.dataGridViewPS.RowHeadersWidth = 51;
            this.dataGridViewPS.RowTemplate.Height = 24;
            this.dataGridViewPS.Size = new System.Drawing.Size(875, 271);
            this.dataGridViewPS.TabIndex = 14;
            // 
            // btnCCPS
            // 
            this.btnCCPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCCPS.BackColor = System.Drawing.Color.Red;
            this.btnCCPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCPS.ForeColor = System.Drawing.Color.White;
            this.btnCCPS.Location = new System.Drawing.Point(765, 448);
            this.btnCCPS.Name = "btnCCPS";
            this.btnCCPS.Size = new System.Drawing.Size(102, 44);
            this.btnCCPS.TabIndex = 25;
            this.btnCCPS.Text = "CANCEL";
            this.btnCCPS.UseVisualStyleBackColor = false;
            this.btnCCPS.Click += new System.EventHandler(this.btnCCPS_Click);
            // 
            // btnCLEARPS
            // 
            this.btnCLEARPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLEARPS.BackColor = System.Drawing.Color.Orange;
            this.btnCLEARPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEARPS.ForeColor = System.Drawing.Color.White;
            this.btnCLEARPS.Location = new System.Drawing.Point(657, 448);
            this.btnCLEARPS.Name = "btnCLEARPS";
            this.btnCLEARPS.Size = new System.Drawing.Size(102, 43);
            this.btnCLEARPS.TabIndex = 24;
            this.btnCLEARPS.Text = "CLEAR";
            this.btnCLEARPS.UseVisualStyleBackColor = false;
            this.btnCLEARPS.Click += new System.EventHandler(this.btnCLEARPS_Click);
            // 
            // btnADDPS
            // 
            this.btnADDPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADDPS.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnADDPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDPS.ForeColor = System.Drawing.Color.White;
            this.btnADDPS.Location = new System.Drawing.Point(442, 398);
            this.btnADDPS.Name = "btnADDPS";
            this.btnADDPS.Size = new System.Drawing.Size(102, 44);
            this.btnADDPS.TabIndex = 23;
            this.btnADDPS.Text = "ADD";
            this.btnADDPS.UseVisualStyleBackColor = false;
            this.btnADDPS.Click += new System.EventHandler(this.btnADDPS_Click);
            // 
            // txtEMAILPS
            // 
            this.txtEMAILPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEMAILPS.Location = new System.Drawing.Point(184, 430);
            this.txtEMAILPS.Multiline = true;
            this.txtEMAILPS.Name = "txtEMAILPS";
            this.txtEMAILPS.Size = new System.Drawing.Size(226, 22);
            this.txtEMAILPS.TabIndex = 22;
            this.txtEMAILPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEMAILPS_KeyPress);
            // 
            // txtNAMAPS
            // 
            this.txtNAMAPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNAMAPS.Location = new System.Drawing.Point(184, 391);
            this.txtNAMAPS.Multiline = true;
            this.txtNAMAPS.Name = "txtNAMAPS";
            this.txtNAMAPS.Size = new System.Drawing.Size(226, 22);
            this.txtNAMAPS.TabIndex = 21;
            this.txtNAMAPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNAMAPS_KeyPress);
            // 
            // txtIDPSPS
            // 
            this.txtIDPSPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDPSPS.Location = new System.Drawing.Point(184, 355);
            this.txtIDPSPS.Multiline = true;
            this.txtIDPSPS.Name = "txtIDPSPS";
            this.txtIDPSPS.Size = new System.Drawing.Size(226, 22);
            this.txtIDPSPS.TabIndex = 20;
            this.txtIDPSPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPSPS_KeyPress);
            // 
            // labelEmailPS
            // 
            this.labelEmailPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEmailPS.AutoSize = true;
            this.labelEmailPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailPS.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelEmailPS.Location = new System.Drawing.Point(12, 428);
            this.labelEmailPS.Name = "labelEmailPS";
            this.labelEmailPS.Size = new System.Drawing.Size(151, 23);
            this.labelEmailPS.TabIndex = 19;
            this.labelEmailPS.Text = "E-Mail                 :";
            // 
            // labelNamaPS
            // 
            this.labelNamaPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNamaPS.AutoSize = true;
            this.labelNamaPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPS.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelNamaPS.Location = new System.Drawing.Point(12, 389);
            this.labelNamaPS.Name = "labelNamaPS";
            this.labelNamaPS.Size = new System.Drawing.Size(152, 23);
            this.labelNamaPS.TabIndex = 18;
            this.labelNamaPS.Text = "Nama                  :";
            // 
            // panelTutupPS
            // 
            this.panelTutupPS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTutupPS.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelTutupPS.Location = new System.Drawing.Point(12, 328);
            this.panelTutupPS.Name = "panelTutupPS";
            this.panelTutupPS.Size = new System.Drawing.Size(875, 10);
            this.panelTutupPS.TabIndex = 16;
            // 
            // labelIDPSPS
            // 
            this.labelIDPSPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIDPSPS.AutoSize = true;
            this.labelIDPSPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDPSPS.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelIDPSPS.Location = new System.Drawing.Point(12, 354);
            this.labelIDPSPS.Name = "labelIDPSPS";
            this.labelIDPSPS.Size = new System.Drawing.Size(150, 23);
            this.labelIDPSPS.TabIndex = 19;
            this.labelIDPSPS.Text = "ID Peserta           :";
            // 
            // labelNTPS
            // 
            this.labelNTPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNTPS.AutoSize = true;
            this.labelNTPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNTPS.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelNTPS.Location = new System.Drawing.Point(11, 468);
            this.labelNTPS.Name = "labelNTPS";
            this.labelNTPS.Size = new System.Drawing.Size(150, 23);
            this.labelNTPS.TabIndex = 26;
            this.labelNTPS.Text = "No Telepon         :";
            // 
            // txtNTPS
            // 
            this.txtNTPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNTPS.Location = new System.Drawing.Point(184, 470);
            this.txtNTPS.Multiline = true;
            this.txtNTPS.Name = "txtNTPS";
            this.txtNTPS.Size = new System.Drawing.Size(226, 22);
            this.txtNTPS.TabIndex = 27;
            this.txtNTPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNTPS_KeyPress);
            // 
            // btnREADPS
            // 
            this.btnREADPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnREADPS.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnREADPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREADPS.ForeColor = System.Drawing.Color.White;
            this.btnREADPS.Location = new System.Drawing.Point(549, 398);
            this.btnREADPS.Name = "btnREADPS";
            this.btnREADPS.Size = new System.Drawing.Size(102, 44);
            this.btnREADPS.TabIndex = 28;
            this.btnREADPS.Text = "READ";
            this.btnREADPS.UseVisualStyleBackColor = false;
            this.btnREADPS.Click += new System.EventHandler(this.btnREADPS_Click);
            // 
            // btnUPDPS
            // 
            this.btnUPDPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUPDPS.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnUPDPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDPS.ForeColor = System.Drawing.Color.White;
            this.btnUPDPS.Location = new System.Drawing.Point(442, 448);
            this.btnUPDPS.Name = "btnUPDPS";
            this.btnUPDPS.Size = new System.Drawing.Size(102, 44);
            this.btnUPDPS.TabIndex = 29;
            this.btnUPDPS.Text = "UPDATE";
            this.btnUPDPS.UseVisualStyleBackColor = false;
            this.btnUPDPS.Click += new System.EventHandler(this.btnUPDPS_Click);
            // 
            // btnDELPS
            // 
            this.btnDELPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDELPS.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnDELPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELPS.ForeColor = System.Drawing.Color.White;
            this.btnDELPS.Location = new System.Drawing.Point(549, 448);
            this.btnDELPS.Name = "btnDELPS";
            this.btnDELPS.Size = new System.Drawing.Size(102, 44);
            this.btnDELPS.TabIndex = 30;
            this.btnDELPS.Text = "DELETE";
            this.btnDELPS.UseVisualStyleBackColor = false;
            this.btnDELPS.Click += new System.EventHandler(this.btnDELPS_Click);
            // 
            // btnSearchPS
            // 
            this.btnSearchPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPS.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearchPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPS.ForeColor = System.Drawing.Color.White;
            this.btnSearchPS.Location = new System.Drawing.Point(657, 398);
            this.btnSearchPS.Name = "btnSearchPS";
            this.btnSearchPS.Size = new System.Drawing.Size(102, 44);
            this.btnSearchPS.TabIndex = 31;
            this.btnSearchPS.Text = "SEARCH";
            this.btnSearchPS.UseVisualStyleBackColor = false;
            this.btnSearchPS.Click += new System.EventHandler(this.btnSearchPS_Click);
            // 
            // btnPrintPS
            // 
            this.btnPrintPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPS.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrintPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPS.ForeColor = System.Drawing.Color.White;
            this.btnPrintPS.Location = new System.Drawing.Point(765, 398);
            this.btnPrintPS.Name = "btnPrintPS";
            this.btnPrintPS.Size = new System.Drawing.Size(102, 44);
            this.btnPrintPS.TabIndex = 32;
            this.btnPrintPS.Text = "PRINT";
            this.btnPrintPS.UseVisualStyleBackColor = false;
            this.btnPrintPS.Click += new System.EventHandler(this.btnPrintPS_Click);
            // 
            // printPreviewDialogPS
            // 
            this.printPreviewDialogPS.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogPS.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogPS.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogPS.Enabled = true;
            this.printPreviewDialogPS.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogPS.Icon")));
            this.printPreviewDialogPS.Name = "printPreviewDialogPS";
            this.printPreviewDialogPS.Visible = false;
            // 
            // labelPPS
            // 
            this.labelPPS.AutoSize = true;
            this.labelPPS.Location = new System.Drawing.Point(1, 2);
            this.labelPPS.Name = "labelPPS";
            this.labelPPS.Size = new System.Drawing.Size(0, 16);
            this.labelPPS.TabIndex = 1;
            // 
            // labelCPS
            // 
            this.labelCPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCPS.AutoSize = true;
            this.labelCPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPS.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelCPS.Location = new System.Drawing.Point(11, 502);
            this.labelCPS.Name = "labelCPS";
            this.labelCPS.Size = new System.Drawing.Size(149, 23);
            this.labelCPS.TabIndex = 33;
            this.labelCPS.Text = "Cari Peserta        :";
            // 
            // txtCPS
            // 
            this.txtCPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCPS.Location = new System.Drawing.Point(184, 503);
            this.txtCPS.Multiline = true;
            this.txtCPS.Name = "txtCPS";
            this.txtCPS.Size = new System.Drawing.Size(226, 22);
            this.txtCPS.TabIndex = 34;
            // 
            // printDocumentPS
            // 
            this.printDocumentPS.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentPS_PrintPage);
            // 
            // Form_Peserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 543);
            this.Controls.Add(this.txtCPS);
            this.Controls.Add(this.labelCPS);
            this.Controls.Add(this.btnPrintPS);
            this.Controls.Add(this.btnSearchPS);
            this.Controls.Add(this.btnDELPS);
            this.Controls.Add(this.btnUPDPS);
            this.Controls.Add(this.btnREADPS);
            this.Controls.Add(this.txtNTPS);
            this.Controls.Add(this.labelNTPS);
            this.Controls.Add(this.labelIDPSPS);
            this.Controls.Add(this.panelJudulPS);
            this.Controls.Add(this.dataGridViewPS);
            this.Controls.Add(this.btnCCPS);
            this.Controls.Add(this.btnCLEARPS);
            this.Controls.Add(this.btnADDPS);
            this.Controls.Add(this.txtEMAILPS);
            this.Controls.Add(this.txtNAMAPS);
            this.Controls.Add(this.txtIDPSPS);
            this.Controls.Add(this.labelEmailPS);
            this.Controls.Add(this.labelNamaPS);
            this.Controls.Add(this.panelTutupPS);
            this.Name = "Form_Peserta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Peserta";
            this.Load += new System.EventHandler(this.Form_Peserta_Load);
            this.panelJudulPS.ResumeLayout(false);
            this.panelJudulPS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelJudulPS;
        private System.Windows.Forms.Label labelJudulPS;
        private System.Windows.Forms.DataGridView dataGridViewPS;
        private System.Windows.Forms.Button btnCCPS;
        private System.Windows.Forms.Button btnCLEARPS;
        private System.Windows.Forms.Button btnADDPS;
        private System.Windows.Forms.TextBox txtEMAILPS;
        private System.Windows.Forms.TextBox txtNAMAPS;
        private System.Windows.Forms.TextBox txtIDPSPS;
        private System.Windows.Forms.Label labelEmailPS;
        private System.Windows.Forms.Label labelNamaPS;
        private System.Windows.Forms.Panel panelTutupPS;
        private System.Windows.Forms.Label labelIDPSPS;
        private System.Windows.Forms.Label labelNTPS;
        private System.Windows.Forms.TextBox txtNTPS;
        private System.Windows.Forms.Button btnREADPS;
        private System.Windows.Forms.Button btnUPDPS;
        private System.Windows.Forms.Button btnDELPS;
        private System.Windows.Forms.Label labelPPS;
        private System.Windows.Forms.Button btnSearchPS;
        private System.Windows.Forms.Button btnPrintPS;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogPS;
        private System.Windows.Forms.Label labelCPS;
        private System.Windows.Forms.TextBox txtCPS;
        private System.Drawing.Printing.PrintDocument printDocumentPS;
    }
}