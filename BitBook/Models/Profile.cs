using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        [Display (Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }
        [Display(Name = "Date Of Brith")]
        public DateTime DateOfBirth { get; set; }

        public Profile(string firstName, string lastName, string gender, string country, DateTime dateOfBirth):this()
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Country = country;
            DateOfBirth = dateOfBirth;
        }

        public Profile()
        {
        }
    }
}