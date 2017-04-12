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
    public partial class _09Iqra3 : Form
    {
        public _09Iqra3()
        {
            InitializeComponent();
        }

        private void lazima_bt_Click_1(object sender, EventArgs e)
        {
            output_tb.Text = lazima_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_2laazimaa);
            sp.Play();
        }

        private void qoonitaati_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = qoonitaati_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_3qoonitaati);
            sp.Play();
        }

        private void roofiati_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = roofiati_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_4roofi_ati);
            sp.Play();
        }

        private void saafilahaa_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = saafilahaa_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_5saafilahaa);
            sp.Play();
        }

        private void fiijiidiha_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = fiijiidiha_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_6fiijiidiha);
            sp.Play();
        }

        private void bidhoniini_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = bidhoniini_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_7bidhoniini);
            sp.Play();
        }

        private void zabaaniyah_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = zabaaniyah_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_8zabaaniyah);
            sp.Play();
        }

        private void janaahika_Click(object sender, EventArgs e)
        {
            output_tb.Text = janaahika.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_9janaahika);
            sp.Play();
        }

        private void waabiina_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = waabiina_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_10waabiina);
            sp.Play();
        }

        private void faaqoruuha_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = faaqoruuha_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_11fa_aqoruuha);
            sp.Play();
        }

        private void yuriiduna_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = yuriiduna_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_12yuriiduna);
            sp.Play();
        }

        private void fiimaakaanuu_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = fiimaakaanuu_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_13fiimaakaanuu);
            sp.Play();
        }

        private void walaayutsiqu_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = walaayutsiqu_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_14walaayutsiqu);
            sp.Play();
        }

        private void yasuuquuna_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = yasuuquuna_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_15yasuuquuna);
            sp.Play();
        }

        private void qoolutaqoosamuu_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = qoolutaqoosamuu_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_16qoolutaqoosamuu);
            sp.Play();
        }

        private void haaruunawamuusa_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = haaruunawamuusa_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_17haaruunawamuusa);
            sp.Play();
        }

        private void famaayakuunulaka_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = famaayakuunulaka_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_18famaayakuunulaka);
            sp.Play();
        }

        private void lahaamaalikuuna_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = lahaamaalikuuna_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_19lahaamaalikuuna);
            sp.Play();
        }

        private void wahuwayaidzuhu_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = wahuwayaidzuhu_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_20wahuwaya_idzuhu);
            sp.Play();
        }

        private void kaatibi_bt_Click(object sender, EventArgs e)
        {
            output_tb.Text = kaatibi_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_1kaatibi);
            sp.Play();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Sembunyikan Latin";
                lb01.Show();
                lb02.Show();
                lb03.Show();
                lb04.Show();
                lb05.Show();
                lb06.Show();
                lb07.Show();
                lb08.Show();
                lb09.Show();
                lb10.Show();
                lb11.Show();
                lb12.Show();
                lb13.Show();
                lb14.Show();
                lb15.Show();
                lb6.Show();
                lb17.Show();
                lb18.Show();
                lb19.Show();
                lb20.Show();
               
                
                
                
              
            }
            else
            {
                checkBox2.Text = "Tampilkan Latin";
                lb01.Hide();
                lb02.Hide();
                lb03.Hide();
                lb04.Hide();
                lb05.Hide();
                lb06.Hide();
                lb07.Hide();
                lb08.Hide();
                lb09.Hide();
                lb10.Hide();
                lb11.Hide();
                lb12.Hide();
                lb13.Hide();
                lb14.Hide();
                lb15.Hide();
                lb6.Hide();
                lb17.Hide();
                lb18.Hide();
                lb19.Hide();
                lb20.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e) //quiz button
        {
            _10iq3Quiz form8 = new _10iq3Quiz();
            form8.MdiParent = this.ParentForm;
            this.Hide();
            form8.Show();
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = null;
            button1.Image = Properties.Resources.lat_g;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.lat;
        }

        private void saafilahaa_bt_Click_1(object sender, EventArgs e)
        {
            output_tb.Text = saafilahaa_bt.Text;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Iq3_5saafilahaa);
            sp.Play();
        }
    }
}
