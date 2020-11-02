using CreateObject;
using FluentAssertions;
using System;
using Xunit;

namespace ObjectTests
{
    public class TriangleTests
    {
        [Fact]
        public void Area_ValidValue_ReturnsResult()
        {
            //Assert
            var initialObject = new Triangle();
            //Act
            var result = initialObject.Area();
            //Assign
            result.Should().Be(0);
            Assert.Equal(0, result);
        }
    }
}