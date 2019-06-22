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
    public partial class N6Fornecedores : Form
    {
        public N6Fornecedores()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void N6Fornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intelliFactoryDatabaseDataSet1.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.intelliFactoryDatabaseDataSet1.Fornecedor);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.fornecedorBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);
            MessageBox.Show("Dados Salvo com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.fornecedorBindingSource.RemoveCurrent();
            MessageBox.Show("Dados Removido com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailFornecedorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
