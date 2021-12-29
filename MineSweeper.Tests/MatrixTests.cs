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
        
        [Fact]
        public void MatrixAtZeroZeroHasAnAsterisk()
        {
            Matrix matrix = new Matrix(3,3);

            matrix.FillWithBomb(new Coordinate(0, 0));
            
            matrix.At(new Coordinate(0,0)).Value.Should().Be('*');
        }

        [Fact]
        public void MatrixWithBombsIsNotEqualToMatrixWithoutBombs()
        {
            Matrix matrixWithBombs = new Matrix(3, 3);
            Matrix matrixWithoutBombs = new Matrix(3, 3);
            Matrix matrixWithoutBombsTwo = new Matrix(3, 3);
            
            matrixWithBombs.FillWithBomb(new Coordinate(0, 1));

            matrixWithBombs.Should().NotBe(matrixWithoutBombs);
            matrixWithoutBombs.Should().Be(matrixWithoutBombsTwo);
        }
    }
}