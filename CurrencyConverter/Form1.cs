using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Populate ComboBoxes with currencies
            comboBoxFromCurrency.Items.AddRange(new string[] { "USD", "EUR", "GBP" });
            comboBoxToCurrency.Items.Add("NPR"); // Nepali Rupee
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(textBoxAmount.Text, out amount))
            {
                decimal convertedAmount = ConvertToNPR(amount, comboBoxFromCurrency.SelectedItem.ToString());
                textBoxResult.Text = convertedAmount.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }
        private decimal ConvertToNPR(decimal amount, string fromCurrency)
        {
            // Hardcoded conversion rates for demonstration
            decimal usdToNPRRate = 133.47m;
            decimal eurToNPRRate = 144.01m;
            decimal gbpToNPRRate = 156.80m;

            // Convert the amount to Nepali Rupee (NPR)
            switch (fromCurrency)
            {
                case "USD":
                    return amount * usdToNPRRate;
                case "EUR":
                    return amount * eurToNPRRate;
                case "GBP":
                    return amount * gbpToNPRRate;
                default:
                    return 0m;
            }
        }
    }
 
}

