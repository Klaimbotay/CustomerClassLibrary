using Xunit;

namespace CustomerClassLibrary.Tests
{
    public class PersonTests
    {
        [Fact]
        public void ShouldBeAbleToCreatePerson()
        {
            Person person = new("Basargin");
            Assert.NotNull(person);
        }

        [Fact]
        public void SetPersonFirstName()
        {
            var person = new Person("Basargin")
            {
                FirstName = "Klim"
            };
            Assert.Equal("Klim", person.FirstName);
        }
    }
}
