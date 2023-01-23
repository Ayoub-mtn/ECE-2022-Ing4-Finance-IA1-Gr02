
using Sudoku.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku.Norvige

{
class oursolution
{
    // Grille de Sudoku vide
    int[,] grid = new int[9, 9];

    // Fonction pour résoudre la grille de Sudoku
    public void Solve()
    {
        if (!Solve(0, 0))
            Console.WriteLine("La grille ne peut pas être résolue.");
        else
            Print();
    }

    // Fonction récursive pour résoudre la grille de Sudoku
    private bool Solve(int row, int col)
    {
        // Si nous avons atteint la dernière colonne de la dernière ligne, la grille est résolue
        if (row == 9)
        {
            row = 0;
            if (++col == 9)
                return true;
        }

        // Si la case actuelle contient déjà un nombre, passez à la case suivante
        if (grid[row, col] != 0)
            return Solve(row + 1, col);

        // Essayez tous les nombres possibles pour la case actuelle
        for (int num = 1; num <= 9; num++)
        {
            if (IsSafe(row, col, num))
            {
                grid[row, col] = num;
                if (Solve(row + 1, col))
                    return true;
            }
        }

        // Si aucun nombre n'est possible, réinitialisez la case actuelle et revenez en arrière
        grid[row, col] = 0;
        return false;
    }

    // Fonction pour vérifier si un nombre peut être inséré dans une case particulière
    private bool IsSafe(int row, int col, int num)
    {
        // Vérifiez les lignes et les colonnes
        for (int x = 0; x < 9; x++)
        {
            if (grid[row, x] == num || grid[x, col] == num)
                return false;
        }

        // Vérifiez la région 3x3
        int startRow = row - row % 3;
        int startCol = col - col % 3;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (grid[i + startRow, j + startCol] == num)
                    return false;
            }
        }
        return true;
    }

}
}