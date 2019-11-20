using System;
using Xunit;

namespace UselessProject.Engine.Tests
{
    public class HardcodedUselessServiceTests
    {
        [Fact]
        public void Given_Service_When_Calculated_Then_Return()
        {
            // Arrange
            var sut = new HardcodedUselessService();

            // Act
            var result = sut.CalculateUselessNumber();

            // Assert
            Assert.Equal(42, result);
        }
    }
}
