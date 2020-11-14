namespace WindowsFormsApplication3
{
    partial class ContaFuncionarios
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
            this.gridFunc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFunc
            // 
            this.gridFunc.AllowUserToAddRows = false;
            this.gridFunc.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFunc.Location = new System.Drawing.Point(0, 0);
            this.gridFunc.MultiSelect = false;
            this.gridFunc.Name = "gridFunc";
            this.gridFunc.ReadOnly = true;
            this.gridFunc.Size = new System.Drawing.Size(705, 385);
            this.gridFunc.TabIndex = 1;
            this.gridFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnDelete_CellClick);
            // 
            // ContaFuncionarios
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(705, 385);
            this.Controls.Add(this.gridFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "ContaFuncionarios";
            this.Text = "Funcionários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ContaFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridFunc;
    }
}