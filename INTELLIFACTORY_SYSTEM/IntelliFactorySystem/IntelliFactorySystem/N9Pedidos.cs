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
    public partial class N9Pedidos : Form
    {
        public N9Pedidos()
        {
            InitializeComponent();
        }

        private void controlePedidoCompraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.controlePedidoCompraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void N9Pedidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intelliFactoryDatabaseDataSet1.ControlePedidoCompra' table. You can move, or remove it, as needed.
            this.controlePedidoCompraTableAdapter.Fill(this.intelliFactoryDatabaseDataSet1.ControlePedidoCompra);

        }

        private void valorPedidoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorPedidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.controlePedidoCompraBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.controlePedidoCompraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);
            MessageBox.Show("Dados Salvos com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.controlePedidoCompraBindingSource.RemoveCurrent();
            MessageBox.Show("Dados Removidos com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controlePedidoCompraBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controlePedidoCompraBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
