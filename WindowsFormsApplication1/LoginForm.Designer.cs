namespace WindowsFormsApplication1
{
    partial class LoginForm
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
            this.Okbutton = new Smm.Windows.Forms.Button();
            this.UserNametextBox = new Smm.Windows.Forms.TextBox();
            this.PasswordtextBox = new Smm.Windows.Forms.TextBox();
            this.UserNamelabel = new Smm.Windows.Forms.Label();
            this.Passwordlabel = new Smm.Windows.Forms.Label();
            this.pictureBox1 = new Smm.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Okbutton
            // 
            this.Okbutton.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Okbutton.DefultBackColor = System.Drawing.Color.Empty;
            this.Okbutton.Location = new System.Drawing.Point(289, 114);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(93, 26);
            this.Okbutton.TabIndex = 0;
            this.Okbutton.Text = "ورود";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.BaseBackColor = System.Drawing.Color.Orange;
            this.UserNametextBox.DefulatBackColor = System.Drawing.Color.Empty;
            this.UserNametextBox.Location = new System.Drawing.Point(205, 30);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(147, 21);
            this.UserNametextBox.TabIndex = 2;
            this.UserNametextBox.Text = "123";
            this.UserNametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.BaseBackColor = System.Drawing.Color.Orange;
            this.PasswordtextBox.DefulatBackColor = System.Drawing.Color.Empty;
            this.PasswordtextBox.Location = new System.Drawing.Point(205, 65);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(147, 21);
            this.PasswordtextBox.TabIndex = 3;
            this.PasswordtextBox.Text = "123";
            this.PasswordtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Location = new System.Drawing.Point(355, 33);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(57, 13);
            this.UserNamelabel.TabIndex = 4;
            this.UserNamelabel.Text = "نام كاربري:";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Location = new System.Drawing.Point(364, 68);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(48, 13);
            this.Passwordlabel.TabIndex = 5;
            this.Passwordlabel.Text = "رمز ورود:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Login_Manager;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 110);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(449, 146);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UserNametextBox);
            this.Controls.Add(this.Okbutton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Controls.SetChildIndex(this.Okbutton, 0);
            this.Controls.SetChildIndex(this.UserNametextBox, 0);
            this.Controls.SetChildIndex(this.PasswordtextBox, 0);
            this.Controls.SetChildIndex(this.UserNamelabel, 0);
            this.Controls.SetChildIndex(this.Passwordlabel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Smm.Windows.Forms.Button Okbutton;
        private Smm.Windows.Forms.TextBox UserNametextBox;
        private Smm.Windows.Forms.TextBox PasswordtextBox;
        private Smm.Windows.Forms.Label UserNamelabel;
        private Smm.Windows.Forms.Label Passwordlabel;
        private Smm.Windows.Forms.PictureBox pictureBox1;
    }
}
