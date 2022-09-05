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
        int expandCtr = 0;//untuk hitung berapa node terbuka
        int[,] start = new int[5, 5]
        {
            {-1,-1,-1,-1,-1 },
            {-1, 1, 7, 4,-1 },
            {-1, 6, 0, 2,-1 },
            {-1, 8, 3, 5,-1 },
            {-1,-1,-1,-1,-1 },
        };//start state
        int[,] goal = new int[5, 5]
        {
            {-1,-1,-1,-1,-1 },
            {-1, 0, 1, 2,-1 },
            {-1, 3, 4, 5,-1 },
            {-1, 6, 7, 8,-1 },
            {-1,-1,-1,-1,-1 },
        };//goal state
        //input start dan goal manual di set dalam program. -1 diluar jangan di ubah, hanya yang di dalam
        Queue<State> open = new Queue<State>();
        Stack<State> close = new Stack<State>();
        List<State> successor = new List<State>();
        public Form1()
        {
            InitializeComponent();
            init_start();
            bfs();
        }

        public void init_start()
        {
            //masukkan
            open.Enqueue(new State(null, start));
        }

        public void bfs()
        {
            //run bfs

        }

        public void expand(State state)
        {

        }

        public void cetak()
        {
            //richTextBox1.Text += open.Dequeue().cetak();
        }
    }
}
