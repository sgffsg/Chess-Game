using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame;

namespace WindowsChess
{
    public static class GameSettings
    {
        public static string saveDirectory;
        public static string gameStatus;
        public static string fenToLoad;
        public static string curColor;
        public static string updatedFen;
        public static char pawnPromotion;
        public static bool ShortWhiteCastlingIsPossible = true;
        public static bool LongWhiteCastlingIsPossible = true;
        public static bool ShortBlackCastlingIsPossible = true;
        public static bool LongBlackCastlingIsPossible = true;
    }
}
