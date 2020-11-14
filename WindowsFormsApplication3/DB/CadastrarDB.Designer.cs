namespace WindowsFormsApplication3
{
    partial class frmCadDB
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
            this.pnlCadDB = new System.Windows.Forms.Panel();
            this.btnCadDB = new System.Windows.Forms.Button();
            this.tbxCadDB = new System.Windows.Forms.MaskedTextBox();
            this.lblCadDB = new System.Windows.Forms.Label();
            this.pnlCadDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadDB
            // 
            this.pnlCadDB.Controls.Add(this.btnCadDB);
            this.pnlCadDB.Controls.Add(this.tbxCadDB);
            this.pnlCadDB.Controls.Add(this.lblCadDB);
            this.pnlCadDB.Location = new System.Drawing.Point(12, 12);
            this.pnlCadDB.Name = "pnlCadDB";
            this.pnlCadDB.Size = new System.Drawing.Size(646, 156);
            this.pnlCadDB.TabIndex = 2;
            // 
            // btnCadDB
            // 
            this.btnCadDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadDB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadDB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadDB.Location = new System.Drawing.Point(538, 15);
            this.btnCadDB.Name = "btnCadDB";
            this.btnCadDB.Size = new System.Drawing.Size(82, 25);
            this.btnCadDB.TabIndex = 7;
            this.btnCadDB.Text = "Cadastrar";
            this.btnCadDB.UseVisualStyleBackColor = true;
            this.btnCadDB.Click += new System.EventHandler(this.btnCadDB_Click);
            // 
            // tbxCadDB
            // 
            this.tbxCadDB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCadDB.Location = new System.Drawing.Point(139, 15);
            this.tbxCadDB.Name = "tbxCadDB";
            this.tbxCadDB.Size = new System.Drawing.Size(393, 25);
            this.tbxCadDB.TabIndex = 8;
            // 
            // lblCadDB
            // 
            this.lblCadDB.AutoSize = true;
            this.lblCadDB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadDB.Location = new System.Drawing.Point(17, 18);
            this.lblCadDB.Name = "lblCadDB";
            this.lblCadDB.Size = new System.Drawing.Size(120, 18);
            this.lblCadDB.TabIndex = 7;
            this.lblCadDB.Text = "Nome do Banco";
            // 
            // frmCadDB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(682, 326);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCadDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadDB";
            this.ShowIcon = false;
            this.Text = "Cadastrar Banco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarDB_Load);
            this.pnlCadDB.ResumeLayout(false);
            this.pnlCadDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadDB;
        private System.Windows.Forms.Button btnCadDB;
        private System.Windows.Forms.MaskedTextBox tbxCadDB;
        private System.Windows.Forms.Label lblCadDB;
    }
}