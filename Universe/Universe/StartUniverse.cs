using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe
{
    class StartUniverse
    {
        public int[] num = new int[4];
        public Cells[] cell = new Cells[2500];
        public int countCell = 0;

        public void CreationOfLife()
        {
            Random rnd = new Random();
            int numberOfCell = rnd.Next(10, 40);
            for (int i = 0; i < numberOfCell; i++)
            {
                int x = rnd.Next(0, 49);
                int y = rnd.Next(0, 49);

                cell[countCell] = new Cells()
                {
                    id = countCell,
                    xPos = x,
                    yPos = y
                };
                countCell++;
            }
        }

    }
}
