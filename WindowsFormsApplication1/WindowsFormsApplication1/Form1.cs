using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calcolatrice : Form
    {
        string numeroImmesso="", storicoNumero="";
        bool virgolaN = false;
        string comando = "DEF";
        double corrente = 0.0, risultato = 0.0;

        public Calcolatrice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            executeLatest();
        }

        private void executeLatest()
        {
            if (numeroImmesso != "")
            {
                corrente = double.Parse(numeroImmesso);
            }
            if(comando=="+")
            {
                risultato = risultato + corrente;
            }
            else if(comando == "-")
            {
                risultato = risultato - corrente;
            }
            else if(comando == "*")
            {
                risultato = risultato * corrente;
            }
            else if(comando == "/")
            {
                risultato = risultato / corrente;
            }
            else if(comando == "DEF")
            {
                risultato = corrente;
            }
            else if (comando == "CL")
            {
                numeroImmesso = " ";
                virgolaN = false;
                immissione.Text = numeroImmesso;
                corrente = 0.0;
                risultato = 0.0;
                comando = "DEF";
            }
            numeroImmesso = "";
        }
        private void b0_Click(object sender, EventArgs e)
        {
            numeroImmesso += "0";
            immissione.Text = numeroImmesso;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            numeroImmesso += "1";
            immissione.Text = numeroImmesso;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            numeroImmesso += "2";
            immissione.Text = numeroImmesso;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            numeroImmesso += "3";
            immissione.Text = numeroImmesso;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            numeroImmesso += "4";
            immissione.Text = numeroImmesso;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            numeroImmesso += "5";
            immissione.Text = numeroImmesso;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            numeroImmesso += "6";
            immissione.Text = numeroImmesso;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            numeroImmesso += "7";
            immissione.Text = numeroImmesso;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            numeroImmesso += "8";
            immissione.Text = numeroImmesso;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            numeroImmesso += "9";
            immissione.Text = numeroImmesso;
        }

        private void virgola_Click(object sender, EventArgs e)
        {
            if(virgolaN == false)
            {
                numeroImmesso += ",";
                immissione.Text = numeroImmesso;
                virgolaN = true;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            comando = "CLE";
            executeLatest();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            executeLatest();
            comando = "  ";
            immissione.Text = "";
            immissione.Text += risultato.ToString();
        }

        private void piu_Click(object sender, EventArgs e)
        {
            //esegue il comando precedente
            executeLatest();
            comando = "+";
            immissione.Text = "";
            immissione.Text = risultato.ToString();
        }

        private void meno_Click(object sender, EventArgs e)
        {
            //esegue il comando precedente
            executeLatest();
            comando = "-";
            immissione.Text = "";
            immissione.Text = risultato.ToString();
        }

        private void per_Click(object sender, EventArgs e)
        {
            //esegue il comando precedente
            executeLatest();
            comando = "*";
            immissione.Text = "";
            immissione.Text = risultato.ToString();
        }

        private void diviso_Click(object sender, EventArgs e)
        {
            //esegue il comando precedente
            executeLatest();
            comando = "/";
            immissione.Text = "";
            immissione.Text = risultato.ToString();
        }
    }
}
