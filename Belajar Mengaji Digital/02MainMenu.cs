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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(0,0);
        }

        private void pictureBox1_Click(object sender, EventArgs e) //Huruf Hijaiyah form
        {
            HurufHijaiyah huruf = new HurufHijaiyah();
            huruf.MdiParent = this.ParentForm;
            this.Hide();
            huruf.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e) //Iqra 1 form
        {
            Iqra1 satu = new Iqra1();
            satu.MdiParent = this.ParentForm;
            this.Hide();
            satu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //Iqra 2 form
        {
            Iqra2 dua = new Iqra2();
            dua.MdiParent = this.ParentForm;
            this.Hide();
            dua.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e) //Iqra 3 form
        {
            _09Iqra3 tiga = new _09Iqra3();
            tiga.MdiParent = this.ParentForm;
            this.Hide();
            tiga.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e) //Final Quiz form
        {
            _11FinalQuiz formfq = new _11FinalQuiz();
            formfq.MdiParent = this.ParentForm;
            this.Hide();
            formfq.Show();
        }

        private void button1_Click_1(object sender, EventArgs e) //Exit
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin keluar?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
