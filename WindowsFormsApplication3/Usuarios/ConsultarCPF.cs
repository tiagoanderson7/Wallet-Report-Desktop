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

namespace WindowsFormsApplication3.Usuarios
{
    public partial class ConsultarCPF : Form
    {
        public int Id { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public bool Admin { get; set; }

        public ConsultarCPF()
        {
            InitializeComponent();
        }

        public void ConsultarCPF_Load(object sender, EventArgs e)
        {
            
        }

        public async void GetUser(string CPF)
        {
            using (var user = new HttpClient())
            {
                //Corrige erro de autenticação
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //
                using (var response = await user.GetAsync("https://localhost:5001/api/user/" + CPF))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var UsersJsonString = await response.Content.ReadAsStringAsync();
                        gridCPF.DataSource = 0;
                        gridCPF.Columns.Clear();
                        gridCPF.Refresh();

                        gridCPF.DataSource = JsonConvert.DeserializeObject<ConsultarCPF[]>(UsersJsonString).ToList();
                        gridCPF.Update();
                        gridCPF.Refresh();

                        //Criao o botão delete
                        DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                        uninstallButtonColumn.UseColumnTextForButtonValue = true;
                        uninstallButtonColumn.HeaderText = "Delete";
                        uninstallButtonColumn.Name = "Delete";
                        uninstallButtonColumn.Text = "Delete";
                        gridCPF.Columns.Insert(6, uninstallButtonColumn);

                        // Oculta colunas desnecessárias do sistema
                        for (int i = 7; i < 60; i++)
                        {
                            gridCPF.Columns[i].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter usuários : " + response.StatusCode);
                    }
                }
            }
        }

        private void btnBuscarCPF_Click(object sender, EventArgs e)
        {
            GetUser(tbxCPF.Text);
        }
        private void btnDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 6) //Define em que coluna está o botão delete
            {
                int eventClick = e.RowIndex;
                string result = gridCPF[1, eventClick].Value.ToString();

                DeleteUser(result);
            }

            if (Application.OpenForms.OfType<ContaFuncionarios>().Count() > 0)
            {
                Application.OpenForms.OfType<ContaFuncionarios>().First().Close();
            }

            if (Application.OpenForms.OfType<ContaClientes>().Count() > 0)
            {
                Application.OpenForms.OfType<ContaClientes>().First().Close();
            }
        }
        public async void DeleteUser(string CPF)
        {
            using (var client = new HttpClient())
            {
                string URI = "https://localhost:5001/api/user";
                string CPFi = CPF;
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await
                client.DeleteAsync(String.Format("{0}/{1}", URI, CPFi));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuário excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir usuário : " + responseMessage.StatusCode);
                }
            }
            GetUser("xxxxxxxxxxx");
        }
    }
}
