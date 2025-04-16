using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BitcoinKälkulätorMelKosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Display(float rate,string symbol)
        {
            resultLabel.Visible = true;
            tulemusLabel.Visible = true;
            float result = float.Parse(bitcoinAmountInput.Text) * rate;
            resultLabel.Text = $"{result} {symbol}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float amount;
            bool success = float.TryParse(bitcoinAmountInput.Text, out amount);
            if (!success || amount <= 0f)
            {
                MessageBox.Show("Arv on negatiivne või ei ole arv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (currencySelector.SelectedItem == null)
            {
                MessageBox.Show("Palun vali valuuta", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedCurrency = currencySelector.SelectedItem.ToString();
            if (selectedCurrency == "USD")
            {
                BitcoinRates bitcoinRates = GetRates();
                Display((float)bitcoinRates.Data.BTCUSD.VALUE,"$");
            }
            else if(selectedCurrency == "EUR")
            {
                BitcoinRates bitcoinRates = GetRates();
                Display((float)bitcoinRates.Data.BTCEUR.VALUE, "€");
            }
            else if(selectedCurrency == "GBP")
            {
                BitcoinRates bitcoinRates = GetRates();
                Display((float)bitcoinRates.Data.BTCGBP.VALUE, "£");
            }
            else if (selectedCurrency == "EEK")
            {
                BitcoinRates bitcoinRates = GetRates();
                Display((float)bitcoinRates.Data.BTCEUR.VALUE * 15.6466f, "EEK");
            }
            else
            {
                MessageBox.Show("Palun vali valuuta", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public static BitcoinRates GetRates()
        {
            try
            {
                string url = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=cadli&instruments=BTC-USD,BTC-EUR,BTC-GBP&apply_mapping=true";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                var response = request.GetResponse();
                var stream = response.GetResponseStream();
                BitcoinRates bitcoin;
                using (var reader = new StreamReader(stream))
                {
                    var data = reader.ReadToEnd();
                    bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
                }
                return bitcoin;
            }
            catch
            {
                MessageBox.Show("Failed to reach API!", "No internet?",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
