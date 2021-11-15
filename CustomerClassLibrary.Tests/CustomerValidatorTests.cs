using Xunit;

namespace CustomerClassLibrary.Tests
{
    public class CustomerValidatorTests
    {
        [Fact]
        public void CheckErrorList()
        {
            var customer = new Customer("Basargin", "Paustovskogo", "Petrozavodsk", "185016",
                "California", "United States", "student");

            Assert.Empty(CustomerValidator.Validation(customer)); 
        }
    }
}
