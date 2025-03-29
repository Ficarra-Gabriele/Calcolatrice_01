using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        int N01 = 001001; // Ho scelto un numero che un utente normale non sceglierebbe mai, in modo tale che se un utente seleziona 0 come primo numero non fa confusione il computer
        int N02 = 001001;
        int N03 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void N1_Click(object sender, EventArgs e)
        {
            if (N01 == 001001)
            {
                N01 = 1;
                N11.Text = N01.ToString();
            }
            else
            {
                N02 = 1;
                N12.Text = N02.ToString();
            }
        }

        private void N2_Click(object sender, EventArgs e)
        {
            if (N01 == 001001)
            {
                N01 = 2;
                N11.Text = N01.ToString();
            }
            else
            {
                N02 = 2;
                N12.Text = N02.ToString();
            }
        }

        private void N3_Click(object sender, EventArgs e)
        {
            if (N01 == 001001)
            {
                N01 = 3;
                N11.Text = N01.ToString();
            }
            else
            {
                N02 = 3;
                N12.Text = N02.ToString();
            }
        }

        private void N4_Click(object sender, EventArgs e)
        {
            if (N01 == 001001)
            {
                N01 = 4;
                N11.Text = N01.ToString();
            }
            else
            {
                N02 = 4;
                N12.Text = N02.ToString();
            }
        }

        private void N5_Click(object sender, EventArgs e)
        {
            if (N01 == 001001)
            {
                N01 = 5;
                N11.Text = N01.ToString();
            }
            else
            {
                N02 = 5;
                N12.Text = N02.ToString();
            }
        }

        private void N6_Click(object sender, EventArgs e)
        {
            if (N01 == 001001)
            {
                N01 = 6;
                N11.Text = N01.ToString();
            }
            else
            {
                N02 = 6;
                N12.Text = N02.ToString();
            }
        }

        private void N7_Click(object sender, EventArgs e)
        {
            if (N01 == 001001)
            {
                N01 = 7;
                N11.Text = N01.ToString();
            }
            else
            {
                N02 = 7;
                N12.Text = N02.ToString();
            }
        }

        private void N8_Click(object sender, EventArgs e)
        {
            if (N01 == 001001)
            {
                N01 = 8;
                N11.Text = N01.ToString();
            }
            else
            {
                N02 = 8;
                N12.Text = N02.ToString();
            }
        }

        private void N9_Click(object sender, EventArgs e)
        {
            if (N01 == 001001)
            {
                N01 = 9;
                N11.Text = N01.ToString();
            }
            else
            {
                N02 = 9;
                N12.Text = N02.ToString();
            }
        }

        private void N0_Click(object sender, EventArgs e)
        {
            if (N01 == 001001)
            {
                N01 = 0;
                N11.Text = N01.ToString();
            }
            else
            {
                N02 = 0;
                N12.Text = N02.ToString();
            }
        }

        private void Somma_Click(object sender, EventArgs e)
        {
            if (N01 != 001001 && N02 != 001001)
            {
                N03 = N01 + N02;
            }
        }

        private void Sottrai_Click(object sender, EventArgs e)
        {
            if (N01 != 001001 && N02 != 001001)
            {
                N03 = N02 - N01;
            }
        }

        private void Moltiplica_Click(object sender, EventArgs e)
        {
            if (N01 != 001001 && N02 != 001001)
            {
                N03 = N01 * N02;
            }
        }

        private void Dividi_Click(object sender, EventArgs e)
        {
            if (N01 != 001001 && N02 != 001001)
            {
                N03 = N01 /  N02;
            }
        }
        private void Uguale_Click(object sender, EventArgs e)
        {
            Risultato.Text = N03.ToString();
        }
    }
}
