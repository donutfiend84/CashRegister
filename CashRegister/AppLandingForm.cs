using CashRegister.Components;
using CashRegister.Data;
using CashRegister.MockSql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class AppLandingForm : Form
    {
        public AppLandingForm()
        {
            // Necessary for windows forms
            InitializeComponent();
        }

        private void AppLandingForm_Load(object sender, EventArgs e)
        {
            // Initialize Components
            InitializeCurrencySelector();
        }

        private void InitializeCurrencySelector()
        {
            // In a full application, we might pull selectable currencies from a DB, based on user permissions, or biographical data.
            // For the purposes of this test, we will simply mock up a sample returned data object
            MockCurrencyData[] mockCurrencyData = MockCurrencyData.GetMockCurrencyData();

            CountrySelectorCB.DataSource = mockCurrencyData;
            CountrySelectorCB.DisplayMember = "countryDisplayText";

            // Configure sub-selection defaults
            PreferredCurrencyCB.SelectedIndex = 0;
        }

        private void CountrySelectorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If we have multiple denominations for currency in a region, provide a sub selector
            // For example, the UK uses both the Pound and the Euro.
            if((CountrySelectorCB.SelectedItem as MockCurrencyData).CurrencyTypes.Length > 1)
            {
                PreferredCurrencyCB.DataSource = (CountrySelectorCB.SelectedItem as MockCurrencyData).CurrencyTypes;
                PreferredCurrencyCB.Visible = PreferredCurrencyLbl.Visible = PreferredCurrencyNoteLbl.Visible = true;
            }
            else
            {
                // Hide sub-selection
                PreferredCurrencyCB.Visible = PreferredCurrencyLbl.Visible = PreferredCurrencyNoteLbl.Visible = false;
            }
        }

        private void UploadFileBtn_Click(object sender, EventArgs e)
        {
            // Open the file selector dialog box
            OpenFileBrowser.InitialDirectory = "C://";
            OpenFileBrowser.Title = "Select file of transactions to be loaded.";

            try
            {
                if (OpenFileBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (OpenFileBrowser.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(OpenFileBrowser.FileName);
                        string fileText = System.IO.File.ReadAllText(path);

                        TransactionInputTxt.Text = fileText;
                    }
                }
                else
                {
                    MessageBox.Show("Please upload a document, or manually enter transaction information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessInputsBtn_Click(object sender, EventArgs e)
        {
            // Select the appropriate regional currency configuration for DI
            ICurrency regionalCurrency = null;
            switch((CountrySelectorCB.SelectedItem as MockCurrencyData).CountryCode)
            {
                case "US":
                    regionalCurrency = new Currency_US();
                    break;

                case "UK":
                    regionalCurrency = new Currency_UK((string)PreferredCurrencyCB.SelectedItem != "Euro");
                    break;

                default:
                    MessageBox.Show("This country code is not currently configured. Aborting processing.");
                    return;
            }

            // Initialize our MoneyProcessor, and output list
            MoneyProcessor moneyProcessor = new MoneyProcessor(regionalCurrency);
            List<string> output = new List<string>();

            // Iterate through each transaction line in the text
            string[] textLines = TransactionInputTxt.Text.Split();

            foreach(string textLine in textLines)
            {
                // Confirm this is not a blank line
                if (!string.IsNullOrWhiteSpace(textLine))
                {
                    // Split this transaction into it's component parts -- Amount owed and amount paid respectively
                    string[] transactionComponents = textLine.Split(',');

                    // Validate that we have exactly 2 results. Line cannot be parsed if not.
                    if (transactionComponents.Length != 2) 
                    {
                        output.Add("There was an error parsing the entry '" + textLine + "'. Exactly one comma is expected on each line.");
                        continue;
                    }

                    // Confirm that both values are valid decimals
                    decimal amountOwed, amountPaid;
                    if (!(decimal.TryParse(transactionComponents[0], out amountOwed) && 
                         decimal.TryParse(transactionComponents[1], out amountPaid)))
                    {
                        output.Add("There was an error parsing the line '" + textLine + "'. One or more of the values is not a valid decimal value.");
                        continue;
                    }

                    // Now that we have the transaction in decimal values, we can submit it to the moneyProcessor
                    output.Add(moneyProcessor.GetChange(amountOwed, amountPaid));
                }
            }
            
            // Parse results into a text string, and display it in the output window
            TransactionOutputTxt.Text = string.Join(Environment.NewLine, output);

            // Output the results to a file
            File.WriteAllText("Output.txt", TransactionOutputTxt.Text);

            // Update the output label with the location of the output file
            OutputFileLocationTxt.Text = "Output file saved to " + System.IO.Path.GetFullPath("Output.txt");
        }
    }
}
