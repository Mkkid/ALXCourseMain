using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFALXCourse.Lessons.L2.Enums
{
    internal class ChessFigure
    {
        public ChessFigureTypes FigureType;
        public ChessColor FigureColor;

        public ChessFigure( ) 
        {

        }

        public ChessFigure(ChessFigureTypes chessFigureType, ChessColor chessColor)
        {
            FigureType = chessFigureType;
            FigureColor = chessColor;
        }
               
    }
}
