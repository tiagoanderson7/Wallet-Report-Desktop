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
    public partial class frmCadDB : Form
    {
        public string NomeDB { get; set; }

        public frmCadDB()
        {
            InitializeComponent();
        }

        private void CadastrarDB_Load(object sender, EventArgs e)
        {

        }

        private async void CadDB()
        {
            frmCadDB db = new frmCadDB();
            db.NomeDB = tbxCadDB.Text;


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

                var result = await client.PostAsync("https://localhost:5001/api/admin/db", content);
            }
            MessageBox.Show("Banco criado com sucesso!");
        }

        private void btnCadDB_Click(object sender, EventArgs e)
        {
            CadDB();

            if (Application.OpenForms.OfType<frmDB>().Count() > 0)
            {
                Application.OpenForms.OfType<frmDB>().First().Close();
            }
        }

    }
}
