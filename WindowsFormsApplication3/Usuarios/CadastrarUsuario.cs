using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class CadastrarUsuarios : Form
    {
        public int Id { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public bool Admin { get; set; }

        public CadastrarUsuarios()
        {
            InitializeComponent();
        }

        private void CadastrarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private async void AddUser()
        {
            CadastrarUsuarios user = new CadastrarUsuarios();

            user.CPF = tbxCPF.Text;
            user.Nome = tbxNome.Text;
            user.Senha = tbxSenha.Text;
            user.Email = tbxEmail.Text;

            if (cbxAdmin.Text == "Admin")
            {
                user.Admin = true;
            }
            else
            {
                user.Admin = false;
            }
            

            using (var client = new HttpClient())
            {
                //Serializa e corrige erro de referência circular
                var serializedUser = JsonConvert.SerializeObject(user, Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    }
                );

                var content = new StringContent(serializedUser, Encoding.UTF8, "application/json");
                //

                //Corrige erro de autenticação
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //

                var result = await client.PostAsync("https://localhost:5001/api/user/", content);
            }
            MessageBox.Show("Usuário inserido com sucesso!");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AddUser();

            if (Application.OpenForms.OfType<ContaFuncionarios>().Count() > 0)
            {
                Application.OpenForms.OfType<ContaFuncionarios>().First().Close();
            }

            if (Application.OpenForms.OfType<ContaClientes>().Count() > 0)
            {
                Application.OpenForms.OfType<ContaClientes>().First().Close();
            }
        }
    }
}
