using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> avaliableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers= new List<PersonModel>();

        // make sure naming is locked in before event creation
        public CreateTeamForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            avaliableTeamMembers.Add(new PersonModel { FirstName = "Will", LastName = "Kerwin" });
            avaliableTeamMembers.Add(new PersonModel { FirstName = "Jay", LastName = "McDonald" });
        }

        private void WireUpLists()
        {
            SelectTeamMemberDropDown.DataSource = avaliableTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
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
