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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //طريقة1
            SqlConnection conn = new SqlConnection(@"Data Source=\\.\pipe\MSSQL$SQLEXPRESS\sql\query;Initial Catalog=Data1;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from materials", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ComboBox1.Items.Add(reader["mat_name"].ToString());
                ComboBox2.Items.Add(reader["mat_name"].ToString());
                ComboBox3.Items.Add(reader["mat_price"].ToString());
                ComboBox4.Items.Add(reader["mat_made"].ToString());
                ComboBox5.Items.Add(reader["mat_pro"].ToString());
                ComboBox6.Items.Add(reader["mat_exp"].ToString());
                ComboBox7.Items.Add(reader["mat_quan"].ToString());
                ComboBox8.Items.Add(reader["mat_unit"].ToString());
                
            }
            conn.Close();

            // طريقة2

            /*SqlConnection conn = new SqlConnection(@"Data Source=\\.\pipe\MSSQL$SQLEXPRESS\sql\query;Initial Catalog=Data1;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from materials", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "materials");*/
            /*
            //اختيار اسم المادة
            ComboBox1.DataSource = ds.Tables["materials"];
            ComboBox1.DisplayMember = "mat_name";
            //اظهار اسمها في هذا الصندوق
            ComboBox2.DataSource = ds.Tables["materials"];
            ComboBox2.DisplayMember = "mat_name";
            //اظهار سعرها
            ComboBox3.DataSource = ds.Tables["materials"];
            ComboBox3.DisplayMember = "mat_price";
            //اظهار المنشأ
            ComboBox4.DataSource = ds.Tables["materials"];
            ComboBox4.DisplayMember = "mat_made";
            //اظهار الانتاج
            ComboBox5.DataSource = ds.Tables["materials"];
            ComboBox5.DisplayMember = "mat_pro";
            //اظهار الانتهاء
            ComboBox6.DataSource = ds.Tables["materials"];
            ComboBox6.DisplayMember = "mat_exp";
            //اظهار الكمية
            ComboBox7.DataSource = ds.Tables["materials"];
            ComboBox7.DisplayMember = "mat_quan";
            //اظهار الوحدة
            ComboBox8.DataSource = ds.Tables["materials"];
            ComboBox8.DisplayMember = "mat_unit";
    
            
            conn.Close();*/



        }

        private void metrobtn1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2b = new Form2();
            frm2b.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox2.SelectedIndex = ComboBox1.SelectedIndex;
            ComboBox3.SelectedIndex = ComboBox1.SelectedIndex;
            ComboBox4.SelectedIndex = ComboBox1.SelectedIndex;
            ComboBox5.SelectedIndex = ComboBox1.SelectedIndex;
            ComboBox6.SelectedIndex = ComboBox1.SelectedIndex;
            ComboBox7.SelectedIndex = ComboBox1.SelectedIndex;
            ComboBox8.SelectedIndex = ComboBox1.SelectedIndex;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox1.SelectedIndex = ComboBox2.SelectedIndex;

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox1.SelectedIndex = ComboBox3.SelectedIndex;

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox1.SelectedIndex = ComboBox4.SelectedIndex;

        }

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox1.SelectedIndex = ComboBox5.SelectedIndex;

        }

        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox1.SelectedIndex = ComboBox6.SelectedIndex;

        }

        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox1.SelectedIndex = ComboBox7.SelectedIndex;

        }

        private void ComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox1.SelectedIndex = ComboBox8.SelectedIndex;

        }

        private void metrobtn2_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
            this.Hide();
        }

        private void metrobtn4_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.ShowDialog();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void metrobtn5_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.ShowDialog();
            this.Hide();
        }

    }
}
