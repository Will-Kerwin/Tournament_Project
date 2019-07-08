using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        // make sure naming is locked in before event creation
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void BTNCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel personModel = new PersonModel();
                personModel.FirstName = FirstNameValue.Text;
                personModel.LastName = LastNameValue.Text;
                personModel.EmailAddress = EmailValue.Text;
                personModel.MobilePhoneNumber = MobileValue.Text;

                GlobalConfig.Connection.CreatePerson(personModel);

                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailValue.Text = "";
                MobileValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        // always keep naming schemes 
        private bool ValidateForm()
        {
            // could have  todo -- Add validation to the form and then implement later but nahhh
            // return true;

            if (FirstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (EmailValue.Text.Length == 0)
            {
                return false;
            }
            if (MobileValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
