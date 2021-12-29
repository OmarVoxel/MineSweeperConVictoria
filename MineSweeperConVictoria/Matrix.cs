using System;
using System.Linq;

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
             for(int x = 0; x < Width; x++)
                 for (int y = 0; y < Heigth ; y++)
                     _matrix[x, y] = new Cell('.');
        }

        public Cell At(Coordinate coord) => _matrix[coord.X, coord.Y];

        public void FillWithBomb(Coordinate coord)
            => _matrix[coord.X, coord.Y] = new Cell('*');
        
        private string CellAsString() 
            => String.Concat(_matrix.OfType<Cell>().Select(c => c.Value));
        public override bool Equals(object other) 
            => CellAsString().Equals((other as Matrix)?.CellAsString());
        public override int GetHashCode() 
            => CellAsString().GetHashCode();

        public void ChangeValue(Coordinate coordinate, int countNeighbor)
        {
            _matrix[coordinate.X, coordinate.Y] = new Cell(char.Parse(countNeighbor.ToString()));
        }
    }
}