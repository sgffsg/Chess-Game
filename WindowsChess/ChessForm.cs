using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ChessGame;

namespace WindowsChess
{
    public partial class ChessForm : Form
    {
        const int SIZE = 80;

        Panel [,] map;
        Chess chess;
        bool wait =true;
        int xFrom, yFrom;
        string mover = "";
        public ChessForm()
        {
            InitializeComponent();

            InitPanels();
            if (GameSettings.gameStatus == "play")
                chess = new Chess();

            if (GameSettings.gameStatus == "load")
            {
                LoadValues();
            }
                
            ShowPositions();
            ShowGameElements();
            MarkSquaresFrom();
        }
        void LoadValues()
        {
            ResetValues();
            ClearCastleValues();
            chess = new Chess(GameSettings.fenToLoad);
            string[] fen = GameSettings.fenToLoad.Split();
            char[] cast = fen[2].ToCharArray();
            
            for (int i = 0; i < cast.Length; i++)
            {
                if (cast[i] == 'K')
                {
                    GameSettings.ShortWhiteCastlingIsPossible = true;
                }
                if (cast[i] == 'Q')
                {
                    GameSettings.LongWhiteCastlingIsPossible = true;
                }
                if (cast[i] == 'k')
                {
                    GameSettings.ShortBlackCastlingIsPossible = true;
                }
                if (cast[i] == 'q')
                {
                    GameSettings.LongBlackCastlingIsPossible = true;
                }
            }
        }
        void InitPanels()
        {
            map = new Panel[8, 8];
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    map[x, y] = AddPanel(x,y);
        }

        void ShowPositions()
        {
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    ShowFigure(x, y, chess.GetFigureAt(x,y));
            MarkSquares();
            IsGameFinished();
            FenPrint.Text = chess.FenRequest();
        }

        void ShowFigure(int x, int y, char figure)
        {
            map[x, y].BackgroundImage = GetFigureImage(figure);
        }

        Image GetFigureImage(char figure)
        {
            switch(figure)
            {
                case 'R': return Properties.Resources.wR;
                case 'N': return Properties.Resources.wN;
                case 'B': return Properties.Resources.wB;
                case 'Q': return Properties.Resources.wQ;
                case 'K': return Properties.Resources.wK;
                case 'P': return Properties.Resources.wP;

                case 'r': return Properties.Resources.bR;
                case 'n': return Properties.Resources.bN;
                case 'b': return Properties.Resources.bB;
                case 'q': return Properties.Resources.bQ;
                case 'k': return Properties.Resources.bK;
                case 'p': return Properties.Resources.bP;

                default: return null;
            }
        }
        Panel AddPanel(int x, int y)
        {
            Panel panel = new System.Windows.Forms.Panel();
            panel.BackColor = GetColor(x, y);
            panel.Location = GetLocation(x, y);
            panel.Name = "p" + x + y;
            panel.Size = new System.Drawing.Size(SIZE, SIZE);
            panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel.MouseClick += new System.Windows.Forms.MouseEventHandler(panel_MouseClick);
            gameboard.Controls.Add(panel);
            return panel;
        }

        Color GetColor(int x, int y)
        {
            return (x + y) % 2 == 0 ? Color.DarkGray : Color.White;
        }

