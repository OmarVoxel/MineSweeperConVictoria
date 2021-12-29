using Xunit;
using FluentAssertions;
using MineSweeperConVictoria;

namespace MineSweeper.Tests {

    public class CellTests
    {
        [Fact]
        public void CellContainsPoint()
        {
            Cell cell = new Cell('.');
            cell.Value.Should().Be('.');
        }
        
        [Fact]
        public void CellContainsAsterisk()
        {
            Cell cell = new Cell('*');
            cell.Value.Should().Be('*');
        }
    }
}