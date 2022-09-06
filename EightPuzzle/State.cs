using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightPuzzle
{
    public class State
    {
        public State parent;
        public int[,] num;
        public int x;
        public int y;

        public State(State parent, int[,] num)
        {
            this.parent = parent;
            this.num = num;
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

    }
}