        void IsGameFinished()
        {
            GameSettings.curColor = chess.ColorRequest();

            MoveInfo.Text = "Ход: " + GameSettings.curColor;
            MoveCount.Text = "№ хода: " + chess.MoveNumRequest();
            shahPrint.Text = null;
            if (GameSettings.curColor == "Черных")
                mover = "Белые";
            else mover = "Черные";
            if (chess.IsCheck())
            {
                shahPrint.Text = "Объявлен Шах";
            }
            if (chess.IsCheck() && chess.GetAllMoves().Count == 0)
            {
                GameResult.Text = "Игра завершена. Количество ходов = " + chess.MoveNumRequest();
                GameResult.Text += "\nПобедили " + mover;
                GameResult.Text += "\nОбъявлен Мат";
                DisableGameElements();
                //Application.Exit();
            }
            if (chess.GetAllMoves().Count == 0 && !chess.IsCheck())
            {
                GameResult.Text = "Игра завершена. Количество ходов = " + chess.MoveNumRequest();
                GameResult.Text += "\nПобедили " + mover;
                GameResult.Text += "\nОбъявлен Пат";
                DisableGameElements();
                //Application.Exit();
            }

        }
        Color GetMarkedColor(int x, int y)
        {
            return (x + y) % 2 == 0 ? Color.LightGreen : Color.LawnGreen;
        }
        Point GetLocation(int x, int y)
        {
            return new Point(SIZE / 2 + x * SIZE, SIZE / 2 + (7 - y) * SIZE);
        }
        void CastlingPaint(int x,int y)
        {
            if (chess.CheckShortCastling(x, y) == "BL" && GameSettings.ShortBlackCastlingIsPossible)
                map[7, 7].BackColor = Color.DeepSkyBlue;
            else if (chess.CheckShortCastling(x, y) == "WH" && GameSettings.ShortWhiteCastlingIsPossible)
                map[7, 0].BackColor = Color.DeepSkyBlue;
            if (chess.CheckLongCastling(x, y) == "BL" && GameSettings.LongBlackCastlingIsPossible)
                map[0, 7].BackColor = Color.DeepSkyBlue;
            else if (chess.CheckLongCastling(x, y) == "WH" && GameSettings.LongWhiteCastlingIsPossible)
                map[0, 0].BackColor = Color.DeepSkyBlue;
        }
        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            string xy = ((Panel)sender).Name.Substring(1);  //01
            int x = xy[0] - '0';
            int y = xy[1] - '0';
            selectedFigure.BackgroundImage = GetFigureImage(chess.GetFigureAt(x, y));
            if (wait)
            {
                wait = false;
                xFrom = x;
                yFrom = y;
                ShowPositions();
                CastlingPaint(x, y);


            }
            else 
            {
                wait = true;
                string figure = chess.GetFigureAt(xFrom, yFrom).ToString();
                string move = figure + ToCoord(xFrom, yFrom) + ToCoord(x, y);
                
                if (x != xFrom || y != yFrom)  chess = chess.Move(move, GameSettings.updatedFen);
                
                ChessPromot(x, y);
                Castling(x,y,figure);
                CheckCastlingMoves(x, y);

                ShowPositions();
                selectedFigure.BackgroundImage = null;
                GameSettings.gameStatus = "play";
            }
        }

        void MarkSquares()
        {
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    map[x, y].BackColor = GetColor(x, y);
            if (wait)
                MarkSquaresFrom();
            else 
                MarkSquaresTo();
        }
        void MarkSquaresFrom()
        {
            foreach (string move in chess.GetAllMoves())
            { 
                int x = move[1] - 'a';
                int y = move[2] - '1';
                map[x, y].BackColor = GetMarkedColor(x, y);

            }
        }

        void MarkSquaresTo()
        {
            string suffix = chess.GetFigureAt(xFrom, yFrom) + ToCoord(xFrom, yFrom);
            foreach (string move in chess.GetAllMoves())    //Pe2e4 xy = e4
            {
                if (move.StartsWith(suffix))
                {
                    int x = move[3] - 'a';
                    int y = move[4] - '1';
                    map[x, y].BackColor = GetMarkedColor(x, y);
                }

            }
        }
        
        string ToCoord(int x, int y)
        {
            return ((char)('a' + x)).ToString() + ((char)('1' + y)).ToString();
        }

