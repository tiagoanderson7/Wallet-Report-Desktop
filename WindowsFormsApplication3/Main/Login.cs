using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace WindowsFormsApplication3
{
    public partial class Login : Form
    {
        public string CPF { get; set; }
        public string Senha { get; set; }

        Thread nt;

        public Login()
        {
            InitializeComponent();
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string CPF = tbxCPF.Text;
            string Senha = tbxSenha.Text;
            LoginValidation(CPF, Senha);
        }

        public async void LoginValidation(string CPF, string Senha)
        {
            using (var user = new HttpClient())
            {
                //Corrige erro de autenticação
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //
                using (var response = await user.GetAsync("https://localhost:5001/api/user/login/" + CPF + "/" + Senha))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var UsersJsonString = await response.Content.ReadAsStringAsync();

                        if (UsersJsonString.Contains(CPF) && UsersJsonString.Contains(Senha) && UsersJsonString.Contains("true"))
                        {
                            this.Close();
                            nt = new Thread(novoHome);
                            nt.SetApartmentState(ApartmentState.STA);
                            nt.Start();
                        }else
                        {
                            MessageBox.Show("CPF ou Senha inválidos ou o Usuário não tem os previlégios de acesso necessários");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível logar : " + response.StatusCode);
                    }
                }
            }
        }

        private void novoHome()
        {
            Application.Run(new Home());
        }
    }
}