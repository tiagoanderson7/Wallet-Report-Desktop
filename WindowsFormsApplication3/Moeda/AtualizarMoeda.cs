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
    public partial class CadastrarMoeda : Form
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

        public CadastrarMoeda()
        {
            InitializeComponent();
        }

        private void CadastrarMoeda_Load(object sender, EventArgs e)
        {

        }

        public async void CadCoin(string Coin)
        {
            using (var user = new HttpClient())
            {
                //Corrige erro de autenticação
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //
                using (var response = await user.GetAsync("https://localhost:5001/api/coin/" + Coin))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Moeda cadastrada com sucesso : " + response.StatusCode);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar moeda : " + response.StatusCode);
                    }
                }
            }
        }

        private void btnBuscarMOEDA_Click(object sender, EventArgs e)
        {
            CadCoin(tbxCMOEDA.Text);

            if (Application.OpenForms.OfType<frmMOEDA>().Count() > 0)
            {
                Application.OpenForms.OfType<frmMOEDA>().First().Close();
            }
        }
    }
}
