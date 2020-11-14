namespace WindowsFormsApplication3.DB
{
    partial class AllTables
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
            this.gridTables = new System.Windows.Forms.DataGridView();
            this.pnlConsultarTables = new System.Windows.Forms.Panel();
            this.tbxAllTables = new System.Windows.Forms.TextBox();
            this.lblAllTables = new System.Windows.Forms.Label();
            this.btnBuscarTables = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTables)).BeginInit();
            this.pnlConsultarTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTables
            // 
            this.gridTables.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTables.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridTables.Location = new System.Drawing.Point(0, 58);
            this.gridTables.Name = "gridTables";
            this.gridTables.Size = new System.Drawing.Size(721, 392);
            this.gridTables.TabIndex = 3;
            this.gridTables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnDelete_CellClick);
            // 
            // pnlConsultarTables
            // 
            this.pnlConsultarTables.Controls.Add(this.tbxAllTables);
            this.pnlConsultarTables.Controls.Add(this.lblAllTables);
            this.pnlConsultarTables.Controls.Add(this.btnBuscarTables);
            this.pnlConsultarTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsultarTables.Location = new System.Drawing.Point(0, 0);
            this.pnlConsultarTables.Name = "pnlConsultarTables";
            this.pnlConsultarTables.Size = new System.Drawing.Size(721, 58);
            this.pnlConsultarTables.TabIndex = 2;
            // 
            // tbxAllTables
            // 
            this.tbxAllTables.Location = new System.Drawing.Point(108, 9);
            this.tbxAllTables.Name = "tbxAllTables";
            this.tbxAllTables.Size = new System.Drawing.Size(315, 20);
            this.tbxAllTables.TabIndex = 2;
            // 
            // lblAllTables
            // 
            this.lblAllTables.AutoSize = true;
            this.lblAllTables.Location = new System.Drawing.Point(15, 12);
            this.lblAllTables.Name = "lblAllTables";
            this.lblAllTables.Size = new System.Drawing.Size(87, 13);
            this.lblAllTables.TabIndex = 1;
            this.lblAllTables.Text = "Banco de Dados";
            // 
            // btnBuscarTables
            // 
            this.btnBuscarTables.Location = new System.Drawing.Point(429, 7);
            this.btnBuscarTables.Name = "btnBuscarTables";
            this.btnBuscarTables.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTables.TabIndex = 0;
            this.btnBuscarTables.Text = "Buscar";
            this.btnBuscarTables.UseVisualStyleBackColor = true;
            this.btnBuscarTables.Click += new System.EventHandler(this.btnBuscarTables_Click);
            // 
            // AllTables
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.gridTables);
            this.Controls.Add(this.pnlConsultarTables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "AllTables";
            this.Text = "Todas as tabelas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTables)).EndInit();
            this.pnlConsultarTables.ResumeLayout(false);
            this.pnlConsultarTables.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTables;
        private System.Windows.Forms.Panel pnlConsultarTables;
        private System.Windows.Forms.TextBox tbxAllTables;
        private System.Windows.Forms.Label lblAllTables;
        private System.Windows.Forms.Button btnBuscarTables;
    }
}