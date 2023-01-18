using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class FigureOnSquare
    {
        public Figure figure { get; private set; }  //Фигура
        public Square square { get; private set; }  //Клетка

        public FigureOnSquare(Figure figure, Square square)
        {
            this.figure = figure;
            this.square = square;
        }
    }
}
