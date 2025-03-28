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

        struct squadra
        {
            public string sq;
            public int gol;

            public squadra(string scasa, int ggol)
            {
                sq = scasa;
                gol = ggol;
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
            }
            catch
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

        private void btn_totale_gol_Click(object sender, EventArgs e)
        {
            int gol = 0;
            for (int i = 0; i < cont; i++)
            {
                gol += part[i].gol_casa + part[i].gol_tras;
            }
            MessageBox.Show($"i gol segnati in totale nel campionato sono: {gol}");
        }

        private void btn_partita_piu_gol_Click(object sender, EventArgs e)
        {
            int[] gol = new int[1000];
            int max = 0;
            string sq_casa = "";
            string sq_tras = "";
            for (int i = 0; i < cont; i++)
            {
                gol[i] = part[i].gol_casa + part[i].gol_tras;
            }

            for (int i = 0; i < cont; i++)
            {
                if (gol[i] > max)
                {
                    max = gol[i];
                    sq_casa = part[i].squadra_casa;
                    sq_tras = part[i].squadra_tras;

                }
            }

            MessageBox.Show($"la partita con il numero di gol massimi è {sq_casa} vs {sq_tras} con un totale di {max.ToString()} gol");
        }

        private void btn_squadra_max_Click(object sender, EventArgs e)
        {
            squadra[] squadra = new squadra[1000];
            int conty = 0;
            string sq = "";
            int max_gol = 0;

            for (int i = 0; i < cont; i++)
            {
                bool trovato_casa = false;
                bool trovato_tras = false;
                for (int j = 0; j < conty; j++)
                {
                    if (part[i].squadra_casa == squadra[j].sq)
                    {
                        trovato_casa = true;
                        squadra[conty].gol += part[i].gol_casa;
                    }
                    
                    if (part[i].squadra_tras == squadra[j].sq)
                    {
                        trovato_tras = true;
                        squadra[conty].gol += part[i].gol_tras;
                    }


                }
                if(!trovato_casa)
                {
                    squadra[conty] = new squadra(part[conty].squadra_casa, part[conty].gol_casa);
                    conty++;
                }
                if (!trovato_tras)
                {
                    squadra[conty] = new squadra(part[conty].squadra_tras, part[conty].gol_tras);
                    conty++;
                }
            }
            

            for (int i = 0; i < cont; i++)
            {
                if (squadra[i].gol > max_gol)
                {
                    max_gol = squadra[i].gol;
                    sq = squadra[i].sq;
                }
            }

            MessageBox.Show($"la squadra con il maggior numero di gol è {sq} con un totale di {max_gol}");
        }

        private void btn_cerca_squadra_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            int[] trov = new int[1000];
            int conti = 0;
            try
            {
                f.ShowDialog();
                if (DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("ok");
                }

                for (int i = 0; i < cont; i++)
                {
                    if (part[i].squadra_casa == f.testo || part[i].squadra_tras == f.testo)
                    {
                        trov[conti] = i;
                        conti++;
                    }
                }

                displaysq(trov, conti);

            }
            catch
            {
                MessageBox.Show("errore");
            }
        }

        private void displaysq(int[] trov, int conti)
        {
            string output = "";
            for (int i = 0; i < conti; i++)
            {
                output += $"{part[trov[i]].squadra_casa}, {part[trov[i]].squadra_tras}, {part[trov[i]].gol_casa}, {part[trov[i]].gol_tras} \n";
            }
            MessageBox.Show(output);
        }
    }
}
