using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BLL.UnitTests.Fact
{
    public class ServiceOrientationWithFactTests
    {
        [Fact]
        public void ToOrientation_ShouldBeOrientationNorth_IfDirectionUP()
        {
            //Arrange
            const Direction direction = Direction.Up;
            var serviceOrientation = new ServiceOrientation();
            //Act
            var result = serviceOrientation.ToOrientation(direction);

            //Assert
            Assert.Equal(Orientation.North, result);
        }

        [Fact]
        public void ToOrientation_ShouldBeOrientationSouth_IfDirectionDown()
        {
            //Arrange
            const Direction direction = Direction.Down;
            var serviceOrientation = new ServiceOrientation();
            //Act
            var result = serviceOrientation.ToOrientation(direction);

            //Assert
            Assert.Equal(Orientation.South, result);
        }

        [Fact]
        public void ToOrientation_ShouldBeOrientationWest_IfDirectionLeft()
        {
            //Arrange
            const Direction direction = Direction.Left;
            var serviceOrientation = new ServiceOrientation();
            //Act
            var result = serviceOrientation.ToOrientation(direction);

            //Assert
            Assert.Equal(Orientation.West, result);
        }


        [Fact]
        public void ToOrientation_ShouldBeOrientationEast_IfDirectionRight()
        {
            //Arrange
            const Direction direction = Direction.Right;
            var serviceOrientation = new ServiceOrientation();
            //Act
            var result = serviceOrientation.ToOrientation(direction);

            //Assert
            Assert.Equal(Orientation.East, result);
        }

        [Fact]
        public void ToOrientation_ThrowsArgumentOutOfRangeExceptionTest()
        {
            // Arrange
            var serviceOrientation = new ServiceOrientation();
            const string value = "-1";
            var direction = (Direction)Enum.Parse(typeof(Direction), value);
            // Act

            // Assert
            var argumentOutOfRangeException = Assert.Throws<ArgumentOutOfRangeException>(
                () => serviceOrientation.ToOrientation(direction));
            Assert.Contains("Not expected direction value:", argumentOutOfRangeException.Message);
        }

    }
}
