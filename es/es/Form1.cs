using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace es
{
    public partial class Form1 : Form
    {
        struct partita 
        {
            public string squadra_casa;
            public string squadra_tras;
            public int gol_casa;
            public int gol_tras;

            public partita(string scasa, string stras, int gcasa, int gtras) 
            {
                squadra_casa = scasa;
                squadra_tras = stras;
                gol_casa = gcasa;
                gol_tras = gtras;
            }
        }
        string path = @"file.csv";
        partita[] part = new partita[1000];
        public Form1()
        {
            
            InitializeComponent();
            Array form = leggi_format();
            int cont = par();
            display(cont);
        }

        private void display(int cont) 
        {
            lst_visualizza.Items.Clear();
            for (int i = 0; i < cont; i++)
            {
                lst_visualizza.Items.Add(part[i + 1].);
            }
        }

        private int par()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                int cont = 0;
                while (!sr.EndOfStream) 
                {
                    string[] forms = new string[4];
                    char sep = ',';
                    string linea;
                    linea = sr.ReadLine();
                    forms = linea.Split(sep);
                    if (cont != 0)
                    {
                        string nome1;
                        string nome2;
                        int nome3;
                        int nome4;
                        nome1 = forms[0];
                        nome2 = forms[1];
                        nome3 = int.Parse(forms[2]);
                        nome4 = int.Parse(forms[3]);
                        part[cont] = new partita(nome1, nome2, nome3, nome4);
                        cont++;
                    } else {
                        MessageBox.Show("non va");
                        cont++; 
                    }
                }
                return cont;
            }
        }

        private Array leggi_format()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string linea;
                    string[] form = new string[4];
                    char sep = ';';
                    linea = sr.ReadLine();
                    form = linea.Split(sep);
                    return form;
                }
            } catch 
            {
                MessageBox.Show("è esploso tutto");
                return null;
            }
        }
        private void lbl_gol_casa_Click(object sender, EventArgs e)
        {

        }

        
    }
}
