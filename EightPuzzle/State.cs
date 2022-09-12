using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightPuzzle
{
    public class State
    {
        public State parent;//simpanan parent node
        public int[,] num;//matriksnya
        public int x;//koordinat x 0
        public int y;//koordinat y 0
        public int mismatch;//jumlah tile yang gk cocok dgn goal state

        public State(State parent, int[,] num)
        {
            this.parent = parent;
            this.num = num;
            this.mismatch = cekMismatch();
            findZero();
        }

        //cetak matriksnya
        public string cetak()
        {
            string cetakan = "";
            for (int i = 1; i < this.num.GetLength(0)-1; i++)
            {
                for (int j = 1; j < this.num.GetLength(1)-1; j++)
                {
                    cetakan += num[i, j] + " ";
                }
                cetakan += "\n";
            }
            return cetakan;
            //return $"{num[1, 1]} {num[1, 2]} {num[1, 3]}\n" +
            //    $"{num[2, 1]} {num[2, 2]} {num[2, 3]} \n" +
            //    $"{num[3, 1]} {num[3, 2]} {num[3, 3]} \n";
        }

        //untuk cari posisi 0 lalu ditampung x y biar gk repot nanti
        public void findZero()
        {
            for (int i = 0; i < this.num.GetLength(0); i++)
            {
                for (int j = 0; j < this.num.GetLength(1); j++)
                {
                    if (this.num[i, j] == 0)
                    {
                        this.x = j;
                        this.y = i;
                        break;
                    }
                }
            }
        }

        //cek kedua matriks kembar, kembali true kalau kembar
        public bool cekKembar(State state)
        {
            if(this.num.GetLength(0) == state.num.GetLength(0) && this.num.GetLength(1) == state.num.GetLength(1))
            {
                for (int i = 0; i < this.num.GetLength(0); i++)
                {
                    for (int j = 0; j < this.num.GetLength(1); j++)
                    {
                        if (this.num[i, j] != state.num[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            { 
                return false;
            }
        }
        //fungsi sama yang terima matriks saja
        public bool cekKembar(int[,] num)
        {
            if (this.num.GetLength(0) == num.GetLength(0) && this.num.GetLength(1) == num.GetLength(1))
            {
                for (int i = 0; i < this.num.GetLength(0); i++)
                {
                    for (int j = 0; j < this.num.GetLength(1); j++)
                    {
                        if (this.num[i, j] != num[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        //fungsi heuristic untuk cari berapa mismatch dengan goal state
        public int cekMismatch()
        {
            int miss = 0;
            if (this.num.GetLength(0) == Form1.goal.GetLength(0) && this.num.GetLength(1) == Form1.goal.GetLength(1))
            {
                for (int i = 0; i < this.num.GetLength(0); i++)
                {
                    for (int j = 0; j < this.num.GetLength(1); j++)
                    {
                        if (this.num[i, j] != Form1.goal[i, j])
                        {
                            miss++;
                        }
                    }
                }
            }
            else
            {
                return -1;
            }
            return miss;
        }

    }
}
