using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MineSweeperConVictoria
{
    public class MineSweepers
    {
        private readonly Matrix _matrix;

        public MineSweepers(Matrix matrix)
        {
            _matrix = matrix;
            _matrix = new Matrix(_matrix.Width, _matrix.Heigth);
        }

        public void FillWithBomb(Coordinate coord)
        {
            _matrix.FillWithBomb(coord);
        }
        
        public string Print()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int x = 0; x < _matrix.Width; x++)
            {
                for (int y = 0; y < _matrix.Heigth; y++)
                {
                    if (_matrix.At(new(x, y)).Value == '*')
                        stringBuilder.Append('.');
                    else
                        stringBuilder.Append(_matrix.At(new Coordinate(x, y)).Value.ToString());
                }
                stringBuilder.Append('\n');
            }
            return stringBuilder.ToString().Substring(0, stringBuilder.Length - 1);
        }

        public void Open(Coordinate coordinate)
        {
            int countNeighbor = CountNeighbor(coordinate);
            _matrix.ChangeValue(coordinate, countNeighbor);
        }

        private int CountNeighbor(Coordinate coordinate)
        {
            List<Coordinate> coordinates = new List<Coordinate>()
            {
                new Coordinate(coordinate.X - 1, coordinate.Y - 1),
                new Coordinate(coordinate.X, coordinate.Y - 1),
                new Coordinate(coordinate.X + 1, coordinate.Y - 1),
                new Coordinate(coordinate.X + 1, coordinate.Y),
                new Coordinate(coordinate.X + 1, coordinate.Y + 1),
                new Coordinate(coordinate.X, coordinate.Y + 1),
                new Coordinate(coordinate.X - 1, coordinate.Y + 1),
                new Coordinate(coordinate.X - 1, coordinate.Y)
            };
            
            return coordinates.Count(x => _matrix.At(x).Value == '*');
        }


    }
}