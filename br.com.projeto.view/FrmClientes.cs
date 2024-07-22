using Controle_de_Vendas.br.com.projeto.dao;
using Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.view
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Cliente objClent = new Cliente();
            objClent.nome = txtnome.Text;
            objClent.rg = txtrg.Text;
            objClent.cpf = txtcpf.Text;
            objClent.email = txtemail.Text;
            objClent.telefone = txttelefone.Text;
            objClent.celular = txtcelular.Text;
            objClent.cep = txtcep.Text;
            objClent.endereco = txtendereco.Text;
            objClent.numero = int.Parse(txtnumero.Text);
            objClent.complemento = txtcomp.Text;
            objClent.bairro = txtbairro.Text;
            objClent.cidade = txtcidade.Text;
            objClent.estado = cbuf.Text;

            ClienteDAO dao = new ClienteDAO();

            dao.cadastraCliente(objClent);
        }

        private void txtrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
