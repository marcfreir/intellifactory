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
    public partial class N8Garantia : Form
    {
        public N8Garantia()
        {
            InitializeComponent();
        }

        private void garantiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.garantiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void N8Garantia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intelliFactoryDatabaseDataSet1.Garantia' table. You can move, or remove it, as needed.
            this.garantiaTableAdapter.Fill(this.intelliFactoryDatabaseDataSet1.Garantia);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.garantiaBindingSource.AddNew();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.garantiaBindingSource.RemoveCurrent();
            MessageBox.Show("Dados removidos com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            garantiaBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            garantiaBindingSource.MovePrevious();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.garantiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);
            MessageBox.Show("Dados Salvos com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
