using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
	internal class Cell
	{
		public bool IsAlive;
		public Cell RightNeighbor;
		public Cell LeftNeighbor;
		public Cell LowerLeftNeighbor;

		public Cell()
		{
			RightNeighbor = new Cell();
			LeftNeighbor = new Cell();
			LowerLeftNeighbor = new Cell();

		}

		public void Kill()
		{
			IsAlive = false;
		}
	}
}
