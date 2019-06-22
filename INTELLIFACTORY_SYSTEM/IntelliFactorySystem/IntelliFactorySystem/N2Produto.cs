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
    public partial class N2Produto : Form
    {
        public N2Produto()
        {
            InitializeComponent();
        }

        private void produtoComputadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoComputadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void N2Produto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intelliFactoryDatabaseDataSet1.ProdutoComputador' table. You can move, or remove it, as needed.
            this.produtoComputadorTableAdapter.Fill(this.intelliFactoryDatabaseDataSet1.ProdutoComputador);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.produtoComputadorBindingSource.AddNew();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoComputadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);
            MessageBox.Show("Dados Salvo com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.produtoComputadorBindingSource.RemoveCurrent();
            MessageBox.Show("Dados Removido com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            produtoComputadorBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            produtoComputadorBindingSource.MovePrevious();
        }
    }
}
