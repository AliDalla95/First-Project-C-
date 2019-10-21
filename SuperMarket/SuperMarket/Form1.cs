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
using System.Data;

namespace SuperMarket
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

            InitializeComponent();
        }
           
        
        private void metrobtn1_Click_1(object sender, EventArgs e)
                 {
                     SqlConnection conn = new SqlConnection(@"Data Source=\\.\pipe\MSSQL$SQLEXPRESS\sql\query;Initial Catalog=Data1;Integrated Security=True");
                     conn.Open();
                     SqlCommand cmd = new SqlCommand("select count(*) from members where m_user = '" + metrotxt1.Text + "' and m_pass = '" + metrotxt2.Text + "' ", conn);
                     int result = Convert.ToInt32(cmd.ExecuteScalar());
                     if (result > 0)
                     {
                         this.Hide();
                         Form2 frm2 = new Form2();
                         frm2.Show();
                         metrotxt1.Clear();
                         metrotxt2.Clear();
                     }
                     else
                     {
                         MessageBox.Show("أسم المستخدم أو كلمة السر خطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         metrotxt1.Clear();
                         metrotxt2.Clear();
                     }
                     conn.Close();
                 }

        private void metrobtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void metrotxt1_Click(object sender, EventArgs e)
        {

        }
    }
}
