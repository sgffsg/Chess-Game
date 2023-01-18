using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    enum Color
    {
        none,
        white,
        black
    }

    static class SwapColor
    {
        public static Color ChangeColor(this Color color) //Смена цвета фигур
        {
            if (color == Color.black) return Color.white;
            if (color == Color.white) return Color.black;
            return Color.none;
        }
    }
}
