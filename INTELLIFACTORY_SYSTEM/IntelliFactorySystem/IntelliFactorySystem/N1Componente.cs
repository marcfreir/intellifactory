using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntelliFactorySystem
{
    public partial class N1Componente : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\INTELLIFACTORY_PROJECT\INTELLIFACTORY_SYSTEM\IntelliFactorySystem\IntelliFactorySystem\IntelliFactoryDatabase.mdf;Integrated Security=True");
        

        public N1Componente()
        {
            InitializeComponent();
        }

        private void componenteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.componenteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void componenteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.componenteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);

        }

        private void NComponente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intelliFactoryDatabaseDataSet1.Componente' table. You can move, or remove it, as needed.
            this.componenteTableAdapter.Fill(this.intelliFactoryDatabaseDataSet1.Componente);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            this.componenteBindingSource.AddNew();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.componenteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.intelliFactoryDatabaseDataSet1);
            MessageBox.Show("Dados Salvo com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.componenteBindingSource.RemoveCurrent();
            MessageBox.Show("Dados Removido com Sucesso!", "Feliz £:¬D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            componenteBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            componenteBindingSource.MovePrevious();
        }

        private void componenteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
