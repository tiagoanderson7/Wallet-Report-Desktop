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
    public partial class frmMOEDA : Form
    {
        public int Id { get; set; }

        public string Slug { get; set; }

        public string Market { get; set; }

        public double Last { get; set; }

        public double PercentChange { get; set; }

        public double BaseVolume24 { get; set; }

        public double QuoteVolume24 { get; set; }

        public double BaseVolume { get; set; }

        public double QuoteVolume { get; set; }

        public double HighestBid24 { get; set; }

        public double LowestAsk24 { get; set; }

        public double Hwap { get; set; }

        public double LowestAsk { get; set; }

        public DateTime Date { get; set; }

        public frmMOEDA()
        {
            InitializeComponent();
        }
        private void Moedas_Load(object sender, EventArgs e)
        {

        }

        public async void GetCoin(string Coin)
        {
            using (var user = new HttpClient())
            {
                //Corrige erro de autenticação
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //
                using (var response = await user.GetAsync("https://localhost:5001/details/" + Coin))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var UsersJsonString = await response.Content.ReadAsStringAsync();
                        gridMOEDA.DataSource = 0;
                        gridMOEDA.Columns.Clear();
                        gridMOEDA.Refresh();

                        gridMOEDA.DataSource = JsonConvert.DeserializeObject<frmMOEDA[]>(UsersJsonString).ToList();
                        gridMOEDA.Update();
                        gridMOEDA.Refresh();

                        //// Oculta colunas desnecessárias do sistema
                        for (int i = 14; i < 67; i++)
                        {
                            gridMOEDA.Columns[i].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter moeda : " + response.StatusCode);
                    }
                }
            }
        }

        private void btnBuscarMOEDA_Click(object sender, EventArgs e)
        {
            GetCoin(tbxMOEDA.Text);
        }
    }
}
