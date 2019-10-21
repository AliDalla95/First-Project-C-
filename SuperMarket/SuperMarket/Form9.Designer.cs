namespace SuperMarket
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.metrobtn2 = new MetroFramework.Controls.MetroButton();
            this.metrobtn1 = new MetroFramework.Controls.MetroButton();
            this.metrotxt1 = new MetroFramework.Controls.MetroTextBox();
            this.metrolbl1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metrobtn2
            // 
            this.metrobtn2.BackColor = System.Drawing.Color.Gold;
            this.metrobtn2.ForeColor = System.Drawing.Color.Red;
            this.metrobtn2.Location = new System.Drawing.Point(303, 163);
            this.metrobtn2.Name = "metrobtn2";
            this.metrobtn2.Size = new System.Drawing.Size(177, 52);
            this.metrobtn2.TabIndex = 32;
            this.metrobtn2.Text = "رجوع";
            this.metrobtn2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metrobtn2.UseCustomBackColor = true;
            this.metrobtn2.UseCustomForeColor = true;
            this.metrobtn2.UseSelectable = true;
            this.metrobtn2.UseStyleColors = true;
            this.metrobtn2.Click += new System.EventHandler(this.metrobtn2_Click);
            // 
            // metrobtn1
            // 
            this.metrobtn1.BackColor = System.Drawing.Color.Gold;
            this.metrobtn1.ForeColor = System.Drawing.Color.Red;
            this.metrobtn1.Location = new System.Drawing.Point(66, 163);
            this.metrobtn1.Name = "metrobtn1";
            this.metrobtn1.Size = new System.Drawing.Size(177, 52);
            this.metrobtn1.TabIndex = 31;
            this.metrobtn1.Text = "تم";
            this.metrobtn1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metrobtn1.UseCustomBackColor = true;
            this.metrobtn1.UseCustomForeColor = true;
            this.metrobtn1.UseSelectable = true;
            this.metrobtn1.UseStyleColors = true;
            this.metrobtn1.Click += new System.EventHandler(this.metrobtn1_Click);
            // 
            // metrotxt1
            // 
            this.metrotxt1.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.metrotxt1.CustomButton.Image = null;
            this.metrotxt1.CustomButton.Location = new System.Drawing.Point(149, 2);
            this.metrotxt1.CustomButton.Name = "";
            this.metrotxt1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metrotxt1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metrotxt1.CustomButton.TabIndex = 1;
            this.metrotxt1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrotxt1.CustomButton.UseSelectable = true;
            this.metrotxt1.CustomButton.Visible = false;
            this.metrotxt1.ForeColor = System.Drawing.Color.Blue;
            this.metrotxt1.Lines = new string[0];
            this.metrotxt1.Location = new System.Drawing.Point(195, 78);
            this.metrotxt1.MaxLength = 32767;
            this.metrotxt1.Name = "metrotxt1";
            this.metrotxt1.PasswordChar = '\0';
            this.metrotxt1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metrotxt1.SelectedText = "";
            this.metrotxt1.SelectionLength = 0;
            this.metrotxt1.SelectionStart = 0;
            this.metrotxt1.ShortcutsEnabled = true;
            this.metrotxt1.Size = new System.Drawing.Size(177, 30);
            this.metrotxt1.Style = MetroFramework.MetroColorStyle.Green;
            this.metrotxt1.TabIndex = 24;
            this.metrotxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metrotxt1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrotxt1.UseCustomBackColor = true;
            this.metrotxt1.UseCustomForeColor = true;
            this.metrotxt1.UseSelectable = true;
            this.metrotxt1.UseStyleColors = true;
            this.metrotxt1.WaterMarkColor = System.Drawing.Color.Blue;
            this.metrotxt1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metrolbl1
            // 
            this.metrolbl1.AutoSize = true;
            this.metrolbl1.BackColor = System.Drawing.Color.White;
            this.metrolbl1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metrolbl1.ForeColor = System.Drawing.Color.ForestGreen;
            this.metrolbl1.Location = new System.Drawing.Point(102, 78);
            this.metrolbl1.Name = "metrolbl1";
            this.metrolbl1.Size = new System.Drawing.Size(51, 25);
            this.metrolbl1.TabIndex = 33;
            this.metrolbl1.Text = "المادة";
            this.metrolbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metrolbl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrolbl1.UseCustomBackColor = true;
            this.metrolbl1.UseCustomForeColor = true;
            this.metrolbl1.UseStyleColors = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 285);
            this.ControlBox = false;
            this.Controls.Add(this.metrobtn2);
            this.Controls.Add(this.metrobtn1);
            this.Controls.Add(this.metrotxt1);
            this.Controls.Add(this.metrolbl1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "حذف مادة";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metrobtn2;
        private MetroFramework.Controls.MetroButton metrobtn1;
        private MetroFramework.Controls.MetroTextBox metrotxt1;
        private MetroFramework.Controls.MetroLabel metrolbl1;
    }
}