using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Form2: Form
    {
        public string testo { get; set; }
        public DialogResult dialogResult { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            testo = textBox1.Text;
            dialogResult = DialogResult.OK;
            Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
