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
    public partial class N3LoteMontagem : Form
    {
        public N3LoteMontagem()
        {
            InitializeComponent();
        }

        private void loteMontagemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loteMontagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void loteMontagemBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.loteMontagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void N3LoteMontagem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intelliFactoryDatabaseDataSet1.LoteMontagem' table. You can move, or remove it, as needed.
            this.loteMontagemTableAdapter.Fill(this.intelliFactoryDatabaseDataSet1.LoteMontagem);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loteMontagemBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loteMontagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);
            MessageBox.Show("Dados Salvo com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.loteMontagemBindingSource.RemoveCurrent();
            MessageBox.Show("Dados Removido com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loteMontagemBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loteMontagemBindingSource.MovePrevious();
        }

        private void horaMontagemTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
