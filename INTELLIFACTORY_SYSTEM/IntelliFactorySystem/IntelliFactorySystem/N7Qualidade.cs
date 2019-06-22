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
    public partial class N7Qualidade : Form
    {
        public N7Qualidade()
        {
            InitializeComponent();
        }

        private void controleQualidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.controleQualidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void N7Qualidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intelliFactoryDatabaseDataSet1.ControleQualidade' table. You can move, or remove it, as needed.
            this.controleQualidadeTableAdapter.Fill(this.intelliFactoryDatabaseDataSet1.ControleQualidade);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.controleQualidadeBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.controleQualidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);
            MessageBox.Show("Dados Salvos com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.controleQualidadeBindingSource.RemoveCurrent();
            MessageBox.Show("Dados Removidos com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controleQualidadeBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controleQualidadeBindingSource.MovePrevious();
        }
    }
}
