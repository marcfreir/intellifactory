using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelliFactorySystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O sistema encerrou com sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Application.Exit();
        }

        private void componenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N1Componente obj = new N1Componente();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N2Produto obj = new N2Produto();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void loteDeMontagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N3LoteMontagem obj = new N3LoteMontagem();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N4Funcionarios obj = new N4Funcionarios();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N5Clientes obj = new N5Clientes();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N6Fornecedores obj = new N6Fornecedores();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void qualidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N7Qualidade obj = new N7Qualidade();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void garantiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N8Garantia obj = new N8Garantia();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N9Pedidos obj = new N9Pedidos();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N10Relatorio obj = new N10Relatorio();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }
    }
}
