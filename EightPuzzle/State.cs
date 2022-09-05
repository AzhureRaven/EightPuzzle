using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightPuzzle
{
    class State
    {
        public State parent;
        public int[,] num;

        public State(State parent, int[,] num)
        {
            this.parent = parent;
            this.num = num;
        }
    }
}
