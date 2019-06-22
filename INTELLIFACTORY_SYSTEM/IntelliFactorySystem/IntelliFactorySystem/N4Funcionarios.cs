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
    public partial class N4Funcionarios : Form
    {
        public N4Funcionarios()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void N4Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intelliFactoryDatabaseDataSet1.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.intelliFactoryDatabaseDataSet1.Funcionario);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.funcionarioBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);
            MessageBox.Show("Dados Salvo com Sucesso", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.funcionarioBindingSource.RemoveCurrent();
            MessageBox.Show("Dados Removidos com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.MovePrevious();
        }
    }
}
