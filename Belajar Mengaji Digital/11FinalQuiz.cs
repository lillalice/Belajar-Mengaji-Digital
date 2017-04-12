using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.QuizCompnt;

namespace Belajar_Mengaji_Digital
{
    public partial class _11FinalQuiz : Form
    {
        double count, soal = 10;
        double hasil;
        
        public _11FinalQuiz()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) //back to menu button
        {
            MainMenu menu = new MainMenu();
            menu.MdiParent = this.ParentForm;
            this.Hide();
            menu.Show();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Image = null;
            button3.Image = Properties.Resources.kembali_ke_menu2;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.bt_backtomenu;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //soal 01
            if (rb01a.Checked == true)
            {
                error.SetError(soal01_gb, "jawaban salah!");
            }
            else if (rb01b.Checked == true)
            {
                error.SetError(soal01_gb, "jawaban salah!");
            }
            else if (rb01c.Checked == true)
            {
                count++;
                error.Clear();
            }

            //soal 02
            if (rb02a.Checked == true)
            {
                error2.SetError(soal02_gb, "jawaban salah!");
            }
            else if (rb02b.Checked == true)
            {
                error2.SetError(soal02_gb, "jawaban salah!");
            }
            else if (rb02c.Checked == true)
            {
                count++;
                error2.Clear();
            }

            //soal 03
            if (rb03a.Checked == true)
            {
                count++;
                error3.Clear();
            }
            else if (rb03b.Checked == true)
            {
                error3.SetError(soal03_gb, "jawaban salah!");
            }
            else if (rb03c.Checked == true)
            {
                error3.SetError(soal03_gb, "jawaban salah!");
            }

            //soal 04
            if (rb04a.Checked == true)
            {
                error4.SetError(soal04_gb, "jawaban salah!");
            }
            else if (rb04b.Checked == true)
            {
                error4.SetError(soal04_gb, "jawaban salah!");
            }
            else if (rb04c.Checked == true)
            {
                count++;
                error4.Clear();
            }

            //soal 05
            if (rb05a.Checked == true)
            {
                count++;
                error5.Clear();
            }
            else if (rb05b.Checked == true)
            {
                error5.SetError(soal05_gb, "jawaban salah!");
            }
            else if (rb05c.Checked == true)
            {
                error5.SetError(soal05_gb, "jawaban salah!");
            }

            //soal 06
            if (rb06a.Checked == true)
            {
                count++;
                error6.Clear();
            }
            else if (rb06b.Checked == true)
            {
                error6.SetError(soal06_gb, "jawaban salah!");
            }
            else if (rb06c.Checked == true)
            {
                error6.SetError(soal06_gb, "jawaban salah!");
            }

            //soal 07
            if (rb07a.Checked == true)
            {
                count++;
                error7.Clear();
            }
            else if (rb07b.Checked == true)
            {
                error7.SetError(soal07_gb, "jawaban salah!");
            }
            else if (rb07c.Checked == true)
            {
                error7.SetError(soal07_gb, "jawaban salah!");
            }

            //soal 08
            if (rb08a.Checked == true)
            {
                error8.SetError(soal08_gb, "jawaban salah!");
            }
            else if (rb08b.Checked == true)
            {
                error8.SetError(soal08_gb, "jawaban salah!");
            }
            else if (rb08c.Checked == true)
            {
                count++;
                error8.Clear();
            }

            //soal 09
            if (rb09a.Checked == true)
            {
                count++;
                error9.Clear();
            }
            else if (rb09b.Checked == true)
            {
                error9.SetError(soal09_gb, "jawaban salah!");
            }
            else if (rb09c.Checked == true)
            {
                error9.SetError(soal09_gb, "jawaban salah!");
            }

            //soal 10
            if (rb10a.Checked == true)
            {
                error10.SetError(soal10_gb, "jawaban salah!");
            }
            else if (rb10b.Checked == true)
            {
                error10.SetError(soal10_gb, "jawaban salah!");
            }
            else if (rb10c.Checked == true)
            {
                count++;
                error10.Clear();
            }

            Nilai();

            if (hasil == 100)
            {
                MessageBox.Show("Benar Semua! Nilai kamu adalah 100!");
            }
            else
            {
                MessageBox.Show("Masih ada yang salah, nilai kamu adalah " + hasil);
            }

            count = 0;
        }

        public void Nilai()
        {
            hasil = (count / soal) * 100;
        }
    }
}