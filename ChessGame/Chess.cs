using System.Collections.Generic;

namespace ChessGame
{
    public class Chess
    {
        public string fen { get; private set; }
        public string promo { get; set; }
        Board board;
        Moves moves;
        List<FigureMoving> allMoves;

        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            this.fen = fen;
            board = new Board(fen);
            moves = new Moves(board);
        }

        Chess(Board board)
        {
            this.board = board;
            this.fen = board.fen;
            moves = new Moves(board);
        }

        public Chess Move(string move, string f)
        {
            
            FigureMoving fm = new FigureMoving(move);

            if (!moves.CanMove(fm))
                return this;
            if (board.IsCheckAfterMove(fm))
            {
                //Console.WriteLine("Ход приведет к шаху");
                return this;
            }
            Board nextBoard = board.Move(fm, f);
            Chess nextChess = new Chess(nextBoard);

            return nextChess;
        }

        public char GetFigureAt(int x, int y)
        {
            Square square = new Square(x, y);
            Figure f = board.GetFigureAt(square);
            return f == Figure.none ? '.' : (char)f;
        }

        void FindAllMoves()
        {
            allMoves = new List<FigureMoving>();
            foreach (FigureOnSquare fs in board.YieldFigures())
                foreach (Square to in Square.YieldSquares())
                {
                    FigureMoving fm = new FigureMoving(fs, to);
                    if (moves.CanMove(fm))
                        if (!board.IsCheckAfterMove(fm))
                            allMoves.Add(fm);
                }
        }

        public List<string> GetAllMoves()
        {
            FindAllMoves();
            List<string> list = new List<string>();
            foreach (FigureMoving fm in allMoves)
                list.Add(fm.ToString());
            return list;
        }

        public bool IsCheck()
        {
            return board.IsCheck();
        }

        public string ColorRequest()
        {
            return board.moveColor == Color.black ? "Черных" : "Белых";
        }
        public string MoveNumRequest()
        {
            return board.moveNumber.ToString();
        }

        public string FenRequest()
        {
            return fen;
        }
        public Chess PawnPromotion(string move, string f)
        {
            FigureMoving fm = new FigureMoving(move);
            Board nextBoard = board.PawnPromo(fm, f);
            Chess nextChess = new Chess(nextBoard);
            return nextChess;
        }
        public Chess CastlMove(string move, string f, char val)
        {
            FigureMoving fm = new FigureMoving(move);
            Board nextBoard = board.CastlingMove(fm, f, val);
            Chess nextChess = new Chess(nextBoard);
            return nextChess;
        }

        public string CheckLongCastling(int x, int y)
        {
            if (!IsCheck())
            {
                if (board.moveColor == Color.black)
                {
                    if (GetFigureAt(x, y) == 'k')
                    {
                        if (GetFigureAt(x - 1, y) == '.')
                        {
                            if (GetFigureAt(x - 2, y) == '.')
                            {
                                if (GetFigureAt(x - 3, y) == '.')
                                {
                                    if (GetFigureAt(x - 4, y) == 'r')
                                    {
                                        return "BL";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (GetFigureAt(x, y) == 'K')
                    {
                        if (GetFigureAt(x - 1, y) == '.')
                        {
                            if (GetFigureAt(x - 2, y) == '.')
                            {
                                if (GetFigureAt(x - 3, y) == '.')
                                {
                                    if (GetFigureAt(x - 4, y) == 'R')
                                    {
                                        return "WH";
                                    }
                                }
                            }
                        }
                    }
                }
        }
            return "none";
        }
        public string CheckShortCastling(int x, int y)
        {
            if (!IsCheck())
            {
                if (board.moveColor == Color.black)
                {

                    if (GetFigureAt(x, y) == 'k')
                    {
                        if (GetFigureAt(x + 1, y) == '.')
                        {
                            if (GetFigureAt(x + 2, y) == '.')
                            {
                                if (GetFigureAt(x + 3, y) == 'r')
                                {
                                    return "BL";
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (GetFigureAt(x, y) == 'K')
                    {
                        if (GetFigureAt(x + 1, y) == '.')
                        {
                            if (GetFigureAt(x + 2, y) == '.')
                            {
                                if (GetFigureAt(x + 3, y) == 'R')
                                {
                                    return "WH";
                                }
                            }
                        }
                    }
                }
            }
            return "none";
        }
       
    }
}
