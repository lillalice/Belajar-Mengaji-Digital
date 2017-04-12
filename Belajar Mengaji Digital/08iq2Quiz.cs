using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belajar_Mengaji_Digital
{
    public partial class _08iq2Quiz : Form
    {
        double count, soal = 5;
        double hasil;

        public _08iq2Quiz()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //back to material button
        {
            Iqra2 form2 = new Iqra2();
            form2.MdiParent = this.ParentForm;
            this.Hide();
            form2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e) //result button
        {
            //soal 01
            if (rb01a.Checked == true)
            {
                error.SetError(soal01, "jawaban salah!");
            }
            else if (rb01b.Checked == true)
            {
                error.SetError(soal01, "jawaban salah!");
            }
            else if (rb01c.Checked == true)
            {
                count++;
                error.Clear();
            }

            //soal 02
            if (rb02a.Checked == true)
            {
                count++;
                error2.Clear();
            }
            else if (rb02b.Checked == true)
            {
                error2.SetError(soal02, "jawaban salah!");
            }
            else if (rb02c.Checked == true)
            {
                error2.SetError(soal02, "jawaban salah!");
            }

            //soal 03
            if (rb03a.Checked == true)
            {
                error3.SetError(soal03, "jawaban salah!");
            }
            else if (rb03b.Checked == true)
            {
                count++;
                error3.Clear();
            }
            else if (rb03c.Checked == true)
            {
                error3.SetError(soal03, "jawaban salah!");
            }

            //soal 04
            if (rb04a.Checked == true)
            {
                error4.SetError(soal04, "jawaban salah!");
            }
            else if (rb04b.Checked == true)
            {
                error4.SetError(soal04, "jawaban salah!");
            }
            else if (rb04c.Checked == true)
            {
                count++;
                error4.Clear();
            }

            //soal 05
            if (rb05a.Checked == true)
            {
                error5.SetError(soal05, "jawaban salah!");
            }
            else if (rb05b.Checked == true)
            {
                error5.SetError(soal05, "jawaban salah!");
            }
            else if (rb05c.Checked == true)
            {
                count++;
                error5.Clear();
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
