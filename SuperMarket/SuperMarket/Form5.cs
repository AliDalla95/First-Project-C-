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
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void metroB2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2b = new Form2();
            frm2b.Show();
        }

        private void metroB1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=\\.\pipe\MSSQL$SQLEXPRESS\sql\query;Initial Catalog=Data1;Integrated Security=True");
            conn.Open();
            if (metroT2.Text == metroT3.Text)
            {
                SqlDataAdapter ad = new SqlDataAdapter("update members set m_pass = '" + metroT3.Text + "' where  m_user = '" + metroT1.Text + "' ", conn);
                ad.SelectCommand.ExecuteNonQuery();
                MessageBox.Show(" تم  ","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("عدم تطابق كلمة السر يرجى اعادة المحاولة","خطأ",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            }
        }
    }
}
