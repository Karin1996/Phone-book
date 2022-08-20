using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Phone_book
{
    internal class Person
    {
        public string firstname;
        public string lastname;
        public string number;
        public string company;
        public string zipcode;
        public string street;
        public string house;
        public string city;

        // constructor
        public Person(string firstname, string lastname, string number, string company, string zipcode, string street, string house, string city)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.number = number;
            this.company = company;
            this.zipcode = zipcode;
            this.street = street;
            this.house = house;
            this.city = city;
        }


        public override string ToString()
        {
            return "Person: " + firstname + " " + lastname + " \n " + number;
        }
    
    }
}
