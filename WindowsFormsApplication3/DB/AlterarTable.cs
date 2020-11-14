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
    public partial class AlterarTable : Form
    {
        public string NomeDB { get; set; }
        public string NomeTable { get; set; }
        public string NovoNome { get; set; }

        public AlterarTable()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            UpdateTable();

            if (Application.OpenForms.OfType<AllTables>().Count() > 0)
            {
                Application.OpenForms.OfType<AllTables>().First().Close();
            }
        }

        private async void UpdateTable()
        {
            AlterarTable alt = new AlterarTable();

            alt.NomeDB = tbxNameDB.Text;
            alt.NomeTable = tbxNameTable.Text;
            alt.NovoNome = tbxNovoNome.Text;

            using (var client = new HttpClient())
            {
                //Serializa e corrige erro de referência circular
                var serializedUser = JsonConvert.SerializeObject(alt, Formatting.Indented,
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

                HttpResponseMessage responseMessage = await client.PutAsync("https://localhost:5001/api/admin/" + alt.NomeDB + "/" + alt.NomeTable + "/" + alt.NovoNome, content);
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
