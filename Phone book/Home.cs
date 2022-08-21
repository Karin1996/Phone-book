using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Phone_book
{
    public partial class Home : Form
    {
        List<Person> people = new List<Person>();
        int personId;
        string defaultTabText = "Add new contact";
  
        public Home()
        {
            InitializeComponent();

            // Initialize
            people.Add(new Person(0, "kerin", "kreeft", "0615508853", "bluescript", "7902JH", "korte kavel", "24", "emmen"));
            people.Add(new Person(1, "karin", "kreeft", "0615508853", "bluescript", "7902JH", "korte kavel", "24", "emmen"));
            people.Add(new Person(2, "gerrit", "kreeft", "0615508853", "bluescript", "7902JH", "korte kavel", "24", "emmen"));
            people.Add(new Person(3, "patrick", "kreeft", "0615508853", "bluescript", "7902JH", "korte kavel", "24", "emmen"));

            PopulateTable();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SaveDeleteButtonsVisible(false);
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void SortCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PopulateTable();
        }

        // Edit button on all contacts page
        private void EditBtn_Click(object sender, EventArgs e)
        {
            // Make sender object a button type
            Button thisBtn = (Button)sender;
            // Get the id from the sender
            int id = Int32.Parse(thisBtn.Name);
            personId = id;

            //Get correct Person information
            Person correctPerson = people.Find(person => id == person.id);
   
            if(correctPerson != null) MutateContactInfo("edit", correctPerson);
        }

        private void AddContactBtn_Click(object sender, EventArgs e)
        {
            MutateContactInfo("add");
        }
        private void saveEditContactBtn_Click(object sender, EventArgs e)
        {
            MutateContactInfo("save");
        }
        private void deleteContactBtn_Click(object sender, EventArgs e)
        {
            MutateContactInfo("delete");
        }

        // Switching from tab
        private void TabControl_Click(object sender, EventArgs e)
        {
            // All ContactsInfoPage is open, make sure \MutateContactPage is empty and has add new button
            if (Tabs.SelectedTab == ContactInfoPage)
            {
                Tabs.TabPages[1].Text = defaultTabText;
                messageField.Text = "";

                ClearInputs();
                SaveDeleteButtonsVisible(false);
            }
            else return;
        }

        // Fill table contactInfo of people
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
                // Make Button
                Button EditBtn = new Button();
                EditBtn.Text = "Edit"; EditBtn.Name = person.id.ToString(); EditBtn.Click += EditBtn_Click;

                // Set rowsizes
                ContactInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                // Add firstname and lastname
                ContactInfo.Controls.Add(new Label() { Text = person.firstname + " " + person.lastname }, 0, index);
                // Add phonenumber
                ContactInfo.Controls.Add(new Label() { Text = person.number }, 1, index);
                // Add button to every element
                ContactInfo.Controls.Add(EditBtn, 2, index);
                index++;
            }
        }

        private void MutateContactInfo(string action, Person person = null)
        {
            // Edit on all contacts had been pressed
            if(person != null)
            {
                // Open add/edit/delete TabPage and change the tab text
                Tabs.SelectedTab = MutateContactPage;
                Tabs.TabPages[1].Text = "Edit " + person.firstname;

                SaveDeleteButtonsVisible(true);

                // Fill the fields with correct info
                firstnameInput.Text = person.firstname;
                lastnameInput.Text = person.lastname;
                numberInput.Text = person.number;
                companyInput.Text = person.company;
                zipcodeInput.Text = person.zipcode;
                streetInput.Text = person.street;
                houseInput.Text = person.house;
                cityInput.Text = person.city;  
            }

            else if(action == "save")
            {
                //Get correct Person information
                Person correctPerson = people.Find(person => personId == person.id);

                // If ValidateForm is true, there are no type errors, continue process
                if (ValidateForm())
                {
                    Debug.Write("Validate form" + ValidateForm());
                    Debug.Write("save contact info");

                    // Edit correct Person information
                    correctPerson.firstname = firstnameInput.Text;
                    correctPerson.lastname = lastnameInput.Text;
                    correctPerson.number = numberInput.Text;
                    correctPerson.company = companyInput.Text;
                    correctPerson.zipcode = zipcodeInput.Text;
                    correctPerson.street = streetInput.Text;
                    correctPerson.house = houseInput.Text;
                    correctPerson.city = cityInput.Text;

                    // Reload table with added person
                    PopulateTable();

                    ClearInputs();

                    Tabs.TabPages[1].Text = "Edit " + correctPerson.firstname;
                    messageField.Text = "Changes are saved";
                }
                else return;
                    
            }

            else if (action == "delete")
            {
                //Get correct Person information
                Person correctPerson = people.Find(person => personId == person.id);
                // Remove correct Person
                people.Remove(correctPerson);

                // Reload table
                PopulateTable();

                // Go to all contact page
                Tabs.TabPages[1].Text = defaultTabText;
                Tabs.SelectedTab = ContactInfoPage;

                ClearInputs();
                SaveDeleteButtonsVisible(false);
            }

            // Add new contact
            else
            {
                // Clear messageField first
                messageField.Text = "";
                Debug.Write("add new contact");
                SaveDeleteButtonsVisible(false);

                // If ValidateForm is true, there are no type errors, continue process
                if (ValidateForm())
                {
                    people.Insert(0, new Person(
                       people.Count,
                       firstnameInput.Text,
                       lastnameInput.Text,
                       numberInput.Text,
                       companyInput.Text,
                       zipcodeInput.Text,
                       streetInput.Text,
                       houseInput.Text,
                       cityInput.Text
                   ));

                    // Reload table with added person
                    PopulateTable();

                    // Open all contacts TabPage
                    Tabs.SelectedTab = ContactInfoPage;

                    ClearInputs();
                    messageField.Text = "";
                }
                else return;
            } 
      
        }

        private bool ValidateForm()
        {
            // If firstname or telephone number are empty, false
            if (String.IsNullOrWhiteSpace(firstnameInput.Text) || String.IsNullOrWhiteSpace(numberInput.Text))
            {
                messageField.Text = "Please enter information in the fields that have a *";
                return false;
            }

            else if (!CheckType(firstnameInput.Text, "string")) { messageField.Text = "First name should only contain characters"; return false; }

            else if (!CheckType(numberInput.Text, "int")) { messageField.Text = "Phone number should only contain numbers"; return false; }

            // If last name is not empty, validate it
            else if (!String.IsNullOrWhiteSpace(lastnameInput.Text))
            {
                if (!CheckType(lastnameInput.Text, "string")) { messageField.Text = "Last name should only contain characters"; return false; }
                else return true;
            }
            // If street name is not empty, validate it
            else if (!String.IsNullOrWhiteSpace(streetInput.Text))
            {
                if (!CheckType(streetInput.Text, "string")) { messageField.Text = "Street name should only contain characters"; return false; }
                else return true;
            }
            // If city name is not empty, validate it
            else if (!String.IsNullOrWhiteSpace(cityInput.Text))
            {
                if (!CheckType(cityInput.Text, "string")) { messageField.Text = "City name should only contain characters"; return false; }
                else return true;
            }

            // All is well
            else return true;
        }

        public static bool CheckType(string inputString, string checkType)
        {
            if(checkType == "string")
            {
                foreach (char character in inputString)
                {
                    if (!Char.IsLetter(character))
                    {
                        Debug.Write("CheckType" + "Not all are characters");
                        return false;
                    }
                }
                return true;
            }

            else if (checkType == "int")
            {
                foreach (char character in inputString)
                {
                    if (character < '0' || character > '9')
                    {
                        Debug.Write("CheckType" + "Not all integers");
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private void SaveDeleteButtonsVisible(bool show)
        {
            // True: Hide add, Show Save and Delete
            if (show)
            {
                addContactBtn.Visible = false;
                saveEditContactBtn.Visible = true;
                deleteContactBtn.Visible = true;
            }
            // False: Show add, Hide Save and Delete
            else
            {
                addContactBtn.Visible = true;
                saveEditContactBtn.Visible = false;
                deleteContactBtn.Visible = false;
            }
        }

        private void ClearInputs()
        {
            firstnameInput.Clear();
            lastnameInput.Clear();
            numberInput.Clear();
            companyInput.Clear();
            zipcodeInput.Clear();
            streetInput.Clear();
            houseInput.Clear();
            cityInput.Clear();
        }

    }

}