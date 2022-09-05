using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EightPuzzle
{
    public partial class Form1 : Form
    {
        int expand = 0;
        int[,] start = new int[5, 5]
        {
            {-1,-1,-1,-1,-1 },
            {-1, 1, 7, 4,-1 },
            {-1, 6, 0, 2,-1 },
            {-1, 8, 3, 5,-1 },
            {-1,-1,-1,-1,-1 },
        };
        int[,] goal = new int[5, 5]
        {
            {-1,-1,-1,-1,-1 },
            {-1, 0, 1, 2,-1 },
            {-1, 3, 4, 5,-1 },
            {-1, 6, 7, 8,-1 },
            {-1,-1,-1,-1,-1 },
        };
        //input start dan goal manual di set dalam program. -1 diluar jangan di ubah, hanya yang di dalam
        Queue<State> open = new Queue<State>();
        Stack<State> close = new Stack<State>();
        public Form1()
        {
            InitializeComponent();
            init_start();
        }

        public void init_start()
        {
            open.Enqueue(new State(null, start));
        }

        public void cetak()
        {
            //richTextBox1.Text += open.Dequeue().cetak();
        }
    }
}
