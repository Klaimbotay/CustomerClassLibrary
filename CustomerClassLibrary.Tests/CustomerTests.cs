using Xunit;

namespace CustomerClassLibrary.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void ShouldBeAbleToCreateCustomer()
        {
            var customer = new Customer("Basargin", "Paustovskogo", "Petrozavodsk", "185016",
                "California", "United States", "student");
            Assert.NotNull(customer);
        }
        [Fact]
        public void SetAndGetEmail()
        {
            var customer = new Customer("Basargin", "Paustovskogo", "Petrozavodsk", "185016",
                "California", "United States", "student");
            customer.Email = "basargin@gmail.com";
            Assert.Equal("basargin@gmail.com", customer.Email);
        }
        [Fact]
        public void SetAndGetPhone()
        {
            var customer = new Customer("Basargin", "Paustovskogo", "Petrozavodsk", "185016",
                "California", "United States", "student");
            customer.PhoneNumber = "+919367788755";
            Assert.Equal("+919367788755", customer.PhoneNumber);
        }
        [Fact]
        public void SetAndGetMoney()
        {
            var customer = new Customer("Basargin", "Paustovskogo", "Petrozavodsk", "185016",
                "California", "United States", "student");
            customer.TotalPurchaseAmount = 1000000;
            Assert.Equal<int>(1000000, customer.TotalPurchaseAmount);
        }
    }
}