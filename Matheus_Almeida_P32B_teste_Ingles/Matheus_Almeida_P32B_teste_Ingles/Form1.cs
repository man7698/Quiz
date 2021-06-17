using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matheus_Almeida_P32B_teste_Ingles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string nome;

        private void button1_Click(object sender, EventArgs e)
        {
            nome = txtnome.Text;
            this.Visible = false;
            questions q = new questions();
            q.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtnome_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtnome.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            resultados r = new resultados();
            r.ShowDialog();
        }
    }
}
