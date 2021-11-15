using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace CustomerClassLibrary
{
    public class Person
    {
        [Required()]
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string? FirstName { get; set; }

        public Person(string lastName)
        {
            LastName = lastName;
        }
    }
}
