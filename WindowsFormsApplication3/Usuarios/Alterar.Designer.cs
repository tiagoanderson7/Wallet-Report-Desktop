namespace WindowsFormsApplication3.Usuarios
{
    partial class Alterar
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
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.MaskedTextBox();
            this.cbxAdmin = new System.Windows.Forms.ComboBox();
            this.tbxNome = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxCPF1 = new System.Windows.Forms.MaskedTextBox();
            this.pnlAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAlt
            // 
            this.pnlAlt.AutoSize = true;
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlAlt.Controls.Add(this.label2);
            this.pnlAlt.Controls.Add(this.tbxEmail);
            this.pnlAlt.Controls.Add(this.label1);
            this.pnlAlt.Controls.Add(this.tbxSenha);
            this.pnlAlt.Controls.Add(this.cbxAdmin);
            this.pnlAlt.Controls.Add(this.tbxNome);
            this.pnlAlt.Controls.Add(this.label7);
            this.pnlAlt.Controls.Add(this.label12);
            this.pnlAlt.Controls.Add(this.btnAlterar);
            this.pnlAlt.Controls.Add(this.label11);
            this.pnlAlt.Controls.Add(this.tbxCPF1);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlt.Location = new System.Drawing.Point(0, 0);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Padding = new System.Windows.Forms.Padding(3);
            this.pnlAlt.Size = new System.Drawing.Size(800, 450);
            this.pnlAlt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(77, 121);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(235, 25);
            this.tbxEmail.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Senha";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.Location = new System.Drawing.Point(77, 90);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(235, 25);
            this.tbxSenha.TabIndex = 26;
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAdmin.FormattingEnabled = true;
            this.cbxAdmin.Items.AddRange(new object[] {
            "Cliente",
            "Admin"});
            this.cbxAdmin.Location = new System.Drawing.Point(77, 152);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(122, 25);
            this.cbxAdmin.TabIndex = 24;
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.Location = new System.Drawing.Point(77, 28);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(235, 25);
            this.tbxNome.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cargo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Nome";
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoEllipsis = true;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(77, 209);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(235, 30);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "CPF";
            // 
            // tbxCPF1
            // 
            this.tbxCPF1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCPF1.Location = new System.Drawing.Point(77, 59);
            this.tbxCPF1.Name = "tbxCPF1";
            this.tbxCPF1.Size = new System.Drawing.Size(235, 25);
            this.tbxCPF1.TabIndex = 18;
            // 
            // Alterar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAlt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Alterar";
            this.Text = "Alterar Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Alterar_Load);
            this.pnlAlt.ResumeLayout(false);
            this.pnlAlt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbxSenha;
        private System.Windows.Forms.ComboBox cbxAdmin;
        private System.Windows.Forms.MaskedTextBox tbxNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox tbxCPF1;
    }
}