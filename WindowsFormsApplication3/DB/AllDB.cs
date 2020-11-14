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
    public partial class frmDB : Form
    {
        public string NomeDB { get; set; }

        public frmDB()
        {
            InitializeComponent();
        }

        private void AllDB_Load(object sender, EventArgs e)
        {
            GetDB();
        }

        public async void GetDB()
        {
            using (var user = new HttpClient())
            {
                //Corrige erro de autenticação
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //
                using (var response = await user.GetAsync("https://localhost:5001/api/admin/db"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var UsersJsonString = await response.Content.ReadAsStringAsync();
                        gridDB.DataSource = 0;
                        gridDB.Columns.Clear();
                        gridDB.Refresh();

                        gridDB.DataSource = JsonConvert.DeserializeObject<frmDB[]>(UsersJsonString).ToList();
                        gridDB.Update();
                        gridDB.Refresh();

                        //Criao o botão delete
                        DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                        uninstallButtonColumn.UseColumnTextForButtonValue = true;
                        uninstallButtonColumn.HeaderText = "Delete";
                        uninstallButtonColumn.Name = "Delete";
                        uninstallButtonColumn.Text = "Delete";
                        gridDB.Columns.Insert(1, uninstallButtonColumn);

                        ////// Oculta colunas desnecessárias do sistema
                        for (int i = 2; i < 55; i++)
                        {
                            gridDB.Columns[i].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter bancos : " + response.StatusCode);
                    }
                }
            }
        }

        private void btnDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1) //Define em que coluna está o botão delete
            {
                int eventClick = e.RowIndex;
                string result = gridDB[0, eventClick].Value.ToString();
                DeleteDB(result);
            }
        }

        public async void DeleteDB(string DB)
        {
            using (var client = new HttpClient())
            {
                string URI = "https://localhost:5001/api/admin";
                string DBi = DB;
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await
                client.DeleteAsync(String.Format("{0}/{1}", URI, DBi));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Banco excluído com sucesso: " + responseMessage.StatusCode);
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o banco : " + responseMessage.StatusCode);
                }
            }
            GetDB();
        }
    }
}
