using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.DB;
using WindowsFormsApplication3.Usuarios;

namespace WindowsFormsApplication3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
         private void Home_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moedasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadFun = new CadastrarUsuarios();
            cadFun.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<CadastrarUsuarios>().Count() > 0)
            {
                Application.OpenForms.OfType<CadastrarUsuarios>().First().Focus();
            }
            else
            {
                cadFun.Show();
            }

        }
        
        private void statusBar2_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadMoeda = new CadastrarMoeda();
            cadMoeda.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<CadastrarMoeda>().Count() > 0)
            {
                Application.OpenForms.OfType<CadastrarMoeda>().First().Focus();
            }
            else
            {
                cadMoeda.Show();
            }
        }

        public void clientesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var contaCliente = new ContaClientes();
            contaCliente.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<ContaClientes>().Count() > 0)
            {
                Application.OpenForms.OfType<ContaClientes>().First().Focus();
            }
            else
            {
                contaCliente.Show();
            }
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contaFun = new ContaFuncionarios();
            contaFun.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<ContaFuncionarios>().Count() > 0)
            {
                Application.OpenForms.OfType<ContaFuncionarios>().First().Focus();
            }
            else
            {
                contaFun.Show();
            }
        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var moeda = new frmMOEDA();
            moeda.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<frmMOEDA>().Count() > 0)
            {
                Application.OpenForms.OfType<frmMOEDA>().First().Focus();
            }
            else
            {
                moeda.Show();
            }
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AllDB = new frmDB();
            AllDB.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<frmDB>().Count() > 0)
            {
                Application.OpenForms.OfType<frmDB>().First().Focus();
            }
            else
            {
                AllDB.Show();
            }

        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadDB = new frmCadDB();
            cadDB.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<frmCadDB>().Count() > 0)
            {
                Application.OpenForms.OfType<frmCadDB>().First().Focus();
            }
            else
            {
                cadDB.Show();
            }
        }

        private void consultaIndividualPorCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conCPF = new ConsultarCPF();
            conCPF.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<ConsultarCPF>().Count() > 0)
            {
                Application.OpenForms.OfType<ConsultarCPF>().First().Focus();
            }
            else
            {
                conCPF.Show();
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Alt = new Alterar();
            Alt.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<Alterar>().Count() > 0)
            {
                Application.OpenForms.OfType<Alterar>().First().Focus();
            }
            else
            {
                Alt.Show();
            }
        }

        private void todasAsTabelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AllTB = new AllTables();
            AllTB.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<AllTables>().Count() > 0)
            {
                Application.OpenForms.OfType<AllTables>().First().Focus();
            }
            else
            {
                AllTB.Show();
            }
        }

        private void criarTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CadTB = new CadastrarTables();
            CadTB.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<CadastrarTables>().Count() > 0)
            {
                Application.OpenForms.OfType<CadastrarTables>().First().Focus();
            }
            else
            {
                CadTB.Show();
            }
        }

        private void alterarTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AllTB = new AlterarTable();
            AllTB.MdiParent = this;
            // o if verifica se o form ja foi aberto assim nao criando mais de um ao mesmo tempo
            if (Application.OpenForms.OfType<AlterarTable>().Count() > 0)
            {
                Application.OpenForms.OfType<AlterarTable>().First().Focus();
            }
            else
            {
                AllTB.Show();
            }
        }
    }
}