namespace WindowsFormsApplication3
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaIndividualPorCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasAsTabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarTabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarTabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.moedasToolStripMenuItem,
            this.bancoDeDadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Checked = true;
            this.clientesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.alterarToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.clientesToolStripMenuItem.Text = "Usuários";
            this.clientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.funcionariosToolStripMenuItem,
            this.consultaIndividualPorCPFToolStripMenuItem});
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.contasToolStripMenuItem.Text = "Consultar";
            this.contasToolStripMenuItem.Click += new System.EventHandler(this.contasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(254, 22);
            this.clientesToolStripMenuItem1.Text = "Mostrar todos os clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click_1);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.funcionariosToolStripMenuItem.Text = "Mostrar todos os funcionários";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // consultaIndividualPorCPFToolStripMenuItem
            // 
            this.consultaIndividualPorCPFToolStripMenuItem.Name = "consultaIndividualPorCPFToolStripMenuItem";
            this.consultaIndividualPorCPFToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.consultaIndividualPorCPFToolStripMenuItem.Text = "Consulta individual por CPF";
            this.consultaIndividualPorCPFToolStripMenuItem.Click += new System.EventHandler(this.consultaIndividualPorCPFToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // moedasToolStripMenuItem
            // 
            this.moedasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.moedasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedasToolStripMenuItem.Name = "moedasToolStripMenuItem";
            this.moedasToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.moedasToolStripMenuItem.Text = "Moedas";
            this.moedasToolStripMenuItem.Click += new System.EventHandler(this.moedasToolStripMenuItem_Click);
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dadosToolStripMenuItem.Text = "Consultar";
            this.dadosToolStripMenuItem.Click += new System.EventHandler(this.dadosToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cadastroToolStripMenuItem.Text = "Atualizar";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodosToolStripMenuItem,
            this.criarToolStripMenuItem,
            this.todasAsTabelasToolStripMenuItem,
            this.criarTabelaToolStripMenuItem,
            this.alterarTabelaToolStripMenuItem});
            this.bancoDeDadosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // mostrarTodosToolStripMenuItem
            // 
            this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mostrarTodosToolStripMenuItem.Text = "Todos os bancos";
            this.mostrarTodosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosToolStripMenuItem_Click);
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.criarToolStripMenuItem.Text = "Criar banco";
            this.criarToolStripMenuItem.Click += new System.EventHandler(this.criarToolStripMenuItem_Click);
            // 
            // todasAsTabelasToolStripMenuItem
            // 
            this.todasAsTabelasToolStripMenuItem.Name = "todasAsTabelasToolStripMenuItem";
            this.todasAsTabelasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.todasAsTabelasToolStripMenuItem.Text = "Todas as tabelas";
            this.todasAsTabelasToolStripMenuItem.Click += new System.EventHandler(this.todasAsTabelasToolStripMenuItem_Click);
            // 
            // criarTabelaToolStripMenuItem
            // 
            this.criarTabelaToolStripMenuItem.Name = "criarTabelaToolStripMenuItem";
            this.criarTabelaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.criarTabelaToolStripMenuItem.Text = "Criar tabela";
            this.criarTabelaToolStripMenuItem.Click += new System.EventHandler(this.criarTabelaToolStripMenuItem_Click);
            // 
            // alterarTabelaToolStripMenuItem
            // 
            this.alterarTabelaToolStripMenuItem.Name = "alterarTabelaToolStripMenuItem";
            this.alterarTabelaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.alterarTabelaToolStripMenuItem.Text = "Alterar tabela";
            this.alterarTabelaToolStripMenuItem.Click += new System.EventHandler(this.alterarTabelaToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // moedaToolStripMenuItem
            // 
            this.moedaToolStripMenuItem.Name = "moedaToolStripMenuItem";
            this.moedaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.moedaToolStripMenuItem.Text = "Moeda";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 470);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallet Report Admin";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MdiChildActivate += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaIndividualPorCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasAsTabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarTabelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarTabelaToolStripMenuItem;
    }
}