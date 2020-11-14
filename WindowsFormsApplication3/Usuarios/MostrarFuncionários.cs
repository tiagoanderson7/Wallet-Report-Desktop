using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net;

namespace WindowsFormsApplication3
{
    public partial class ContaFuncionarios : Form
    {
        public int Id { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public bool Admin { get; set; }

        public ContaFuncionarios()
        {
            InitializeComponent();
        }      

        public void ContaFuncionarios_Load(object sender, EventArgs e)
        {
            GetAllUsers();
        }

        //Método que busca todos os clientes na API
        public async void GetAllUsers()
        {
            using (var client = new HttpClient())
            {
                //Corrige erro de autenticação
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //

                using (var response = await client.GetAsync("https://localhost:5001/api/user/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var UsersJsonString = await response.Content.ReadAsStringAsync();
                        gridFunc.DataSource = 0;
                        gridFunc.Columns.Clear();
                        gridFunc.Refresh();

                        gridFunc.DataSource = JsonConvert.DeserializeObject<ContaClientes[]>(UsersJsonString).ToList();
                        gridFunc.Update();
                        gridFunc.Refresh();

                        //Criao o botão delete
                        DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                        uninstallButtonColumn.UseColumnTextForButtonValue = true;
                        uninstallButtonColumn.HeaderText = "Delete";
                        uninstallButtonColumn.Name = "Delete";
                        uninstallButtonColumn.Text = "Delete";
                        gridFunc.Columns.Insert(6, uninstallButtonColumn);

                        // Oculta colunas desnecessárias do sistema
                        for (int i = 7; i < 60; i++)
                        {
                            gridFunc.Columns[i].Visible = false;
                        }

                        // Oculta usuários Clientes
                        foreach (DataGridViewRow row in gridFunc.Rows)
                        {
                            //permite ocultar linhas protegidas
                            CurrencyManager cm = (CurrencyManager)BindingContext[gridFunc.DataSource];
                            cm.EndCurrentEdit();
                            cm.ResumeBinding();
                            cm.SuspendBinding();

                            DataGridViewCheckBoxCell ck = (DataGridViewCheckBoxCell)row.Cells[5];
                            //Passa se o checkBox estiver selecionado;
                            if (Convert.ToBoolean(ck.Value) == false)
                            {
                                row.Visible = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter usuários : " + response.StatusCode);
                    }
                }
            }
        }

        private void btnDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 6) //Define em que coluna está o botão delete
            {
                int eventClick = e.RowIndex;
                string result = gridFunc[1, eventClick].Value.ToString();
                DeleteUser(result);
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
            GetAllUsers();
        }
    }
}
