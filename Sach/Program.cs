using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
    class Program : ChessBoard
    {
        static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard();
            chessBoard.DisplayChessBoard();
        }
    }
}
