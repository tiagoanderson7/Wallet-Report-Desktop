namespace WindowsFormsApplication3
{
    partial class frmDB
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
            this.gridDB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridDB)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDB
            // 
            this.gridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDB.Location = new System.Drawing.Point(0, 0);
            this.gridDB.Name = "gridDB";
            this.gridDB.Size = new System.Drawing.Size(803, 430);
            this.gridDB.TabIndex = 0;
            this.gridDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnDelete_CellClick);
            // 
            // frmDB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(803, 430);
            this.ControlBox = false;
            this.Controls.Add(this.gridDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDB";
            this.ShowIcon = false;
            this.Text = "Todos os Bancos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDB;
    }
}