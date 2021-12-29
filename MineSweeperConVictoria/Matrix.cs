namespace MineSweeperConVictoria
{
    public class Matrix
    {
        private Cell[,] _matrix;
        public int Width { get; }
        public int Heigth { get; }

        public Matrix(int width, int heigth) 
        {
            Width = width;
            Heigth = heigth;

            _matrix = new Cell[width, heigth];
            Initialize();
        }

        private void Initialize()
        {
             for(int x = 0; x < Width -1; x++)
                 for (int y = 0; y < Heigth - 1; y++)
                     _matrix[x, y] = new Cell('.');
        }

        public Cell At(Coordinate coord) => _matrix[coord.X, coord.Y];
    }
}