using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void BTNCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text,
                    PlaceNumberValue.Text,
                    PrizeAmountValue.Text,
                    PrizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                PlaceNameValue.Text = "";
                PlaceNumberValue.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";


            }
            else
            {
                MessageBox.Show("This form has invalid data try again!");
            }
        }

        // TODO set up messages in application
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            // out does oposite of paramater passes things out which arent the return 
            bool placeNumberValidNumber = int.TryParse(PlaceNumberValue.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }

            if (PlaceNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}