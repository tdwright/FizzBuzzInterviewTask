namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class DemoMethodTests
    {
        [Fact]
        public void DemoMethodTests_AlwaysReturns_HelloWorld()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.DemoMethod();

            //assert
            output.Should().Be("Hello World");
        }
    }
}
