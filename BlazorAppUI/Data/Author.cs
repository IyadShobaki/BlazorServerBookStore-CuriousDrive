using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppUI.Data
{
    public class Author
    {

        public string AuthorId { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [StringLength(20, ErrorMessage = "City name can not be longer than 20 characters")]
        public string City { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string EmailAddress { get; set; }
        [Range(1000, 9999999, ErrorMessage = "Salary should be greater than $1000")]
        public int Salary { get; set; }


        public Author()
        {

        }
        public Author(string authorId, string firstName, 
            string lastName, string phoneNumber, string city,
            string emailAddress, int salary)
        {
            AuthorId = authorId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            City = city;
            EmailAddress = emailAddress;
            Salary = salary;
        }

      
        
    }
}
