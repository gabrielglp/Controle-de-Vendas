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
            tabelaClientes.DefaultCellStyle.ForeColor = Color.Black;

            ClienteDAO dao = new ClienteDAO();
            tabelaClientes.DataSource = dao.listarClientes();
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

            tabelaClientes.DataSource = dao.listarClientes();
        }

        private void txtrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            objCliente.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.excluirCliente(objCliente);

            tabelaClientes.DataSource = clienteDAO.listarClientes();
        }

        private void tabelaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dados selecionados

            txtcodigo.Text = tabelaClientes.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaClientes.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaClientes.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaClientes.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaClientes.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelaClientes.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = tabelaClientes.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = tabelaClientes.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = tabelaClientes.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = tabelaClientes.CurrentRow.Cells[9].Value.ToString();
            txtcomp.Text = tabelaClientes.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = tabelaClientes.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = tabelaClientes.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text = tabelaClientes.CurrentRow.Cells[13].Value.ToString();

            tabClientes.SelectedTab = tabPage1;
        }

        private void btneditar_Click(object sender, EventArgs e)
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

            objClent.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(objClent);

            tabelaClientes.DataSource = dao.listarClientes();
        }
    }
}
