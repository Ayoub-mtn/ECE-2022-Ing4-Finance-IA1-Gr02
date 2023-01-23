using System;
using System.Collections.Generic;
using Microsoft;

using Sudoku.Shared;

namespace Sudoku.CNN
{
    public class testcnn : ISolverSudoku
    {
        public GridSudoku Solve(GridSudoku s)
        {
            return s.CloneSudoku();
        }
    }
}



