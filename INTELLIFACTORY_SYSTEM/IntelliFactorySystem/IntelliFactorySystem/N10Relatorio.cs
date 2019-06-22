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
    public partial class N10Relatorio : Form
    {
        public N10Relatorio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                      
            textBox1.Clear();
            //this.textBox1.AppendText(Environment.NewLine);
            //this.textBox1.AppendText("Nome do Cliente: \t" + cod + Environment.NewLine);

            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText("RECIBO" + Environment.NewLine);
            textBox1.AppendText("Esta versão ainda não gera relatório---------------------------------------------------------------" + Environment.NewLine);
            //textBox1.AppendText("Nome do Cliente: \t" + DataGridViewTextBoxColumn + Environment.NewLine);
            MessageBox.Show("Essa versão ainda não gera relatório!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
