namespace SuperMarket
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metrobtn2 = new MetroFramework.Controls.MetroButton();
            this.metrotxt2 = new MetroFramework.Controls.MetroTextBox();
            this.metrobtn1 = new MetroFramework.Controls.MetroButton();
            this.metrotxt1 = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metrobtn2
            // 
            this.metrobtn2.BackColor = System.Drawing.Color.Red;
            this.metrobtn2.ForeColor = System.Drawing.Color.White;
            this.metrobtn2.Location = new System.Drawing.Point(415, 321);
            this.metrobtn2.Name = "metrobtn2";
            this.metrobtn2.Size = new System.Drawing.Size(106, 33);
            this.metrobtn2.Style = MetroFramework.MetroColorStyle.Green;
            this.metrobtn2.TabIndex = 4;
            this.metrobtn2.Text = "خروج";
            this.metrobtn2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metrobtn2.UseCustomBackColor = true;
            this.metrobtn2.UseCustomForeColor = true;
            this.metrobtn2.UseSelectable = true;
            this.metrobtn2.UseStyleColors = true;
            this.metrobtn2.Click += new System.EventHandler(this.metrobtn2_Click);
            // 
            // metrotxt2
            // 
            // 
            // 
            // 
            this.metrotxt2.CustomButton.Image = null;
            this.metrotxt2.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.metrotxt2.CustomButton.Name = "";
            this.metrotxt2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metrotxt2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metrotxt2.CustomButton.TabIndex = 1;
            this.metrotxt2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrotxt2.CustomButton.UseSelectable = true;
            this.metrotxt2.CustomButton.Visible = false;
            this.metrotxt2.ForeColor = System.Drawing.Color.Lime;
            this.metrotxt2.Lines = new string[0];
            this.metrotxt2.Location = new System.Drawing.Point(342, 189);
            this.metrotxt2.MaxLength = 32767;
            this.metrotxt2.Name = "metrotxt2";
            this.metrotxt2.PasswordChar = '●';
            this.metrotxt2.PromptText = "كلمة السر";
            this.metrotxt2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metrotxt2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metrotxt2.SelectedText = "";
            this.metrotxt2.SelectionLength = 0;
            this.metrotxt2.SelectionStart = 0;
            this.metrotxt2.ShortcutsEnabled = true;
            this.metrotxt2.Size = new System.Drawing.Size(250, 30);
            this.metrotxt2.Style = MetroFramework.MetroColorStyle.Green;
            this.metrotxt2.TabIndex = 2;
            this.metrotxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.metrotxt2.UseCustomBackColor = true;
            this.metrotxt2.UseCustomForeColor = true;
            this.metrotxt2.UseSelectable = true;
            this.metrotxt2.UseStyleColors = true;
            this.metrotxt2.UseSystemPasswordChar = true;
            this.metrotxt2.WaterMark = "كلمة السر";
            this.metrotxt2.WaterMarkColor = System.Drawing.Color.Lime;
            this.metrotxt2.WaterMarkFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metrobtn1
            // 
            this.metrobtn1.BackColor = System.Drawing.Color.Blue;
            this.metrobtn1.ForeColor = System.Drawing.Color.White;
            this.metrobtn1.Location = new System.Drawing.Point(342, 256);
            this.metrobtn1.Name = "metrobtn1";
            this.metrobtn1.Size = new System.Drawing.Size(250, 36);
            this.metrobtn1.Style = MetroFramework.MetroColorStyle.Green;
            this.metrobtn1.TabIndex = 3;
            this.metrobtn1.Text = "دخول";
            this.metrobtn1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metrobtn1.UseCustomBackColor = true;
            this.metrobtn1.UseCustomForeColor = true;
            this.metrobtn1.UseMnemonic = false;
            this.metrobtn1.UseSelectable = true;
            this.metrobtn1.UseStyleColors = true;
            this.metrobtn1.Click += new System.EventHandler(this.metrobtn1_Click_1);
            // 
            // metrotxt1
            // 
            // 
            // 
            // 
            this.metrotxt1.CustomButton.Image = null;
            this.metrotxt1.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.metrotxt1.CustomButton.Name = "";
            this.metrotxt1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metrotxt1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metrotxt1.CustomButton.TabIndex = 1;
            this.metrotxt1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrotxt1.CustomButton.UseSelectable = true;
            this.metrotxt1.CustomButton.Visible = false;
            this.metrotxt1.ForeColor = System.Drawing.Color.Lime;
            this.metrotxt1.Lines = new string[0];
            this.metrotxt1.Location = new System.Drawing.Point(342, 132);
            this.metrotxt1.MaxLength = 32767;
            this.metrotxt1.Name = "metrotxt1";
            this.metrotxt1.PasswordChar = '\0';
            this.metrotxt1.PromptText = "اسم المستخدم";
            this.metrotxt1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metrotxt1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metrotxt1.SelectedText = "";
            this.metrotxt1.SelectionLength = 0;
            this.metrotxt1.SelectionStart = 0;
            this.metrotxt1.ShortcutsEnabled = true;
            this.metrotxt1.Size = new System.Drawing.Size(250, 30);
            this.metrotxt1.Style = MetroFramework.MetroColorStyle.Green;
            this.metrotxt1.TabIndex = 1;
            this.metrotxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.metrotxt1.UseCustomBackColor = true;
            this.metrotxt1.UseCustomForeColor = true;
            this.metrotxt1.UseSelectable = true;
            this.metrotxt1.UseStyleColors = true;
            this.metrotxt1.WaterMark = "اسم المستخدم";
            this.metrotxt1.WaterMarkColor = System.Drawing.Color.Lime;
            this.metrotxt1.WaterMarkFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metrotxt1.Click += new System.EventHandler(this.metrotxt1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuperMarket.Properties.Resources.unlock1;
            this.pictureBox1.Location = new System.Drawing.Point(58, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(704, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metrobtn2);
            this.Controls.Add(this.metrotxt2);
            this.Controls.Add(this.metrobtn1);
            this.Controls.Add(this.metrotxt1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "نظام الادارة";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metrobtn2;
        private MetroFramework.Controls.MetroTextBox metrotxt2;
        private MetroFramework.Controls.MetroButton metrobtn1;
        private MetroFramework.Controls.MetroTextBox metrotxt1;
        private System.Windows.Forms.PictureBox pictureBox1;





    }
}