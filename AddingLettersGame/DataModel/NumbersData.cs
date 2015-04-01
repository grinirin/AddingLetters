using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingLettersGame.DataModel
{
    public class NumbersData
    {
        private int[,] totalCells = new int[4, 4];

        public NumbersData()
        {
            InitializeFirstTwoNumbers();
        }

        public List<Data> Cells
        {
            get
            {
                var cells = totalCells.OfType<int>().Select(x => new Data { Value = x});
                return cells.ToList();
            }
        }

        private void InitializeFirstTwoNumbers()
        {
            totalCells[0, 0] = 2;
            totalCells[1, 1] = 4;
        }


    }

    public class Data
    {
        public int Value { get; set; }

    }
}
