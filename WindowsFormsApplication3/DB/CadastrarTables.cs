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
    public partial class CadastrarTables : Form
    {
        public string NomeDB { get; set; }
        public string NomeTable { get; set; }

        public CadastrarTables()
        {
            InitializeComponent();
        }

        private async void CadTB()
        {
            CadastrarTables db = new CadastrarTables();
            db.NomeDB = tbxNameDB.Text;
            db.NomeTable = tbxNameTable.Text;


            using (var client = new HttpClient())
            {
                //Serializa e corrige erro de referência circular
                var serializedUser = JsonConvert.SerializeObject(db, Formatting.Indented,
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

                if (cbxTipoTable.Text == "Moeda")
                {
                    var result = await client.PostAsync("https://localhost:5001/api/admin/coin/db/table/", content);

                }
                else
                {
                    var result = await client.PostAsync("https://localhost:5001/api/admin/user/db/table/", content);
                }
            }
            MessageBox.Show("Tabela criada com sucesso!");
        }

        private void btnCadTB_Click(object sender, EventArgs e)
        {
            CadTB();

            if (Application.OpenForms.OfType<AllTables>().Count() > 0)
            {
                Application.OpenForms.OfType<AllTables>().First().Close();
            }
        }
    }
}