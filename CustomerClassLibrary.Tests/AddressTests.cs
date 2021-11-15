using Xunit;

namespace CustomerClassLibrary.Tests
{
    public class AddressTests
    {
        [Fact]
        public void ShouldBeAbleToCreateAddress()
        {
            var address = new Address("Paustovskogo", "Petrozavodsk", "185016", "California", "United States");
            Assert.NotNull(address);
        }

        [Fact]
        public void SetAndGetCountry()
        {
            var address = new Address("Paustovskogo", "Petrozavodsk", "185016", "California", "United States");
            address.Country = "Canada";
            Assert.Equal("Canada", address.Country);
        }
    }
}
