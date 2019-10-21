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
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {

        SqlConnection conn = new SqlConnection(@"Data Source=\\.\pipe\MSSQL$SQLEXPRESS\sql\query;Initial Catalog=Data1;Integrated Security=True");


        public Form4()
        {
            InitializeComponent();

        }
 
        private void Form5_Load(object sender, EventArgs e)
        {
            metroCb1.Items.Clear();
            conn.Open();
            string query = "select menu_number from menu";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                metroCb1.Items.Add(reader["menu_number"].ToString());

            }
            conn.Close();

        }

        private void metroL1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2b = new Form2();
            frm2b.Show();
        }

        private void metroCb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query1 = "select  menu_user_name ,menu_mat_number, menu_all  from menu where menu_number = '" + metroCb1.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                metrotxt1.Text = reader1["menu_user_name"].ToString();
            }

            conn.Close();
        }

        private void metrotxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metrotxt1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select menu_number as'رقم العملية' , menu_user_name as 'اسم المشتري', menu_mat_name as 'اسم المادة', menu_mat_number as 'العدد', menu_mat_price as 'السعر', menu_all as ' المجموع '   from menu", conn);
            DataTable db = new DataTable();
            ad.Fill(db);
            dataGridView.DataSource = db;
            conn.Close();


            /*هذه طريقة1 لايجاد مجموع العمود في الداتا كراد فيو ووضعه في صندوق النص رقم3 */
            int sum = 0;
            int j;
            for (j = 0; j < dataGridView.Rows.Count; j++)
            {
                sum += Convert.ToInt32(dataGridView.Rows[j].Cells[3].Value);
            }
            metrotxt2.Text = sum.ToString();


            /*هذه طريقة2 لايجاد مجموع عمود في الداتا كراد فيو ووضعه في صندوق النص رقم3
            */
            //ماعرفتها



            //هلق مجموع العمود الأخير
            int sum1 = 0;
            int s;
            for (s = 0; s < dataGridView.Rows.Count; s++)
            {
                sum1 += Convert.ToInt32(dataGridView.Rows[s].Cells[5].Value);
            }
            metrotxt3.Text = sum1.ToString();
            conn.Close();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            conn.Open();

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string query = "delete from menu";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            //
            //
            conn.Open();

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string query = "insert into menu values ('" + Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value) + "','" + dataGridView.Rows[i].Cells[1].Value + "','" + dataGridView.Rows[i].Cells[2].Value + "','" + Convert.ToInt32(dataGridView.Rows[i].Cells[3].Value) + "','" + Convert.ToInt32(dataGridView.Rows[i].Cells[4].Value) + "','" + Convert.ToInt32(dataGridView.Rows[i].Cells[5].Value) + "' ) " ;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("تمت الاضافة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            dataGridView.Columns.Clear();

            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select menu_number as'رقم العملية' , menu_user_name as 'اسم المشتري', menu_mat_name as 'اسم المادة', menu_mat_number as 'العدد', menu_mat_price as 'السعر', menu_all as ' المجموع '   from menu", conn);
            DataTable db = new DataTable();
            ad.Fill(db);
            dataGridView.DataSource = db;
            conn.Close();


        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            conn.Open();

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string query = "delete from menu where menu_number = '"+dataGridView.CurrentRow.Cells[0].Value+"'  ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("تم الحذف", " حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            /*وهون كل مرة بدي كرر السطور يلي تحت لان بعد كل عملية ع الفيو بتمسحها وبترجع البيانات من اول وجديد
            وبتعرضن لهيك في طريقة اسهل وبالتالي منعمل كلاس فويد ومنسميه وكل مره منستدعيه*/
           
            dataGridView.Columns.Clear();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select menu_number as'رقم العملية' , menu_user_name as 'اسم المشتري', menu_mat_name as 'اسم المادة', menu_mat_number as 'العدد', menu_mat_price as 'السعر', menu_all as ' المجموع '   from menu", conn);
            DataTable db = new DataTable();
            ad.Fill(db);
            dataGridView.DataSource = db;
            conn.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE menu SET   menu_user_name = '" + dataGridView.CurrentRow.Cells[1].Value + "', menu_mat_name = '" + dataGridView.CurrentRow.Cells[2].Value + "', menu_mat_number ='" + Convert.ToInt32(dataGridView.CurrentRow.Cells[3].Value) + "', menu_mat_price = '" + Convert.ToInt32(dataGridView.CurrentRow.Cells[4].Value) + "', menu_all = '" + Convert.ToInt32(dataGridView.CurrentRow.Cells[5].Value) + "' where menu_number = '" + Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value) + "' " ;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("تم التعديل", " تعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            dataGridView.Columns.Clear();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select menu_number as'رقم العملية' , menu_user_name as 'اسم المشتري', menu_mat_name as 'اسم المادة', menu_mat_number as 'العدد', menu_mat_price as 'السعر', menu_all as ' المجموع '   from menu", conn);
            DataTable db = new DataTable();
            ad.Fill(db);
            dataGridView.DataSource = db;
            conn.Close();
        }

        private void dataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }
    }
}
