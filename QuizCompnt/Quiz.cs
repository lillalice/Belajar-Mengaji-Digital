using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Windows;

namespace QuizCompnt
{
    public class Quiz
    {
        int nilai;

        public int Nilaiku
        {
            get { return nilai; }
        }

        public void Nilai(int count, int soal)
        {
            nilai = (count / soal) * 100;
        }
    }
}
