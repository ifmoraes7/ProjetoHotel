using ProjetoHotel.Dao;
using ProjetoHotel.Model;
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
    public partial class FormCadHosp : Form
    {
        public FormCadHosp()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadHosp_Click(object sender, EventArgs e)
        {
            HospedeModel hospede = new HospedeModel();
            HospedeDao hospededao = new HospedeDao(); //Cria um novo objeto.

            hospede.Nome = txtNome.Text;
            hospede.CPF = txtCPF.Text;
            hospede.RG = txtRG.Text;
            hospede.Data_de_Nascimento = dateNasc.Value;
            hospede.Genero = comboG.Text;
            hospede.Profissao = txtProf.Text;
            hospede.Estado_civil = comboEC.Text;
            hospede.Telefone = txtTel.Text;
            hospede.Email = txtEmail.Text;
            hospede.CEP = txtCEP.Text;
            hospede.Endereco = txtEnd.Text;
            hospede.Numero = txtNum.Text;
            hospede.Cidade = txtCidade.Text;
            hospede.Estado = txtEstado.Text;

            hospededao.SetHospede(hospede);

        }

        private void comboG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
