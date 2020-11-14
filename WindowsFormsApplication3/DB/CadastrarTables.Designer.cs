namespace WindowsFormsApplication3.DB
{
    partial class CadastrarTables
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
            this.tbxNameTable = new System.Windows.Forms.MaskedTextBox();
            this.lblNameTable = new System.Windows.Forms.Label();
            this.btnCadTable = new System.Windows.Forms.Button();
            this.tbxNameDB = new System.Windows.Forms.MaskedTextBox();
            this.lblNameDB = new System.Windows.Forms.Label();
            this.cbxTipoTable = new System.Windows.Forms.ComboBox();
            this.lblTipoTable = new System.Windows.Forms.Label();
            this.pnlCadTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadTable
            // 
            this.pnlCadTable.Controls.Add(this.lblTipoTable);
            this.pnlCadTable.Controls.Add(this.cbxTipoTable);
            this.pnlCadTable.Controls.Add(this.tbxNameTable);
            this.pnlCadTable.Controls.Add(this.lblNameTable);
            this.pnlCadTable.Controls.Add(this.btnCadTable);
            this.pnlCadTable.Controls.Add(this.tbxNameDB);
            this.pnlCadTable.Controls.Add(this.lblNameDB);
            this.pnlCadTable.Location = new System.Drawing.Point(12, 12);
            this.pnlCadTable.Name = "pnlCadTable";
            this.pnlCadTable.Size = new System.Drawing.Size(733, 156);
            this.pnlCadTable.TabIndex = 3;
            // 
            // tbxNameTable
            // 
            this.tbxNameTable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameTable.Location = new System.Drawing.Point(139, 55);
            this.tbxNameTable.Name = "tbxNameTable";
            this.tbxNameTable.Size = new System.Drawing.Size(393, 25);
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
            // btnCadTable
            // 
            this.btnCadTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadTable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadTable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadTable.Location = new System.Drawing.Point(450, 95);
            this.btnCadTable.Name = "btnCadTable";
            this.btnCadTable.Size = new System.Drawing.Size(82, 25);
            this.btnCadTable.TabIndex = 7;
            this.btnCadTable.Text = "Cadastrar";
            this.btnCadTable.UseVisualStyleBackColor = true;
            this.btnCadTable.Click += new System.EventHandler(this.btnCadTB_Click);
            // 
            // tbxNameDB
            // 
            this.tbxNameDB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameDB.Location = new System.Drawing.Point(139, 15);
            this.tbxNameDB.Name = "tbxNameDB";
            this.tbxNameDB.Size = new System.Drawing.Size(393, 25);
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
            // cbxTipoTable
            // 
            this.cbxTipoTable.FormattingEnabled = true;
            this.cbxTipoTable.Items.AddRange(new object[] {
            "Moeda",
            "Usuário"});
            this.cbxTipoTable.Location = new System.Drawing.Point(139, 99);
            this.cbxTipoTable.Name = "cbxTipoTable";
            this.cbxTipoTable.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoTable.TabIndex = 11;
            // 
            // lblTipoTable
            // 
            this.lblTipoTable.AutoSize = true;
            this.lblTipoTable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTable.Location = new System.Drawing.Point(17, 99);
            this.lblTipoTable.Name = "lblTipoTable";
            this.lblTipoTable.Size = new System.Drawing.Size(112, 18);
            this.lblTipoTable.TabIndex = 12;
            this.lblTipoTable.Text = "Tipo da Tabela";
            // 
            // CadastrarTables
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.pnlCadTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "CadastrarTables";
            this.Text = "Cadastrar Tabela";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlCadTable.ResumeLayout(false);
            this.pnlCadTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadTable;
        private System.Windows.Forms.Button btnCadTable;
        private System.Windows.Forms.MaskedTextBox tbxNameDB;
        private System.Windows.Forms.Label lblNameDB;
        private System.Windows.Forms.MaskedTextBox tbxNameTable;
        private System.Windows.Forms.Label lblNameTable;
        private System.Windows.Forms.Label lblTipoTable;
        private System.Windows.Forms.ComboBox cbxTipoTable;
    }
}