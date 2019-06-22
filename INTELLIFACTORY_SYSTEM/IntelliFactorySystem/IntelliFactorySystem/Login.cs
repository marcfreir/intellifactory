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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\INTELLIFACTORY_PROJECT\INTELLIFACTORY_SYSTEM\IntelliFactorySystem\IntelliFactorySystem\IntelliFactoryDatabase.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Login = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();

            }

            else
            {
                MessageBox.Show("Por favor cheque seu Login e Password", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            //System.Diagnostics.Process.Start( "Outlook" );
            MessageBox.Show(" Por favor contacte o desenvolvedor! \n E-mail: marcosfreyervinnorsk@gmail.com", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
