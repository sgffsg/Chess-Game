﻿using System;

namespace ChessGame
{
    class FigureMoving
    {
        public Figure figure { get; private set; }
        public Square from { get; private set; }
        public Square to { get; private set; }
        public Figure promotion { get; private set; }

        public FigureMoving(FigureOnSquare fs, Square to, Figure promotion = Figure.none)
        {
            this.figure = fs.figure;
            this.from = fs.square;
            this.to = to;
            this.promotion = promotion;
        }

        public FigureMoving (string move)
        {
            this.figure = (Figure)move[0];
            this.from = new Square(move.Substring(1,2));
            this.to = new Square(move.Substring(3,2));
            this.promotion = (move.Length == 6) ? (Figure)move[5] : Figure.none;
        }

        public int deltaX { get { return to.x - from.x; } }
        public int deltaY { get { return to.y - from.y; } }

        public int AbsDeltaX { get { return Math.Abs(deltaX); } }
        public int AbsDeltaY { get { return Math.Abs(deltaY); } }
        public int SignX { get { return Math.Sign(deltaX); } }
        public int SignY { get { return Math.Sign(deltaY); } }

        public override string ToString()
        {
            string text = (char)figure + from.Name + to.Name;
            if (promotion != Figure.none)
                text += (char)promotion;
            return text;
        }

    }
}
