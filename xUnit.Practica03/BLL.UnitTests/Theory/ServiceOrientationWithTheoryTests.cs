using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BLL.UnitTests.Theory
{
    public class ServiceOrientationWithTheoryTests
    {
        [Theory]
        [InlineData(Orientation.North, Direction.Up)]
        [InlineData(Orientation.East, Direction.Right)]
        [InlineData(Orientation.South, Direction.Down)]
        [InlineData(Orientation.West, Direction.Left)]
        public void ToOrientation_ShouldByOrientation_IfDirections(Orientation orientation, Direction direction)
        {
            //Arrange
            ServiceOrientation service = new ServiceOrientation();

            //Act
            var result = service.ToOrientation(direction);

            //Assert
            Assert.Equal(orientation, result);
        }

        [Fact]
        public void ToOrientation_ThrowsArgumentOutOfRangeExceptionTest()
        {
            //Arrange
                var serviceOrientation = new ServiceOrientation();
                const string value = "-1";
                var direction = (Direction)Enum.Parse(typeof(Direction), value);
            //Act


            //Assert
            ArgumentOutOfRangeException argumentOutOfRangeException = Assert.Throws<ArgumentOutOfRangeException>(
                () => serviceOrientation.ToOrientation(direction));
            Assert.Contains("Not expected direction value:", argumentOutOfRangeException.Message);

        }
    }
}
