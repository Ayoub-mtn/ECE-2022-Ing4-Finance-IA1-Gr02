
// See https://aka.ms/new-console-template for more information
using Sudoku.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku.Norvige

{
    public class testnor :  ISolverSudoku
    {
        public GridSudoku Solve(GridSudoku s)
        {
            return s.CloneSudoku();
        }
    }
}
