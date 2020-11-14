namespace WindowsFormsApplication3
{
    partial class CadastrarMoeda
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
            this.pnlCMOEDA = new System.Windows.Forms.Panel();
            this.btnCMOEDA = new System.Windows.Forms.Button();
            this.tbxCMOEDA = new System.Windows.Forms.MaskedTextBox();
            this.lblCMOEDA = new System.Windows.Forms.Label();
            this.pnlCMOEDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCMOEDA
            // 
            this.pnlCMOEDA.Controls.Add(this.btnCMOEDA);
            this.pnlCMOEDA.Controls.Add(this.tbxCMOEDA);
            this.pnlCMOEDA.Controls.Add(this.lblCMOEDA);
            this.pnlCMOEDA.Location = new System.Drawing.Point(12, 12);
            this.pnlCMOEDA.Name = "pnlCMOEDA";
            this.pnlCMOEDA.Size = new System.Drawing.Size(646, 156);
            this.pnlCMOEDA.TabIndex = 2;
            // 
            // btnCMOEDA
            // 
            this.btnCMOEDA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCMOEDA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCMOEDA.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCMOEDA.Location = new System.Drawing.Point(163, 15);
            this.btnCMOEDA.Name = "btnCMOEDA";
            this.btnCMOEDA.Size = new System.Drawing.Size(82, 25);
            this.btnCMOEDA.TabIndex = 7;
            this.btnCMOEDA.Text = "Cadastrar";
            this.btnCMOEDA.UseVisualStyleBackColor = true;
            this.btnCMOEDA.Click += new System.EventHandler(this.btnBuscarMOEDA_Click);
            // 
            // tbxCMOEDA
            // 
            this.tbxCMOEDA.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCMOEDA.Location = new System.Drawing.Point(74, 15);
            this.tbxCMOEDA.Name = "tbxCMOEDA";
            this.tbxCMOEDA.Size = new System.Drawing.Size(83, 25);
            this.tbxCMOEDA.TabIndex = 8;
            // 
            // lblCMOEDA
            // 
            this.lblCMOEDA.AutoSize = true;
            this.lblCMOEDA.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMOEDA.Location = new System.Drawing.Point(17, 18);
            this.lblCMOEDA.Name = "lblCMOEDA";
            this.lblCMOEDA.Size = new System.Drawing.Size(56, 18);
            this.lblCMOEDA.TabIndex = 7;
            this.lblCMOEDA.Text = "Moeda";
            // 
            // CadastrarMoeda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(662, 347);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCMOEDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastrarMoeda";
            this.ShowIcon = false;
            this.Text = "Atualizar Moeda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarMoeda_Load);
            this.pnlCMOEDA.ResumeLayout(false);
            this.pnlCMOEDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCMOEDA;
        private System.Windows.Forms.Button btnCMOEDA;
        private System.Windows.Forms.MaskedTextBox tbxCMOEDA;
        private System.Windows.Forms.Label lblCMOEDA;
    }
}