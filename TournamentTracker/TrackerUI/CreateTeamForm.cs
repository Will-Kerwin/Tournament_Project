using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        // make sure naming is locked in before event creation
        public CreateTeamForm()
        {
            InitializeComponent();

            // CreateSampleData();

            WireUpList();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Will", LastName = "Kerwin" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Jay", LastName = "McDonald" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "bob", LastName = "Builder" });
        }

        private void WireUpList()
        {
            // TODO - Look into refresh of data binding

            SelectTeamMemberDropDown.DataSource = null;

            SelectTeamMemberDropDown.DataSource = availableTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;

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

                personModel = GlobalConfig.Connection.CreatePerson(personModel);

                selectedTeamMembers.Add(personModel);

                WireUpList();

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

        private void BTNAddTeamMember_Click(object sender, EventArgs e)
        {
            PersonModel pm = (PersonModel)SelectTeamMemberDropDown.SelectedItem;

            if (pm != null)
            {
                availableTeamMembers.Remove(pm);
                selectedTeamMembers.Add(pm);

                WireUpList(); 
            }

        }

        private void BTNRemoveSelectedMember_Click(object sender, EventArgs e)
        {
            PersonModel pm = (PersonModel)TeamMembersListBox.SelectedItem;

            if (pm != null)
            {
                selectedTeamMembers.Remove(pm);
                availableTeamMembers.Add(pm);

                WireUpList(); 
            }
        }
    }
}
