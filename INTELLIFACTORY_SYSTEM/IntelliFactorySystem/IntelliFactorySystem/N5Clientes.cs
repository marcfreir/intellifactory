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
    public partial class N5Clientes : Form
    {
        public N5Clientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void N5Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intelliFactoryDatabaseDataSet1.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.intelliFactoryDatabaseDataSet1.Cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);
            MessageBox.Show("Dados Salvo com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.RemoveCurrent();
            MessageBox.Show("Dados Removidos com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MovePrevious();
        }
    }
}
