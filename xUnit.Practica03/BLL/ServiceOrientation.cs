using System;

namespace BLL
{
    public class ServiceOrientation
    {
            /// <summary>
            /// Converts values of an enum representing visual directions in an online map to the corresponding cardinal directions
            /// </summary>
            /// <param name="direction"></param>
            /// <returns></returns>
            /// <exception cref="ArgumentOutOfRangeException"></exception>
            public Orientation ToOrientation(Direction direction) => direction switch
            {
                Direction.Up => Orientation.North,
                Direction.Right => Orientation.East,
                Direction.Down => Orientation.South,
                Direction.Left => Orientation.West,
                _ => throw new ArgumentOutOfRangeException(nameof(direction), $"Not expected direction value: {direction}"),
            };

    }
}
