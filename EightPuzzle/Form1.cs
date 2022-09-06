﻿using System;
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
        int[,] start = new int[,]
        {
            {-1,-1,-1,-1,-1 },
            {-1, 1, 7, 4,-1 },
            {-1, 6, 0, 2,-1 },
            {-1, 8, 3, 5,-1 },
            {-1,-1,-1,-1,-1 },
        };//start state
        int[,] goal = new int[,]
        {
            {-1,-1,-1,-1,-1 },
            {-1, 0, 1, 2,-1 },
            {-1, 3, 4, 5,-1 },
            {-1, 6, 7, 8,-1 },
            {-1,-1,-1,-1,-1 },
        };//goal state
        //input start dan goal manual di set dalam program. -1 ditepi jangan di ubah, hanya yang di dalam
        Queue<State> open = new Queue<State>();//queue open
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
            open.Enqueue(new State(null, start));
            updateLabel();
            //cetak();
        }

        //run bfs
        public void bfs()
        {
            //cek open habis
            if (open.Count != 0)
            {
                //cek jawaban
                if (open.Peek().cekKembar(goal))
                {
                    //ketemu jawaban
                    MessageBox.Show("Test");
                }
                else
                {
                    //expand dan otomatis hapus state dari open
                    expand(open.Dequeue());
                    bfs();//recursive jalan lagi
                }
            }
            else
            {
                berhasil = false;//kondisi gagal
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
            //berikut cek empat arah 0 bisa pindah lalu dimasukkan ke dalam successor kalau berhasil
            //atas
            if (num[y-1,x] != -1)
            {
                successor.Add(new State(state, tukar(x, y, x, y - 1, num)));
            }
            //bawah
            if (num[y + 1, x] != -1)
            {
                successor.Add(new State(state, tukar(x, y, x, y + 1, num)));
            }
            //kanan
            if (num[y, x + 1] != -1)
            {
                successor.Add(new State(state, tukar(x, y, x + 1, y, num)));
            }
            //kiri
            if (num[y, x - 1] != -1)
            {
                successor.Add(new State(state, tukar(x, y, x - 1, y, num)));
            }
            //cek successor bukan recurring state
            for (int i = successor.Count - 1; i >= 0; i--)
            {
                bool kembar = false;
                //cek dalam open
                foreach (State st in open)
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
                kenaKembar: if (kembar)
                {
                    successor.RemoveAt(i);
                }
            }
            //masukkan successor ke dalam open
            for (int i = 0; i < successor.Count; i++)
            {
                open.Enqueue(successor[i]);
                updateLabel();
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
        public void updateLabel()
        {
            label1.Text = "Nodes Expanded: " + ++expandCtr;
        }

        //cetak step solusi
        public void cetak()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            init_start();
            bfs();
            if (!berhasil)
            {
                richTextBox1.Text = "Gagal!";
            }
        }
    }
}
