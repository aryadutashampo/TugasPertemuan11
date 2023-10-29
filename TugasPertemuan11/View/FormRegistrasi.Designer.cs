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
            this.dataGridViewREG = new System.Windows.Forms.DataGridView();
            this.panelJudulreg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelREGID = new System.Windows.Forms.Label();
            this.labelREGIDP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDREG = new System.Windows.Forms.TextBox();
            this.txtIDPSREG = new System.Windows.Forms.TextBox();
            this.txtIDPLREG = new System.Windows.Forms.TextBox();
            this.btnADDREG = new System.Windows.Forms.Button();
            this.btnCLEARREG = new System.Windows.Forms.Button();
            this.btnCCREG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewREG)).BeginInit();
            this.panelJudulreg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewREG
            // 
            this.dataGridViewREG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewREG.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewREG.Name = "dataGridViewREG";
            this.dataGridViewREG.RowHeadersWidth = 51;
            this.dataGridViewREG.RowTemplate.Height = 24;
            this.dataGridViewREG.Size = new System.Drawing.Size(614, 271);
            this.dataGridViewREG.TabIndex = 0;
            // 
            // panelJudulreg
            // 
            this.panelJudulreg.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelJudulreg.Controls.Add(this.label1);
            this.panelJudulreg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJudulreg.Location = new System.Drawing.Point(0, 0);
            this.panelJudulreg.Name = "panelJudulreg";
            this.panelJudulreg.Size = new System.Drawing.Size(637, 57);
            this.panelJudulreg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrasi Pelatihan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Location = new System.Drawing.Point(12, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 10);
            this.panel1.TabIndex = 2;
            // 
            // labelREGID
            // 
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
            this.labelREGIDP.AutoSize = true;
            this.labelREGIDP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelREGIDP.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelREGIDP.Location = new System.Drawing.Point(12, 391);
            this.labelREGIDP.Name = "labelREGIDP";
            this.labelREGIDP.Size = new System.Drawing.Size(150, 23);
            this.labelREGIDP.TabIndex = 4;
            this.labelREGIDP.Text = "ID Peserta           :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(12, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Pelatihan        :";
            // 
            // txtIDREG
            // 
            this.txtIDREG.Location = new System.Drawing.Point(184, 357);
            this.txtIDREG.Multiline = true;
            this.txtIDREG.Name = "txtIDREG";
            this.txtIDREG.Size = new System.Drawing.Size(226, 22);
            this.txtIDREG.TabIndex = 6;
            this.txtIDREG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDREG_KeyPress);
            // 
            // txtIDPSREG
            // 
            this.txtIDPSREG.Location = new System.Drawing.Point(184, 393);
            this.txtIDPSREG.Multiline = true;
            this.txtIDPSREG.Name = "txtIDPSREG";
            this.txtIDPSREG.Size = new System.Drawing.Size(226, 22);
            this.txtIDPSREG.TabIndex = 7;
            this.txtIDPSREG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPSREG_KeyPress);
            // 
            // txtIDPLREG
            // 
            this.txtIDPLREG.Location = new System.Drawing.Point(184, 432);
            this.txtIDPLREG.Multiline = true;
            this.txtIDPLREG.Name = "txtIDPLREG";
            this.txtIDPLREG.Size = new System.Drawing.Size(226, 22);
            this.txtIDPLREG.TabIndex = 8;
            this.txtIDPLREG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPLREG_KeyPress);
            // 
            // btnADDREG
            // 
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
            // Form_Registrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 462);
            this.Controls.Add(this.btnCCREG);
            this.Controls.Add(this.btnCLEARREG);
            this.Controls.Add(this.btnADDREG);
            this.Controls.Add(this.txtIDPLREG);
            this.Controls.Add(this.txtIDPSREG);
            this.Controls.Add(this.txtIDREG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelREGIDP);
            this.Controls.Add(this.labelREGID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelJudulreg);
            this.Controls.Add(this.dataGridViewREG);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelREGID;
        private System.Windows.Forms.Label labelREGIDP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDREG;
        private System.Windows.Forms.TextBox txtIDPSREG;
        private System.Windows.Forms.TextBox txtIDPLREG;
        private System.Windows.Forms.Button btnADDREG;
        private System.Windows.Forms.Button btnCLEARREG;
        private System.Windows.Forms.Button btnCCREG;
    }
}