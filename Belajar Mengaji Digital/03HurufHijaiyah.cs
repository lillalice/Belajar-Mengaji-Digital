using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Belajar_Mengaji_Digital
{
    public partial class HurufHijaiyah : Form
    {
        private SoundPlayer sound;
        public HurufHijaiyah()
        {
            InitializeComponent();
        }

        private void hhQuiz_bt_Click(object sender, EventArgs e)
        {
            /*hhQuiz formhhq = new hhQuiz();
            formhhq.Show();
            this.Hide();*/
        }

        private void backtomenu1_Click(object sender, EventArgs e) //back to menu
        {
            MainMenu mmform = new MainMenu();
            mmform.MdiParent = this.ParentForm;
            this.Hide();
            mmform.Show();  
        }

        private void button1_alif_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ا";
            sound = new SoundPlayer(Properties.Resources.hh01_aliif);
            this.sound.Play();
        }

        private void button2_ba_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ب";
            sound = new SoundPlayer(Properties.Resources.hh02_baa);
            this.sound.Play();
        }

        private void button3_ta_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ت";
            sound = new SoundPlayer(Properties.Resources.hh03_taa);
            this.sound.Play();
        }
        private void button4_tsa_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ث";
            sound = new SoundPlayer(Properties.Resources.hh04_tsaa);
            this.sound.Play();
        }

        private void button5_jim_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ج";
            sound = new SoundPlayer(Properties.Resources.hh05_jim);
            this.sound.Play();
        }

        private void button6_h_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ح";
            sound = new SoundPlayer(Properties.Resources.hh06_ha);
            this.sound.Play();
        }

        private void button7_kho_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ﺥ";
            sound = new SoundPlayer(Properties.Resources.hh07_kho);
            this.sound.Play();
        }

        private void button8_dal_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ﺩ";
            sound = new SoundPlayer(Properties.Resources.hh08_dal);
            this.sound.Play();
        }

        private void button9_dzal_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ﺫ";
            sound = new SoundPlayer(Properties.Resources.hh09_dzal);
            this.sound.Play();
        }

        private void button10_ro_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ر";
            sound = new SoundPlayer(Properties.Resources.hh10_ro);
            this.sound.Play();
        }
        private void button11_zai_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ز";
            sound = new SoundPlayer(Properties.Resources.hh11_zai);
            this.sound.Play();
        }

        private void button12_sin_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "س";
            sound = new SoundPlayer(Properties.Resources.hh12_sin);
            this.sound.Play();
        }

        private void button13_syin_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ش";
            sound = new SoundPlayer(Properties.Resources.hh13_syim);
            this.sound.Play();
        }

        private void button14_shod_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ص";
            sound = new SoundPlayer(Properties.Resources.hh14_shot);
            this.sound.Play();
        }

        private void button15_dhot_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ض";
            sound = new SoundPlayer(Properties.Resources.hh15_dod);
            this.sound.Play();
        }

        private void button16_tho_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ط";
            sound = new SoundPlayer(Properties.Resources.hh16_tho);
            this.sound.Play();
        }

        private void button17_zho_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ظ";
            sound = new SoundPlayer(Properties.Resources.hh17_jho);
            this.sound.Play();
        }

        private void button18_ain_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ع";
            sound = new SoundPlayer(Properties.Resources.hh18_ain);
            this.sound.Play();
        }
        private void button19_ghoin_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "غ";
            sound = new SoundPlayer(Properties.Resources.hh19_ghain);
            this.sound.Play();
        }

        private void button20_fa_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ف";
            sound = new SoundPlayer(Properties.Resources.hh20_fa);
            this.sound.Play();
        }

        private void button21_khof_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ق";
            sound = new SoundPlayer(Properties.Resources.hh21_qof);
            this.sound.Play();
        }

        private void button22_kaf_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ك";
            sound = new SoundPlayer(Properties.Resources.hh22_kaf);
            this.sound.Play();
        }

        private void button23_la_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ل";
            sound = new SoundPlayer(Properties.Resources.hh23_lam);
            this.sound.Play();
        }

        private void button24_mim_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "م";
            sound = new SoundPlayer(Properties.Resources.hh24_mim);
            this.sound.Play();
        }

        private void button25_nun_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ن";
            sound = new SoundPlayer(Properties.Resources.hh25_nun);
            this.sound.Play();
        }

        private void button26_waw_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "و";
            sound = new SoundPlayer(Properties.Resources.hh26_waw);
            this.sound.Play();
        }

        private void button27_ha_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ه";
            sound = new SoundPlayer(Properties.Resources.hh27_Ha_Besar);
            this.sound.Play();
        }

        private void button28_lam_alif_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "لا";
            sound = new SoundPlayer(Properties.Resources.hh29_laa);
            this.sound.Play();
        }

        private void button29_hamzah_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ء";
            sound = new SoundPlayer(Properties.Resources.hh28_hamzah);
            this.sound.Play();
        }

        private void button30_ya_Click(object sender, EventArgs e)
        {
            textBox1_output.Text = "ي";
            sound = new SoundPlayer(Properties.Resources.hh30_ya);
            this.sound.Play();
        }

        private void button_mainmenu_MouseHover(object sender, EventArgs e)
        {
            // button_mainmenu.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e) //back to menu button
        {
            MainMenu menu = new MainMenu();
            menu.MdiParent = this.ParentForm;
            this.Hide();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hhQuiz quizhh = new hhQuiz();
            quizhh.MdiParent = this.ParentForm;
            this.Hide();
            quizhh.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Tampilkan Latin";
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                label15.Hide();
                label16.Hide();
                label17.Hide();
                label18.Hide();
                label19.Hide();
                label20.Hide();
                label21.Hide();
                label22.Hide();
                label23.Hide();
                label24.Hide();
                label25.Hide();
                label26.Hide();
                label27.Hide();
                label28.Hide();
                label29.Hide();
                label30.Hide();
                label31.Hide();

            }
            else
            {
                checkBox2.Text = "Sembunyikan Latin";
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                label11.Show();
                label12.Show();
                label13.Show();
                label14.Show();
                label15.Show();
                label16.Show();
                label17.Show();
                label18.Show();
                label19.Show();
                label20.Show();
                label21.Show();
                label22.Show();
                label23.Show();
                label24.Show();
                label25.Show();
                label26.Show();
                label27.Show();
                label28.Show();
                label29.Show();
                label30.Show();
                label31.Show();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

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


        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = null;
            button1.Image = Properties.Resources.lat_g;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.lat;
        }
    }
}
