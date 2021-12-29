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
    }
}