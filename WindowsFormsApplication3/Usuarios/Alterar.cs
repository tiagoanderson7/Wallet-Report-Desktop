using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace WindowsFormsApplication3.Usuarios
{
    public partial class Alterar : Form
    {
        public int Id { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public bool Admin { get; set; }

        public Alterar()
        {
            InitializeComponent();
        }

        public void Alterar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            UpdateUser();

            if (Application.OpenForms.OfType<ContaFuncionarios>().Count() > 0)
            {
                Application.OpenForms.OfType<ContaFuncionarios>().First().Close();
            }

            if (Application.OpenForms.OfType<ContaClientes>().Count() > 0)
            {
                Application.OpenForms.OfType<ContaClientes>().First().Close();
            }
        }

        private async void UpdateUser()
        {
            Alterar user = new Alterar();

            user.CPF = tbxCPF1.Text;
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

                string content1 = content.ReadAsStringAsync().Result;

                //Corrige erro de autenticação
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //

                HttpResponseMessage responseMessage = await client.PutAsync("https://localhost:5001/api/user/" + user.CPF, content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Alteração bem sucedida! " + responseMessage.StatusCode);
                }
                else
                {
                    MessageBox.Show("Não foi possível fazer a alteração! " + responseMessage.StatusCode);
                }
            }
        }
    }
}
