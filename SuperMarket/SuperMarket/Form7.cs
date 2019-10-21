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

namespace SuperMarket
{
    public partial class Form7 : MetroFramework.Forms.MetroForm
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void metrobtn2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 frm3b = new Form3();
            frm3b.Show();
        }

        private void metrobtn1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=\\.\pipe\MSSQL$SQLEXPRESS\sql\query;Initial Catalog=Data1;Integrated Security=True");
            conn.Open();
            string query = "UPDATE materials SET mat_quan = '" + Convert.ToInt32(metrotxt2.Text) + "' where  mat_name = '" + metrotxt1.Text + "'  ";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.ExecuteNonQuery();
            MessageBox.Show(" تم  ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void metrotxt2_Click(object sender, EventArgs e)
        {

        }
    }
}
