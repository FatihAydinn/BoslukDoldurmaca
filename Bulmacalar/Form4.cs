using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulmacalar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;

        }
        int sayac = 0;
        int sayac1 = 0;
        int sayac2 = 1;
        int sayac3 = 0;
        int sayac4 = 0;
        int sayac5 = 0;
        int sayac6 = 0;
        int sayac7 = 0;
        int sayac8 = 0;

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            Form4 form4 = new Form4();
            if (e.KeyCode == Keys.Up && pictureBox1.Location.Y > 100)
            {
                pictureBox1.Top -= 200;
                if (pictureBox1.Location == new System.Drawing.Point(410, 70))
                {
                    sayac = sayac + 1;
                    label1.Text = sayac.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(760, 70))
                {
                    sayac1 = sayac1 + 1;
                    label2.Text = sayac1.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(60, 70))
                {
                    sayac2 = sayac2 + 1;
                    label3.Text = sayac2.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(60, 270))
                {
                    sayac3 = sayac3 + 1;
                    label4.Text = sayac3.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(410, 270))
                {
                    sayac4 = sayac4 + 1;
                    label5.Text = sayac4.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(760, 270))
                {
                    sayac5 = sayac5 + 1;
                    label6.Text = sayac5.ToString();
                }
            }
            if (e.KeyCode == Keys.Down && pictureBox1.Location.Y < 400)
            {
                pictureBox1.Top += 200;
                if (pictureBox1.Location == new System.Drawing.Point(60, 270))
                {
                    sayac3 = sayac3 + 1;
                    label4.Text = sayac3.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(410, 270))
                {
                    sayac4 = sayac4 + 1;
                    label5.Text = sayac4.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(760, 270))
                {
                    sayac5 = sayac5 + 1;
                    label6.Text = sayac5.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(60, 470))
                {
                    sayac6 = sayac6 + 1;
                    label9.Text = sayac6.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(410, 470))
                {
                    sayac7 = sayac7 + 1;
                    label8.Text = sayac7.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(760, 470))
                {
                    sayac8 = sayac8 + 1;
                    label7.Text = sayac8.ToString();
                }
            }
            if (e.KeyCode == Keys.Left && pictureBox1.Location.X > 100)
            {
                pictureBox1.Left -= 350;
                if (pictureBox1.Location == new System.Drawing.Point(410, 70))
                {
                    sayac = sayac + 1;
                    label1.Text = sayac.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(760, 70))
                {
                    sayac1 = sayac1 + 1;
                    label2.Text = sayac1.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(60, 70))
                {
                    sayac2 = sayac2 + 1;
                    label3.Text = sayac2.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(60, 270))
                {
                    sayac3 = sayac3 + 1;
                    label4.Text = sayac3.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(410, 270))
                {
                    sayac4 = sayac4 + 1;
                    label5.Text = sayac4.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(60, 470))
                {
                    sayac6 = sayac6 + 1;
                    label9.Text = sayac6.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(410, 470))
                {
                    sayac7 = sayac7 + 1;
                    label8.Text = sayac7.ToString();
                }
            }
            if (e.KeyCode == Keys.Right && pictureBox1.Location.X < 500)
            {

                pictureBox1.Left += 350;
                if (pictureBox1.Location == new System.Drawing.Point(410, 70))
                {
                    sayac = sayac + 1;
                    label1.Text = sayac.ToString();
                    //label10.BackColor = Color.Black;
                }
                if (pictureBox1.Location == new System.Drawing.Point(760, 70))
                {
                    sayac1 = sayac1 + 1;
                    label2.Text = sayac1.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(410, 270))
                {
                    sayac4 = sayac4 + 1;
                    label5.Text = sayac4.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(760, 270))
                {
                    sayac5 = sayac5 + 1;
                    label6.Text = sayac5.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(410, 470))
                {
                    sayac7 = sayac7 + 1;
                    label8.Text = sayac7.ToString();
                }
                if (pictureBox1.Location == new System.Drawing.Point(760, 470))
                {
                    sayac8 = sayac8 + 1;
                    label7.Text = sayac8.ToString();
                }
            }
            if (sayac2 == 1)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Nokta\\kırmızınokta.png";
            }
            if (sayac == 1)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Nokta\\kırmızınokta.png";
            }
            if (sayac1 == 1)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Nokta\\kırmızınokta.png";
            }
            if (sayac3 == 1)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Nokta\\kırmızınokta.png";
            }
            if (sayac4 == 1)
            {
                pictureBox7.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Nokta\\kırmızınokta.png";
            }
            if (sayac5 == 1)
            {
                pictureBox8.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Nokta\\kırmızınokta.png";
            }
            if (sayac6 == 1)
            {
                pictureBox6.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Nokta\\kırmızınokta.png";
            }
            if (sayac7 == 1)
            {
                pictureBox9.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Nokta\\kırmızınokta.png";
            }
            if (sayac8 == 1)
            {
                pictureBox10.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Nokta\\kırmızınokta.png";
            }

            if (sayac == 2 || sayac1 == 2 || sayac2 == 2 || sayac3 == 2 || sayac4 == 2 || sayac5 == 2 || sayac6 == 2 || sayac7 == 2 || sayac8 == 2)
            {
                if (MessageBox.Show("Aynı noktadan 2 kez geçemezsin!\n Tekrar Oynamak İster Misin?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    this.Hide();
                    form4.Show();
                }
                else
                {
                    this.Hide();
                }
            }

            if (pictureBox1.Location == new System.Drawing.Point(760, 470))
            {
                if (sayac == 1 && sayac1 == 1 && sayac2 == 1 && sayac3 == 1 && sayac4 == 1 && sayac5 == 1 && sayac6 == 1 && sayac7 == 1 && sayac8 == 1)
                {
                    if (MessageBox.Show("Kazandın!\n Tekrar oynamak ister misin?", "!!TEBRİKLER!!", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                    {
                        this.Hide();
                        form4.Show();
                    }
                    else
                    {
                        this.Hide();
                    }

                }
                else
                {
                    if (MessageBox.Show("Bütün noktaları ziyaret etmelisin.\n Tekrar Oynamak İster Misin?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        this.Hide();
                        form4.Show();
                    }
                    else
                    {
                        this.Hide();
                    }
                }
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
