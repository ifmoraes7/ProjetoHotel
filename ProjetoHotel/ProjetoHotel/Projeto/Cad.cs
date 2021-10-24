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
        FormCadHosp cadHosp = new FormCadHosp();
        FormCadFun cadFun = new FormCadFun();
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
            
            OpenForm(cadHosp);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenForm(cadFun);

        }
        private void OpenForm(Form form)
        {
            form.Show();
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Visible = true;
            form.BringToFront();
            form.WindowState = FormWindowState.Maximized;
        }


    }
}
