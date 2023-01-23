
// See https://aka.ms/new-console-template for more information
using Sudoku.Shared;

namespace Sudoku.Norvige

{
    public class Class1 :  ISolverSudoku
    {
        public GridSudoku Solve(GridSudoku s)
        {
            return s.CloneSudoku();
        }
    }
}