        private void Exit(object sender, EventArgs e)
        {
            if (GameSettings.gameStatus == "saved")
            {
                Application.Exit();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Желаете ли вы сохранить прогресс?\n[Да] - сохранение и выход из текущей игры\n[Нет] - выход без сохранения", "Внимание, вы не сохранили текущую игру", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveCurrentGame(sender, e);
                    Application.Exit();
                }
                else Application.Exit();
            }
        }



        void OpenNewGame(object sender, EventArgs e)
        {
            ResetValues();
            chess = new Chess();
            ShowPositions();
            ShowGameElements();
            MarkSquaresFrom();
        }
        void ResetValues()
        {          
            GameSettings.ShortBlackCastlingIsPossible = true;
            GameSettings.ShortWhiteCastlingIsPossible = true;
            GameSettings.LongBlackCastlingIsPossible = true;
            GameSettings.LongWhiteCastlingIsPossible = true;
            GameSettings.curColor = "";
            GameSettings.pawnPromotion = 'z';
        }
        void ClearCastleValues()
        {
            GameSettings.ShortBlackCastlingIsPossible = false;
            GameSettings.ShortWhiteCastlingIsPossible = false;
            GameSettings.LongBlackCastlingIsPossible = false;
            GameSettings.LongWhiteCastlingIsPossible = false;
        }
        private void SaveCurrentGame(object sender, EventArgs e)
        {
            string Path = "settings.txt";

            string[] arStr = File.ReadAllLines(Path);
            string writePath = GameSettings.saveDirectory + "/save_" + arStr[1] + ".txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(chess.FenRequest());
            }
            
            using (StreamWriter sw = new StreamWriter(Path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(GameSettings.saveDirectory);
                sw.WriteLine(Convert.ToInt32(arStr[1])+1);
            }
            GameSettings.gameStatus = "saved";
        }

        private void CopyFen(object sender, EventArgs e)
        {
            Clipboard.SetText(FenPrint.Text);
        }


        void ChessPromot(int x, int y)
        {
            string move;
            if ((y == 7 || y == 0) && (chess.GetFigureAt(x, y) == 'p' || chess.GetFigureAt(x, y) == 'P'))
            {
                move = ToCoord(xFrom, yFrom) + ToCoord(x, y);
                PawnTransform f = new PawnTransform();
                f.Owner = this;
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    chess = chess.PawnPromotion(GameSettings.pawnPromotion + move, GameSettings.updatedFen);
                }
            }
        }

        private void DrawMenu(object sender, EventArgs e)
        {
            Agreement_menu f = new Agreement_menu();
            f.Owner = this;
            if (f.ShowDialog() == DialogResult.Yes)
            {
                GameResult.Text = "Игра завершена. Количество ходов = " + chess.MoveNumRequest();
                GameResult.Text += "\nОбъявлена Ничья";
                DisableGameElements();
            }
        }

        private void Surrender(object sender, EventArgs e)
        {
            GameResult.Text = "Игра завершена. Количество ходов = " + chess.MoveNumRequest();
            if (GameSettings.curColor == "Черных")
                GameResult.Text += "\nПобеда Белых";
            else GameResult.Text += "\nПобеда Черных";
            DisableGameElements();
        }

        void ShowGameElements()
        {
            FenCopyButton.Visible = true;
            FenPrint.Visible = true;
            label1.Visible = true;
            Surrend.Visible = true;
            Offer.Visible = true;
            shahPrint.Visible = true;
            GameResult.Visible = false;
            gameboard.Visible = true;
            MoveCount.Visible = true;
            MoveInfo.Visible = true;
            label2.Visible = true;
            selectedFigure.Visible = true;
        }
        void DisableGameElements()
        {
            FenCopyButton.Visible = false;
            FenPrint.Visible = false;
            label1.Visible = false;
            Surrend.Visible = false;
            Offer.Visible = false;
            shahPrint.Visible = false;
            GameResult.Visible = true;
            gameboard.Visible = false;
            MoveCount.Visible = false;
            MoveInfo.Visible = false;
            label2.Visible = false;
            selectedFigure.Visible = false;
        }

        private void ExitInMainMenu(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Yes;
        }

        void Castling(int x, int y,string fig)
        {
            string figure, move;
            if (fig == "K" || fig == "k")
            {
                if ((x == 0))
                {
                    if (chess.CheckLongCastling(4, 0) == "WH" && y == 0 && GameSettings.LongWhiteCastlingIsPossible)
                    {
                        figure = chess.GetFigureAt(xFrom, yFrom).ToString();
                        move = figure + ToCoord(xFrom, yFrom) + ToCoord(1, yFrom);
                        chess = chess.CastlMove(move, GameSettings.updatedFen, 'n');

                        figure = chess.GetFigureAt(0, 0).ToString();
                        move = figure + ToCoord(0, 0) + ToCoord(2, yFrom);
                        chess = chess.CastlMove(move, GameSettings.updatedFen, 'y');
                        GameSettings.ShortWhiteCastlingIsPossible = false;
                        GameSettings.LongWhiteCastlingIsPossible = false;
                    }
                    if (chess.CheckLongCastling(4, 7) == "BL" && y == 7 && GameSettings.LongBlackCastlingIsPossible)
                    {
                        figure = chess.GetFigureAt(xFrom, yFrom).ToString();
                        move = figure + ToCoord(xFrom, yFrom) + ToCoord(1, yFrom);
                        chess = chess.CastlMove(move, GameSettings.updatedFen, 'n');

                        figure = chess.GetFigureAt(0, 7).ToString();
                        move = figure + ToCoord(0, 7) + ToCoord(2, yFrom);
                        chess = chess.CastlMove(move, GameSettings.updatedFen, 'y');
                        GameSettings.ShortBlackCastlingIsPossible = false;
                        GameSettings.LongBlackCastlingIsPossible = false;
                    }
                }
                if (x == 7)
                {
                    if (chess.CheckShortCastling(4, 0) == "WH" && y == 0 && GameSettings.ShortWhiteCastlingIsPossible)
                    {
                        figure = chess.GetFigureAt(xFrom, yFrom).ToString();
                        move = figure + ToCoord(xFrom, yFrom) + ToCoord(6, yFrom);
                        chess = chess.CastlMove(move, GameSettings.updatedFen, 'n');

                        figure = chess.GetFigureAt(7, 0).ToString();
                        move = figure + ToCoord(7, 0) + ToCoord(5, yFrom);
                        chess = chess.CastlMove(move, GameSettings.updatedFen, 'y');
                        GameSettings.ShortWhiteCastlingIsPossible = false;
                        GameSettings.LongWhiteCastlingIsPossible = false;
                    }
                    if (chess.CheckShortCastling(4, 7) == "BL" && y == 7 && GameSettings.ShortBlackCastlingIsPossible)
                    {
                        figure = chess.GetFigureAt(xFrom, yFrom).ToString();
                        move = figure + ToCoord(xFrom, yFrom) + ToCoord(6, yFrom);
                        chess = chess.CastlMove(move, GameSettings.updatedFen, 'n');

                        figure = chess.GetFigureAt(7, 7).ToString();
                        move = figure + ToCoord(7, 7) + ToCoord(5, yFrom);
                        chess = chess.CastlMove(move, GameSettings.updatedFen, 'y');
                        GameSettings.ShortBlackCastlingIsPossible = false;
                        GameSettings.LongBlackCastlingIsPossible = false;
                    }
                }
            }
            
        }

        void CheckCastlingMoves(int x, int y)
        {            
            if ((chess.GetFigureAt(xFrom, yFrom) == '.') && (chess.GetFigureAt(x, y) == 'R') && (x == 0) && GameSettings.LongWhiteCastlingIsPossible)
            {
                GameSettings.LongWhiteCastlingIsPossible = false;
            }
            if ((chess.GetFigureAt(xFrom, yFrom) == '.') && (chess.GetFigureAt(x, y) == 'R') && (x == 7) && GameSettings.ShortWhiteCastlingIsPossible)
            {
                GameSettings.ShortWhiteCastlingIsPossible = false;
            }
            if ((chess.GetFigureAt(xFrom, yFrom) == '.') && (chess.GetFigureAt(x, y) == 'K') && (GameSettings.ShortWhiteCastlingIsPossible || GameSettings.LongWhiteCastlingIsPossible))
            {
                GameSettings.ShortWhiteCastlingIsPossible = false;
                GameSettings.LongWhiteCastlingIsPossible = false;
            }

            if ((chess.GetFigureAt(xFrom, yFrom) == '.') && (chess.GetFigureAt(x, y) == 'r') && (x == 0) && GameSettings.LongBlackCastlingIsPossible)
            {
                GameSettings.LongBlackCastlingIsPossible = false;
            }
            if ((chess.GetFigureAt(xFrom, yFrom) == '.') && (chess.GetFigureAt(x, y) == 'r') && (x == 7) && GameSettings.ShortBlackCastlingIsPossible)
            {
                GameSettings.ShortBlackCastlingIsPossible = false;
            }
            if ((chess.GetFigureAt(xFrom, yFrom) == '.') && (chess.GetFigureAt(x, y) == 'k') && (GameSettings.ShortBlackCastlingIsPossible || GameSettings.LongBlackCastlingIsPossible))
            {
                GameSettings.ShortBlackCastlingIsPossible = false;
                GameSettings.LongBlackCastlingIsPossible = false;
            }
            string row="";
            if (GameSettings.ShortWhiteCastlingIsPossible)
                row += "K";
            if (GameSettings.LongWhiteCastlingIsPossible)
                row += "Q";
            if (GameSettings.ShortBlackCastlingIsPossible)
                row += "k";
            if (GameSettings.LongBlackCastlingIsPossible)
                row += "q";
            if (row == "")
                row = "-";
            GameSettings.updatedFen = row;
        }
        
    }
}
