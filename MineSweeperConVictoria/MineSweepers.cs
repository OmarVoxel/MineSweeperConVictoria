using System;
using System.Text;

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

        public string Print()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int x = 0; x < _matrix.Width; x++)
            {
                for (int y = 0; y < _matrix.Heigth; y++)
                {
                    stringBuilder.Append(_matrix.At(new Coordinate(x, y)).Value.ToString());
                }
                stringBuilder.Append('\n');
            }
            return stringBuilder.ToString().Substring(0, stringBuilder.Length - 1);
        }
    }
}