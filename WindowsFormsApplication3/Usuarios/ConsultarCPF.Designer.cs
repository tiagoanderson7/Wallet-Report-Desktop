namespace WindowsFormsApplication3.Usuarios
{
    partial class ConsultarCPF
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
            this.pnlConsultarCPF = new System.Windows.Forms.Panel();
            this.tbxCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnBuscarCPF = new System.Windows.Forms.Button();
            this.gridCPF = new System.Windows.Forms.DataGridView();
            this.pnlConsultarCPF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCPF)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConsultarCPF
            // 
            this.pnlConsultarCPF.Controls.Add(this.tbxCPF);
            this.pnlConsultarCPF.Controls.Add(this.lblCPF);
            this.pnlConsultarCPF.Controls.Add(this.btnBuscarCPF);
            this.pnlConsultarCPF.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsultarCPF.Location = new System.Drawing.Point(0, 0);
            this.pnlConsultarCPF.Name = "pnlConsultarCPF";
            this.pnlConsultarCPF.Size = new System.Drawing.Size(800, 58);
            this.pnlConsultarCPF.TabIndex = 0;
            // 
            // tbxCPF
            // 
            this.tbxCPF.Location = new System.Drawing.Point(48, 9);
            this.tbxCPF.Name = "tbxCPF";
            this.tbxCPF.Size = new System.Drawing.Size(175, 20);
            this.tbxCPF.TabIndex = 2;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(15, 12);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // btnBuscarCPF
            // 
            this.btnBuscarCPF.Location = new System.Drawing.Point(229, 7);
            this.btnBuscarCPF.Name = "btnBuscarCPF";
            this.btnBuscarCPF.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCPF.TabIndex = 0;
            this.btnBuscarCPF.Text = "Buscar";
            this.btnBuscarCPF.UseVisualStyleBackColor = true;
            this.btnBuscarCPF.Click += new System.EventHandler(this.btnBuscarCPF_Click);
            // 
            // gridCPF
            // 
            this.gridCPF.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCPF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCPF.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridCPF.Location = new System.Drawing.Point(0, 58);
            this.gridCPF.Name = "gridCPF";
            this.gridCPF.Size = new System.Drawing.Size(800, 392);
            this.gridCPF.TabIndex = 1;
            this.gridCPF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnDelete_CellClick);
            // 
            // ConsultarCPF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridCPF);
            this.Controls.Add(this.pnlConsultarCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "ConsultarCPF";
            this.Text = "Consulta Individual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultarCPF_Load);
            this.pnlConsultarCPF.ResumeLayout(false);
            this.pnlConsultarCPF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCPF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsultarCPF;
        private System.Windows.Forms.TextBox tbxCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnBuscarCPF;
        private System.Windows.Forms.DataGridView gridCPF;
    }
}