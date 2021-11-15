using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CustomerClassLibrary
{
    public class Customer : Person
    {
        //Addresses List of Address class (Generic Class), required at least 1 address
        //Customer Phone Number - optional, accept only E.164 format
        //Customer Email - optional, accept only email format(validate using Regex)
        //Notes as List of text - Note cannot be empty, at least 1 note must be provided
        //TotalPurchasesAmount - "money" type - can be null (write unit test)
        [Required()]
        [MinLength(1)]
        public List<Address> Addresses = new List<Address>();

        [DataType(DataType.PhoneNumber)]
        public string? _phoneNumber;

        public string? PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value == null)
                    throw new InvalidCastException("Wrong phoneNumber");
                Regex regex = new Regex(@"^\+[1-9]\d{1,14}$");
                Match match = regex.Match(value);
                if (match.Success)
                    _phoneNumber = match.Value;
                else
                    throw new InvalidCastException("Wrong phoneNumber");
            }
        }

        [DataType(DataType.EmailAddress)]
        public string? _email;
        public string? Email
        {
            get
            {
                return _email;
            }
            set
            {
                if(value == null)
                    throw new InvalidCastException("Wrong e-mail");
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(value);
                if (match.Success)
                    _email = match.Value;
                else
                    throw new InvalidCastException("Wrong e-mail");
            }
        }
        [Required()]
        [MinLength(1)]
        public List<string> Notes = new List<string>();
        public class Money
        {
            public int Amount { get; set; }

        }
        public Money _totalPurchaseAmount = new Money();
        public int TotalPurchaseAmount
        {
            get
            {
                return _totalPurchaseAmount.Amount;
            }
            set
            {
                _totalPurchaseAmount.Amount = value;
            }
        }

        public Customer(string lastName, string line, string city, string postal,
            string state, string country, string note) : base(lastName)
        {
            var address = new Address(line, city, postal, state, country);
            
            Addresses.Add(address);
            Notes.Add(note);
        }
    }
}