using FluentAssertions;
using MineSweeperConVictoria;
using Xunit;

namespace MineSweeper.Tests
{
    public class MatrixTests
    {
        [Fact]
        public void MatrixAtZeroZeroHasADot()
        {
            Matrix matrix = new Matrix(3,3);
            matrix.At(new Coordinate(0,0)).Value.Should().Be('.');
        }
    }
}