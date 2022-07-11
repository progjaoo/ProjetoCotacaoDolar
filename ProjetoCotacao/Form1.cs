using System.Globalization;
using Newtonsoft.Json;


namespace ProjetoCotacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=2d8c070a";  

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = client.GetAsync(strURL).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        Market market = JsonConvert.DeserializeObject<Market>(result);

                        LblBuy.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        LblSell.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        LblVariation.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);

                    }
                    else
                    {
                        LblBuy.Text = "-";
                        LblSell.Text = "-";
                        LblVariation.Text = "-";
                    }
                }
                catch(Exception ex)
                {
                    LblBuy.Text = "-";
                    LblSell.Text = "-";
                    LblVariation.Text = "-";

                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}