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

namespace WindowsFormsApplication3.DB
{
    public partial class AllTables : Form
    {
        public string NomeTable { get; set; }

        public AllTables()
        {
            InitializeComponent();
        }

        private void AllTables_Load(object sender, EventArgs e)
        {
            //GetTables();
        }

        public async void GetTables(string DB)
        {
            using (var user = new HttpClient())
            {
                //Corrige erro de autenticação
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //
                using (var response = await user.GetAsync("https://localhost:5001/api/admin/" + DB + "/table"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var UsersJsonString = await response.Content.ReadAsStringAsync();
                        gridTables.DataSource = 0;
                        gridTables.Columns.Clear();
                        gridTables.Refresh();

                        gridTables.DataSource = JsonConvert.DeserializeObject<AllTables[]>(UsersJsonString).ToList();
                        gridTables.Update();
                        gridTables.Refresh();

                        //Criao o botão delete
                        DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                        uninstallButtonColumn.UseColumnTextForButtonValue = true;
                        uninstallButtonColumn.HeaderText = "Delete";
                        uninstallButtonColumn.Name = "Delete";
                        uninstallButtonColumn.Text = "Delete";
                        gridTables.Columns.Insert(1, uninstallButtonColumn);

                        ////// Oculta colunas desnecessárias do sistema
                        for (int i = 2; i < 55; i++)
                        {
                            gridTables.Columns[i].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter bancos : " + response.StatusCode);
                    }
                }
            }
        }

        private void btnBuscarTables_Click(object sender, EventArgs e)
        {
            GetTables(tbxAllTables.Text);
        }

        private void btnDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1) //Define em que coluna está o botão delete
            {
                string DB = tbxAllTables.Text;

                int eventClick = e.RowIndex;
                string Table = gridTables[0, eventClick].Value.ToString();

                DeleteUser(DB, Table);
            }
        }
        public async void DeleteUser(string DB, string Table)
        {
            using (var client = new HttpClient())
            {
                string URI = "https://localhost:5001/api/admin";
                string DBi = DB;
                string Tablei = Table;
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await
                client.DeleteAsync(String.Format("{0}/{1}/{2}", URI, DBi, Tablei));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Tabela excluída com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir a tabela : " + responseMessage.StatusCode);
                }
            }
            GetTables(tbxAllTables.Text);
        }
    }


}
