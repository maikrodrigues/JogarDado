using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDado
{
    public partial class Form1 : Form
    {
        int v1, v2;
        bool jogador1 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt1.Click += new EventHandler(BClick);
            bt2.Click += new EventHandler(BClick);
            pictureBox1.Visible = false;

            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.TabStop = false;
                }
            }
        }

        private void BClick(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.jogador1 ? "Jogador 2" : "Jogador 1";
            ((Button)sender).Enabled = false;
            jogador1 = !jogador1;
            lbl4.Text = string.Format("{0} é sua vez", jogador1 ? "Jogador 1" : "Jogador 2");
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                int valor = rnd.Next(1, 7);
                lbl5.Text = Convert.ToString(valor);
                v1 = valor;
                MessageBox.Show("Sorteado");
            }
            pictureBox1.Visible = false;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                int valor = rnd.Next(1, 7);
                lbl5.Text = Convert.ToString(valor);
                v2 = valor;
                MessageBox.Show("Sorteado");
                if (v1 > v2)
                {
                    txt1.Text = "Jogador 1";
                }
                else
                    txt1.Text = "Jogador 2";
                if (v1 == v2)
                {
                    txt1.Text = "Empate";
                }
                if (v1 > v2)
                {
                    txt2.Text = "Jogador 1";
                }
                else
                    txt2.Text = "Jogador 2";
                if (v1 == v2)
                {
                    txt2.Text = "Empate";
                }
                if (v1 > v2)
                {
                    txt3.Text = "Jogador 1";
                }
                else
                    txt3.Text = "Jogador 2";
                if (v1 == v2)
                {
                    txt3.Text = "Empate";
                }
            }
            pictureBox1.Visible = false;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
