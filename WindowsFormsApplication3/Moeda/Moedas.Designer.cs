namespace WindowsFormsApplication3
{
    partial class frmMOEDA
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
            this.gridMOEDA = new System.Windows.Forms.DataGridView();
            this.pnlConsultarMOEDA = new System.Windows.Forms.Panel();
            this.tbxMOEDA = new System.Windows.Forms.TextBox();
            this.lblMOEDA = new System.Windows.Forms.Label();
            this.btnBuscarMOEDA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMOEDA)).BeginInit();
            this.pnlConsultarMOEDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMOEDA
            // 
            this.gridMOEDA.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridMOEDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMOEDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMOEDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMOEDA.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridMOEDA.Location = new System.Drawing.Point(0, 58);
            this.gridMOEDA.Name = "gridMOEDA";
            this.gridMOEDA.Size = new System.Drawing.Size(804, 383);
            this.gridMOEDA.TabIndex = 3;
            // 
            // pnlConsultarMOEDA
            // 
            this.pnlConsultarMOEDA.Controls.Add(this.tbxMOEDA);
            this.pnlConsultarMOEDA.Controls.Add(this.lblMOEDA);
            this.pnlConsultarMOEDA.Controls.Add(this.btnBuscarMOEDA);
            this.pnlConsultarMOEDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsultarMOEDA.Location = new System.Drawing.Point(0, 0);
            this.pnlConsultarMOEDA.Name = "pnlConsultarMOEDA";
            this.pnlConsultarMOEDA.Size = new System.Drawing.Size(804, 58);
            this.pnlConsultarMOEDA.TabIndex = 2;
            // 
            // tbxMOEDA
            // 
            this.tbxMOEDA.Location = new System.Drawing.Point(59, 9);
            this.tbxMOEDA.Name = "tbxMOEDA";
            this.tbxMOEDA.Size = new System.Drawing.Size(175, 20);
            this.tbxMOEDA.TabIndex = 2;
            // 
            // lblMOEDA
            // 
            this.lblMOEDA.AutoSize = true;
            this.lblMOEDA.Location = new System.Drawing.Point(15, 12);
            this.lblMOEDA.Name = "lblMOEDA";
            this.lblMOEDA.Size = new System.Drawing.Size(40, 13);
            this.lblMOEDA.TabIndex = 1;
            this.lblMOEDA.Text = "Moeda";
            // 
            // btnBuscarMOEDA
            // 
            this.btnBuscarMOEDA.Location = new System.Drawing.Point(240, 7);
            this.btnBuscarMOEDA.Name = "btnBuscarMOEDA";
            this.btnBuscarMOEDA.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMOEDA.TabIndex = 0;
            this.btnBuscarMOEDA.Text = "Buscar";
            this.btnBuscarMOEDA.UseVisualStyleBackColor = true;
            this.btnBuscarMOEDA.Click += new System.EventHandler(this.btnBuscarMOEDA_Click);
            // 
            // frmMOEDA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.ControlBox = false;
            this.Controls.Add(this.gridMOEDA);
            this.Controls.Add(this.pnlConsultarMOEDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMOEDA";
            this.ShowIcon = false;
            this.Text = "Consultar Moeda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Moedas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMOEDA)).EndInit();
            this.pnlConsultarMOEDA.ResumeLayout(false);
            this.pnlConsultarMOEDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMOEDA;
        private System.Windows.Forms.Panel pnlConsultarMOEDA;
        private System.Windows.Forms.TextBox tbxMOEDA;
        private System.Windows.Forms.Label lblMOEDA;
        private System.Windows.Forms.Button btnBuscarMOEDA;
    }
}