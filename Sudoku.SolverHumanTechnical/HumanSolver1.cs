﻿using Sudoku.Shared;
using System.Collections.Generic;
using System.Linq;
using System;




namespace Sudoku.SolverHumanTechnical
{
    public class HumanSolver1 : ISolverSudoku
    {
        
        GridSudoku ISolverSudoku.Solve(GridSudoku s)
        {
            return s;
        }
    /*
        public void Solve1(GridSudoku s)
        {

            List<List<int>> list_cell = new List<List<int>>();
            foreach (var i in System.Linq.Enumerable.Range(0, 9))
            {
                var ligne = new List<int>(9);
                list_cell.Add(ligne);
                foreach (var j in System.Linq.Enumerable.Range(0, 9))
                {
                   ligne.Add(s.GetCellule(j, i));
                    

                }
            }
            var monTableau = list_cell.Select(l => l.ToArray()).ToArray();
            var monPuzzle = new Puzzle(monTableau, false);
            var monSolver = new Solver(monPuzzle);
            monSolver.DoWork(this, new System.ComponentModel.DoWorkEventArgs(null));

            foreach (var i in System.Linq.Enumerable.Range(0, 9))
            {
                foreach (var j in System.Linq.Enumerable.Range(0, 9))
                {
                    s.SetCell(i, j, monPuzzle.Rows[i][j].Value);

                }
            }


        }*/

    }
}
