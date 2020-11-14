namespace WindowsFormsApplication3.DB
{
    partial class AlterarTable
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
            this.pnlCadTable = new System.Windows.Forms.Panel();
            this.tbxNovoNome = new System.Windows.Forms.MaskedTextBox();
            this.btnAltTable = new System.Windows.Forms.Button();
            this.lblNovoNome = new System.Windows.Forms.Label();
            this.tbxNameTable = new System.Windows.Forms.MaskedTextBox();
            this.lblNameTable = new System.Windows.Forms.Label();
            this.tbxNameDB = new System.Windows.Forms.MaskedTextBox();
            this.lblNameDB = new System.Windows.Forms.Label();
            this.pnlCadTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadTable
            // 
            this.pnlCadTable.Controls.Add(this.tbxNovoNome);
            this.pnlCadTable.Controls.Add(this.btnAltTable);
            this.pnlCadTable.Controls.Add(this.lblNovoNome);
            this.pnlCadTable.Controls.Add(this.tbxNameTable);
            this.pnlCadTable.Controls.Add(this.lblNameTable);
            this.pnlCadTable.Controls.Add(this.tbxNameDB);
            this.pnlCadTable.Controls.Add(this.lblNameDB);
            this.pnlCadTable.Location = new System.Drawing.Point(12, 12);
            this.pnlCadTable.Name = "pnlCadTable";
            this.pnlCadTable.Size = new System.Drawing.Size(776, 202);
            this.pnlCadTable.TabIndex = 4;
            // 
            // tbxNovoNome
            // 
            this.tbxNovoNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNovoNome.Location = new System.Drawing.Point(184, 96);
            this.tbxNovoNome.Name = "tbxNovoNome";
            this.tbxNovoNome.Size = new System.Drawing.Size(393, 25);
            this.tbxNovoNome.TabIndex = 12;
            // 
            // btnAltTable
            // 
            this.btnAltTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltTable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAltTable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltTable.Location = new System.Drawing.Point(495, 136);
            this.btnAltTable.Name = "btnAltTable";
            this.btnAltTable.Size = new System.Drawing.Size(82, 25);
            this.btnAltTable.TabIndex = 7;
            this.btnAltTable.Text = "Alterar";
            this.btnAltTable.UseVisualStyleBackColor = true;
            this.btnAltTable.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblNovoNome
            // 
            this.lblNovoNome.AutoSize = true;
            this.lblNovoNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoNome.Location = new System.Drawing.Point(17, 99);
            this.lblNovoNome.Name = "lblNovoNome";
            this.lblNovoNome.Size = new System.Drawing.Size(161, 18);
            this.lblNovoNome.TabIndex = 11;
            this.lblNovoNome.Text = "Novo nome da Tabela";
            // 
            // tbxNameTable
            // 
            this.tbxNameTable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameTable.Location = new System.Drawing.Point(139, 55);
            this.tbxNameTable.Name = "tbxNameTable";
            this.tbxNameTable.Size = new System.Drawing.Size(438, 25);
            this.tbxNameTable.TabIndex = 10;
            // 
            // lblNameTable
            // 
            this.lblNameTable.AutoSize = true;
            this.lblNameTable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTable.Location = new System.Drawing.Point(17, 58);
            this.lblNameTable.Name = "lblNameTable";
            this.lblNameTable.Size = new System.Drawing.Size(121, 18);
            this.lblNameTable.TabIndex = 9;
            this.lblNameTable.Text = "Nome da Tabela";
            // 
            // tbxNameDB
            // 
            this.tbxNameDB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameDB.Location = new System.Drawing.Point(139, 15);
            this.tbxNameDB.Name = "tbxNameDB";
            this.tbxNameDB.Size = new System.Drawing.Size(438, 25);
            this.tbxNameDB.TabIndex = 8;
            // 
            // lblNameDB
            // 
            this.lblNameDB.AutoSize = true;
            this.lblNameDB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDB.Location = new System.Drawing.Point(17, 18);
            this.lblNameDB.Name = "lblNameDB";
            this.lblNameDB.Size = new System.Drawing.Size(120, 18);
            this.lblNameDB.TabIndex = 7;
            this.lblNameDB.Text = "Nome do Banco";
            // 
            // AlterarTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCadTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "AlterarTable";
            this.Text = "Alterar nome da tabela";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlCadTable.ResumeLayout(false);
            this.pnlCadTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadTable;
        private System.Windows.Forms.MaskedTextBox tbxNovoNome;
        private System.Windows.Forms.Button btnAltTable;
        private System.Windows.Forms.Label lblNovoNome;
        private System.Windows.Forms.MaskedTextBox tbxNameTable;
        private System.Windows.Forms.Label lblNameTable;
        private System.Windows.Forms.MaskedTextBox tbxNameDB;
        private System.Windows.Forms.Label lblNameDB;
    }
}