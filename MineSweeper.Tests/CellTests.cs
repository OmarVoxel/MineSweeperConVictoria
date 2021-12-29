using Xunit;
using FluentAssertions;

namespace MineSweeper.Tests {

    public class CellTests
    {
        [Fact]
        public void CellShowPoint()
        {
            Cell cell = new Cell(".");
            cell.Should().Be(".");
        }
    }
}