using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel.Projeto
{
    public partial class Cad : Form
    {
        public Cad()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listarHospedeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarHospedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadHosp cad = new FormCadHosp();

            cad.Show();
            cad.TopLevel = false;
            panel1.Controls.Add(cad);
            cad.Visible = true;
            cad.BringToFront();
            cad.WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
