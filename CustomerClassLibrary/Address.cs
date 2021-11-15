using System.ComponentModel.DataAnnotations;

namespace CustomerClassLibrary
{
    public class Address
    {
        //Address Line as text - required, max 100 char
        //Address Line2 as text - optional, max 100 char
        //Address Type as ENUM(with 2 options: Shipping and Billing)
        //City as text - required, max 50 char
        //Postal Code as text - required, max 6 char
        //State as text - required, Maximum 20 char
        //Country as text - required, should accept only United States or Canada
        [Required()]
        [MaxLength(100)]
        public string Line { get; set; }

        [MaxLength(100)]
        public string? Line2 { get; set; }
        public enum Type
        {
            Shipping,
            Billing,
        }
        [Required()]
        [MaxLength(50)]
        public string City { get; set; }
        [Required()]
        [MaxLength(6)]
        public string Postal { get; set; }
        [Required()]
        [MaxLength(20)]
        public string State { get; set; }
        [Required()]
        public string? _country;
        public string? Country
        {
            get
            {
                return _country;
            }
            set
            {
                if (value == "United States" || value == "Canada")
                    _country = value;
                else
                    throw new Exception("Unavailable country");
            }
        }

        public Address(string line, string city, string postal, string state, string country)
        {
            Line = line;
            City = city;
            Postal = postal;
            State = state;
            Country = country;
        }
    }
}
