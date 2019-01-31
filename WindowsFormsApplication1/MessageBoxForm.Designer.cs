namespace WindowsFormsApplication1
{
    partial class MessageBoxForm
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
            this.Yesbutton = new Smm.Windows.Forms.Button();
            this.Nobutton = new Smm.Windows.Forms.Button();
            this.Messagelabel = new Smm.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Yesbutton
            // 
            this.Yesbutton.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Yesbutton.DefultBackColor = System.Drawing.Color.Empty;
            this.Yesbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Yesbutton.Location = new System.Drawing.Point(241, 63);
            this.Yesbutton.Name = "Yesbutton";
            this.Yesbutton.Size = new System.Drawing.Size(100, 33);
            this.Yesbutton.TabIndex = 1;
            this.Yesbutton.Text = "بله";
            this.Yesbutton.UseVisualStyleBackColor = true;
            this.Yesbutton.Click += new System.EventHandler(this.Yesbutton_Click);
            // 
            // Nobutton
            // 
            this.Nobutton.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Nobutton.DefultBackColor = System.Drawing.Color.Empty;
            this.Nobutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Nobutton.Location = new System.Drawing.Point(117, 63);
            this.Nobutton.Name = "Nobutton";
            this.Nobutton.Size = new System.Drawing.Size(100, 33);
            this.Nobutton.TabIndex = 2;
            this.Nobutton.Text = "خير";
            this.Nobutton.UseVisualStyleBackColor = true;
            this.Nobutton.Click += new System.EventHandler(this.Nobutton_Click);
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Messagelabel.Location = new System.Drawing.Point(78, 9);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(340, 33);
            this.Messagelabel.TabIndex = 3;
            this.Messagelabel.Text = "آيا از برنامه خارج ميشويد؟";
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(462, 103);
            this.Controls.Add(this.Messagelabel);
            this.Controls.Add(this.Nobutton);
            this.Controls.Add(this.Yesbutton);
            this.Name = "MessageBoxForm";
            this.Text = "";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.Controls.SetChildIndex(this.Yesbutton, 0);
            this.Controls.SetChildIndex(this.Nobutton, 0);
            this.Controls.SetChildIndex(this.Messagelabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Smm.Windows.Forms.Button Yesbutton;
        private Smm.Windows.Forms.Button Nobutton;
        private Smm.Windows.Forms.Label Messagelabel;
    }
}
