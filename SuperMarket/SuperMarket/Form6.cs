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
    public partial class Form6 : MetroFramework.Forms.MetroForm
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void metroL1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2b = new Form2();
            frm2b.Show();
        }

        private void metrobtn1_Click(object sender, EventArgs e)
        {

        }

        private void metrobtn2_Click(object sender, EventArgs e)
        {

        }

        private void metrobtn2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form3 frm3b = new Form3();
            frm3b.Show();
        }

        private void metrobtn1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=\\.\pipe\MSSQL$SQLEXPRESS\sql\query;Initial Catalog=Data1;Integrated Security=True");
            conn.Open();
            SqlDataAdapter cmd = new SqlDataAdapter (" insert into materials (mat_name,mat_price,mat_made,mat_pro,mat_exp,mat_quan,mat_unit) values ('" + metrotxt1.Text + "','" + metrotxt2.Text + "', '" + metrotxt3.Text + "','" + metrotxt4.Text + "','" + metrotxt5.Text + "','"+metrotxt6.Text+"','" + metrotxt7.Text + "') ", conn);
            cmd.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("تم","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void metrolb6_Click(object sender, EventArgs e)
        {

        }
    }
}
