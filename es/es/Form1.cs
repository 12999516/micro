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
        int cont;
        public Form1()
        {
            
            InitializeComponent();
            string[] form = leggi_format();
            cont = par();
            display(cont);
        }

        private void display(int cont) 
        {
            lst_visualizza.Items.Clear();
            for (int i = 1; i < cont; i++)
            {
                lst_visualizza.Items.Add($"{part[i].squadra_casa.PadRight(30)} {part[i].squadra_tras.PadRight(30)} {part[i].gol_casa.ToString().PadRight(20)} {part[i].gol_tras.ToString().PadRight(20)}");
            }
        }

        private int par()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                int cont = 0;
                while (!sr.EndOfStream) 
                {
                    char sep = ';';
                    string linea;
                    linea = sr.ReadLine();
                    string[] forms = linea.Split(sep);
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
                    }
                    cont++;
                }
                return cont;

            }
        }

        private string[] leggi_format()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    char sep = ';';
                    string linea = sr.ReadLine();
                    string[] form = linea.Split(sep);
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

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            string nome1 = txt_squadra_casa.Text;
            string nome2 = txt_squadra_trasferta.Text;
            int nome3 = int.Parse(txt_gol_casa.Text);
            int nome4 = int.Parse(txt_gol_trasferta.Text);



            part[cont] = new partita(nome1, nome2, nome3, nome4);
            cont++;
            display(cont);
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{nome1};{nome2};{nome3};{nome4}");
            }
        }
    }
}
