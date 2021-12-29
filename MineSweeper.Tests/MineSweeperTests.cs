using FluentAssertions;
using MineSweeperConVictoria;
using Xunit;

namespace MineSweeper.Tests
{
    public class MineSweeperTests
    {
        [Fact]
        public void PrintMatrix()
        {
            Matrix matrix = new Matrix(3,3);
            MineSweepers mineSweeper = new MineSweepers(matrix);
            mineSweeper.Print().Should().Be("...\n...\n...");
        }
        
        [Fact]
        public void OpenPositionZeroZeroAndShowTheMatrix()
        {
            Matrix matrix = new Matrix(3,3);
  
            
            MineSweepers mineSweeper = new MineSweepers(matrix);
            mineSweeper.FillWithBomb(new(0, 0));
            mineSweeper.FillWithBomb(new(1,2));
            
            
            mineSweeper.Open(new Coordinate(1, 1));
            mineSweeper.Print().Should().Be("...\n.2.\n...");
        }
    }
}