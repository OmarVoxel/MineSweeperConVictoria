namespace MineSweeperConVictoria
{
    public struct Coordinate
    {
        public int Y;
        public int X;
        public Coordinate(int x, int y)
            => (X, Y) = (x, y);
    }
}