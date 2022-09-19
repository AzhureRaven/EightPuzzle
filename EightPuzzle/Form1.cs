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
    //Abraham Arthur Fendy - 220116899
    //Kevin Jonathan - 220116926
    //test
    public partial class Form1 : Form
    {
        int expandCtr = 0;//untuk hitung berapa node terbuka
        int recurCtr = 0;//untuk hitung berapa recurring state;
        int reneCtr = 0;//untuk hitung berapa renegade state yaitu yang coba tukar dgn tepi

        public static int[,] start;//start state
        public static int[,] goal;//goal state


        PriorityQueue<State> open = new PriorityQueue<State>();//queue open
        Stack<State> close = new Stack<State>();//stack close
        List<State> successor = new List<State>();//daftar successor
        bool berhasil = true;//boolean apa bfs berhasil
        public Form1()
        {
            InitializeComponent();
        }

        //masukkan start ke root
        public void init_start()
        {
            //baca start
            readTextStart();
            //baca goal
            readTextGoal();
            open.Enqueue(new State(null, start));
            updateExpand();
            //cetak();
        }

        //baca start
        public void readTextStart()
        {
            try
            {
                int row = richTextBoxStart.Lines.Length;
                start = new int[row + 2, row + 2];
                for (int i = 0; i < row + 2; i++)
                {
                    for (int j = 0; j < row + 2; j++)
                    {
                        start[i, j] = -1;
                    }
                }
                for (int i = 0; i < row; i++)
                {
                    string line = richTextBoxStart.Lines[i];
                    string[] angka = line.Split(' ');
                    for (int j = 0; j < angka.Length; j++)
                    {
                        start[i + 1, j + 1] = Convert.ToInt32(angka[j]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        //baca goal
        public void readTextGoal()
        {
            try
            {
                int row = richTextBoxGoal.Lines.Length;
                goal = new int[row + 2, row + 2];
                for (int i = 0; i < row + 2; i++)
                {
                    for (int j = 0; j < row + 2; j++)
                    {
                        goal[i, j] = -1;
                    }
                }
                for (int i = 0; i < row; i++)
                {
                    string line = richTextBoxGoal.Lines[i];
                    string[] angka = line.Split(' ');
                    for (int j = 0; j < angka.Length; j++)
                    {
                        goal[i + 1, j + 1] = Convert.ToInt32(angka[j]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        //run bfs
        public void bfs()
        {
            bool ketemu = false;
            //lakukan looping hingga goal state tercapai atau open kehabisan state
            do
            {
                //cek jawaban
                if (open.Peek().cekKembar(goal))
                {
                    //ketemu jawaban
                    ketemu = true;
                }
                else
                {
                    //expand dan otomatis hapus state dari open
                    expand(open.Dequeue());
                }
            } while (open.Count() != 0 && !ketemu);
            //jika goal state tidak ketemu, berarti gagal
            if (!ketemu)
            {
                berhasil = false;
            }
        }

        //fungsi buka node nomer 4
        public void expand(State state)
        {
            //masukkan ke close
            close.Push(state);
            //tambahkan jumlah node terbuka
            //tampung koordinat x y biar gk repot panggilnya, juga matriksnya 
            int x = state.x;
            int y = state.y;
            int[,] num = state.num;
            //berikut cek empat arah 0 bisa pindah lalu dimasukkan ke dalam successor kalau berhasil, jika satu arah tidak boleh maka sebuah renegade state
            //atas
            if (num[y-1,x] != -1)
            {
                successor.Add(new State(state, tukar(x, y, x, y - 1, num)));
            }
            else
            {
                updateRene();
            }
            //bawah
            if (num[y + 1, x] != -1)
            {
                successor.Add(new State(state, tukar(x, y, x, y + 1, num)));
            }
            else
            {
                updateRene();
            }
            //kanan
            if (num[y, x + 1] != -1)
            {
                successor.Add(new State(state, tukar(x, y, x + 1, y, num)));
            }
            else
            {
                updateRene();
            }
            //kiri
            if (num[y, x - 1] != -1)
            {
                successor.Add(new State(state, tukar(x, y, x - 1, y, num)));
            }
            else
            {
                updateRene();
            }
            //cek successor bukan recurring state
            for (int i = successor.Count - 1; i >= 0; i--)
            {
                bool kembar = false;
                //cek dalam open
                foreach (State st in open.data)
                {
                    if (successor[i].cekKembar(st))
                    {
                        kembar = true;
                        goto kenaKembar;
                    }
                }
                //cek dalam closed
                foreach (State st in close)
                {
                    if (successor[i].cekKembar(st))
                    {
                        kembar = true;
                        goto kenaKembar;
                    }
                }
                //hapus successor yang kembar
                kenaKembar: if (kembar)
                {
                    successor.RemoveAt(i);
                    updateRecur();
                }
            }
            //masukkan successor ke dalam open, update nodes expanded (nodes expanded tidak termasuk recurring dan renegade state)
            for (int i = 0; i < successor.Count; i++)
            {
                open.Enqueue(successor[i]);
                updateExpand();
            }
            successor.Clear();
        }

        //tukar posisi, x y yang punya 0, newX newY punya angka lain, kembalikan kopian matriks
        public int[,] tukar(int x, int y, int newX, int newY, int[,] nm)
        {
            //harus new int terus masukin angka satu per satu gara-gara reference kalau langsung di passing
            int[,] num = new int[nm.GetLength(0), nm.GetLength(1)];
            for (int i = 0; i < nm.GetLength(0); i++)
            {
                for (int j = 0; j < nm.GetLength(1); j++)
                {
                    num[i, j] = nm[i, j];
                }
            }
            int temp = num[y,x];
            num[y, x] = num[newY, newX];
            num[newY, newX] = temp;
            return num;
        }

        //update label nodes expanded
        public void updateExpand()
        {
            label1.Text = "Nodes Expanded: " + ++expandCtr;
            label1.Invalidate();
            label1.Update();
        }

        //update label recurring
        public void updateRecur()
        {
            label2.Text = "Recurring State: " + ++recurCtr;
            label2.Invalidate();
            label2.Update();
        }

        //update label renegade
        public void updateRene()
        {
            label4.Text = "Renegade State: " + ++reneCtr;
            label4.Invalidate();
            label4.Update();
        }

        //cetak step solusi
        public void cetak()
        {
            Stack<State> ans = new Stack<State>();//tampungan jawaban
            //looping menelusuri parent state dari goal sampai start sambil dimasukkan kedalam ans
            State temp;
            temp = open.Peek();
            ans.Push(temp);
            do
            {
                temp = temp.parent;
                ans.Push(temp);
            } while (temp.parent != null);
            //cetak ans
            int depth = 0;//untuk hitung kedalaman solusi
            while (ans.Count != 0)
            {
                richTextBox1.Text += ans.Pop().cetak() + "\n";
                depth++;
            }
            label3.Text = "Depth of Solution: " + depth;
        }

        //jalankan bfs
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            init_start();
            bfs();
            //jika goal state ditemukan, cetak solusi. Jika tidak, tampilkan pesan gagal
            if (!berhasil)
            {
                richTextBox1.Text = "Gagal!";
            }
            else
            {
                cetak();
            }
        }

        //reset menjadi awal
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            open = new PriorityQueue<State>();
            close = new Stack<State>();
            successor = new List<State>();
            berhasil = true;
            expandCtr = 0;
            recurCtr = 0;
            reneCtr = 0;
            label4.Text = "Renegade State: ";
            label3.Text = "Depth of Solution: ";
            label2.Text = "Recurring State: ";
            label1.Text = "Nodes Expanded: ";
            richTextBox1.Text = "";
            richTextBoxClose.Text = "";
            richTextBoxOpen.Text = "";
        }
    }
}
