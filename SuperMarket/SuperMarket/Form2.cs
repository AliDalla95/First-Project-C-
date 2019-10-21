using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من رغبتك في تسجيل الخروج", "open form1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.OpenForms[0].Show();
                this.Hide();
            }
        }

        private void metroB3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            this.Hide();
        }

  

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ملفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مساعدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void أعدادقائمةمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

      

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من رغبتك في تسجيل الخروج", "open form1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.OpenForms[0].Show();
                this.Hide();
            }
        }

        private void مساعدةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            this.Hide();
        }

        private void مساعدةToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"بسم الله الرحن الرحيم تم بحمده وفضله . علي دلا", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ملفToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من رغبتك في تسجيل الخروج", "open form1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.OpenForms[0].Show();
                this.Hide();
            }
        }

        private void الموادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void قوائمالبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void لوحةالتحكمToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            this.Hide();
        }

        private void مساعدةToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"بسم الله الرحن الرحيم تم بحمده وفضله . علي دلا", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
