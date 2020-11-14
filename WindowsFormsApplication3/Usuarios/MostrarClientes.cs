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
    public partial class ContaClientes : Form
    {
        public int Id { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public bool Admin { get; set; }

        public ContaClientes()
        {
            InitializeComponent();
        }

        public void ContaClientes_Load(object sender, EventArgs e)
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
                        gridClientes.DataSource = 0;
                        gridClientes.Columns.Clear();
                        gridClientes.Refresh();

                        gridClientes.DataSource = JsonConvert.DeserializeObject<ContaClientes[]>(UsersJsonString).ToList();
                        gridClientes.Update();
                        gridClientes.Refresh();
                        

                        //Criao o botão delete
                        DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                        uninstallButtonColumn.UseColumnTextForButtonValue = true;
                        uninstallButtonColumn.HeaderText = "Delete";
                        uninstallButtonColumn.Name = "Delete";
                        uninstallButtonColumn.Text = "Delete";
                        gridClientes.Columns.Insert(6, uninstallButtonColumn);

                        // Oculta colunas desnecessárias do sistema
                        for (int i = 7; i < 60; i++)
                        {
                            gridClientes.Columns[i].Visible = false;
                        }

                        // Oculta usuários Admin
                        foreach (DataGridViewRow row in gridClientes.Rows)
                        {
                            //permite ocultar linhas protegidas
                            CurrencyManager cm = (CurrencyManager)BindingContext[gridClientes.DataSource];
                            cm.EndCurrentEdit();
                            cm.ResumeBinding();
                            cm.SuspendBinding();

                            DataGridViewCheckBoxCell ck = (DataGridViewCheckBoxCell)row.Cells[5];
                            //Passa se o checkBox estiver selecionado;
                            if (Convert.ToBoolean(ck.Value) == true)
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
                string result = gridClientes[1, eventClick].Value.ToString();
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

        //private async void UpdateProduto()
        //{
        //    //string URI = "https://localhost:5001/api/user";
        //    ContaClientes user = new ContaClientes();

        //    //user.Id = IntValue(0, e);
        //    user.CPF = "12154187602";
        //    user.Nome = "casas";
        //    user.Senha = "casasa";
        //    user.Email = "casasasa";
        //    user.Admin = false;

        //    //user.CPF = StringValue(1, e);
        //    //user.Nome = StringValue(2, e);
        //    //user.Senha = StringValue(3, e);
        //    //user.Email = StringValue(4, e);
        //    //user.Admin = BoolValue(5, e);

        //    using (var client = new HttpClient())
        //    {
        //        //Serializa e corrige erro de referência circular
        //        var serializedUser = JsonConvert.SerializeObject(user, Formatting.Indented,
        //            new JsonSerializerSettings()
        //            {
        //                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
        //            }
        //        );

        //        var content = new StringContent(serializedUser, Encoding.UTF8, "application/json");
        //        //

        //        string jsonContent = content.ReadAsStringAsync().Result;

        //        //Corrige erro de autenticação
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        //        //

        //        HttpResponseMessage responseMessage = await client.PutAsJsonAsync("https://localhost:5001/api/user/12154187602", content);
        //        if (responseMessage.IsSuccessStatusCode)
        //        {
        //            MessageBox.Show("La bambonera de pastel: " + responseMessage.StatusCode);
        //        }
        //        else
        //        {
        //            textBox1.Visible = true;
        //            textBox1.Text = jsonContent;
        //            //MessageBox.Show(jsonContent);
        //        }
        //    }
        //    //GetAllUsers();
        //}

        ////public int IntValue(int IndexID, DataGridViewCellEventArgs e)
        ////{
        ////    int eventClick = e.RowIndex;
        ////    int result = Convert.ToInt32(gridClientes[IndexID, eventClick].Value);
        ////    return result;
        ////}
        //public string StringValue(int IndexID, DataGridViewCellEventArgs e)
        //{
        //    int eventClick = e.RowIndex;
        //    string result = gridClientes[IndexID, eventClick].Value.ToString();
        //    return result;
        //}
        //public bool BoolValue(int IndexID, DataGridViewCellEventArgs e)
        //{
        //    int eventClick = e.RowIndex;
        //    bool result = Convert.ToBoolean(gridClientes[IndexID, eventClick].Value);
        //    return result;
        //}
    }
}
