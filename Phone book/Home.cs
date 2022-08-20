using System;
using System.Diagnostics;

namespace Phone_book
{
    public partial class Home : Form
    {
        List<Person> people = new List<Person>();
  
        public Home()
        {
            InitializeComponent();

            //Initialize
            people.Add(new Person("kerin", "kreeft", "0615508853", "bluescript", "7902JH", "korte kavel", "24", "emmen"));
            people.Add(new Person("karin", "kreeft", "0615508853", "bluescript", "7902JH", "korte kavel", "24", "emmen"));
            people.Add(new Person("gerrit", "kreeft", "0615508853", "bluescript", "7902JH", "korte kavel", "24", "emmen"));
            people.Add(new Person("patrick", "kreeft", "0615508853", "bluescript", "7902JH", "korte kavel", "24", "emmen"));

            PopulateTable();
        }



        // Fill table contactInfo with people
        private void PopulateTable()
        {
            // Search for a person
            List<Person> searchResults = new List<Person>(people);
            searchResults = searchResults.FindAll(person => person.firstname.StartsWith(SearchInput.Text, StringComparison.OrdinalIgnoreCase));

            // If the checkbox is checked, sort the list
            if (SortCheckbox.Checked)
            {
                searchResults.Sort((Person a, Person b) => a.firstname.ToLower().CompareTo(b.firstname.ToLower()));
            }

            // Start with empty table
            ContactInfo.RowStyles.Clear();
            ContactInfo.Controls.Clear();

            // Populate the table
            int index = 0;
            foreach (Person person in searchResults)
            {
                Debug.Print(person.ToString());
                ContactInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                ContactInfo.Controls.Add(new Label() { Text = person.firstname }, 0, index);
                ContactInfo.Controls.Add(new Label() { Text = person.number }, 1, index);
                index++;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void ContactInfo_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void SortCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void AddContactBtn_Click(object sender, EventArgs e)
        {
            // firstname and phone number are empty, return error message
            if(String.IsNullOrEmpty(firstnameInput.Text) && String.IsNullOrEmpty(lastnameInput.Text))
            {
                ErrorMsg.Text = "Please enter the information that has a *";
                return;
            }
            // Add new contact to start of people list
            else
            {
                people.Insert(0, new Person(
                    firstnameInput.Text,
                    lastnameInput.Text,
                    numberInput.Text,
                    companyInput.Text,
                    zipcodeInput.Text,
                    streetInput.Text,
                    houseInput.Text,
                    cityInput.Text
                ));
                // Empty the inputs
                firstnameInput.Clear();
                lastnameInput.Clear();
                numberInput.Clear();
                companyInput.Clear();   
                zipcodeInput.Clear();
                streetInput.Clear();
                houseInput.Clear();
                cityInput.Clear();

                ErrorMsg.Text = "";

                //Reload table with added person
                PopulateTable();

                //Open all contact TabPage
                Tabs.SelectedTab = ContactInfoPage;

                Debug.Write("Added");
            }
        }
    }

}