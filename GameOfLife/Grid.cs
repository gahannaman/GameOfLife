using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
	internal class Grid
	{
		public Cell[][] Cell;
		private int width = 8;
		private int height = 4;

		public Grid()
		{
			Cell = new Cell[width][];

			for (int i = 0; i < width; i++)
			{
				Cell[i] = new Cell[height];

			}
		}

		public AnimateCell(int row, int column)
		{
			Cell[row][column].IsAlive = true;
		}

		public KillCell(int row, int column)
		{
			Cell[row][column].IsAlive = false;
		}
	}
}
