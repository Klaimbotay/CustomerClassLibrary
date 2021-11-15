using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClassLibrary
{
    public class CustomerValidator
    {
        public static List<string> Validation(Customer customer)
        {
            var errorList = new List<string>();
            if (customer.Addresses == null)
                errorList.Add("No Address of customer");
            if (customer.Notes == null)
                errorList.Add("No notes about customer");
            return errorList;
        }
    }
}
