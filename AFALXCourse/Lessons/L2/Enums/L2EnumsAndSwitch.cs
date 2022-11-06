using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFALXCourse.Lessons.L2.Enums
{
    public class L2EnumsAndSwitch
    {
          public static void Run()
        {
            var whiteQueen = new ChessFigure(ChessFigureTypes.QUEEN, ChessColor.WHITE);

            var blackQueen = new ChessFigure();
            blackQueen.FigureType = ChessFigureTypes.QUEEN;
            blackQueen.FigureColor = ChessColor.BLACK;


            var whiteKing = new ChessFigure
            {
                FigureColor = ChessColor.WHITE,
                FigureType = ChessFigureTypes.KING
               
            };

            GetFiguresType(blackQueen.FigureType);
            GetFiguresType(whiteKing.FigureType);
        }

        



        private static void GetFiguresType(ChessFigureTypes chessFigure)
        {
            switch (chessFigure)
            {
                case ChessFigureTypes.QUEEN:
                    Console.WriteLine("This figure is a queen");
                    break;
                case ChessFigureTypes.KING:
                    Console.WriteLine("This is king");
                    break;
                case ChessFigureTypes.ROOK:
                    Console.WriteLine("This is rook");
                    break;
                case ChessFigureTypes.BISHOP:
                    Console.WriteLine("this is bishop");
                    break;
                 case ChessFigureTypes.KNIGHT:
                    Console.WriteLine("this is knight");
                    break;

            }
        }
    }
}
