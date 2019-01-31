namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.VorodEteleatbutton = new Smm.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VorodEteleatbutton
            // 
            this.VorodEteleatbutton.BaseBackColor = System.Drawing.Color.Yellow;
            this.VorodEteleatbutton.DefultBackColor = System.Drawing.Color.Empty;
            this.VorodEteleatbutton.Location = new System.Drawing.Point(752, 22);
            this.VorodEteleatbutton.Name = "VorodEteleatbutton";
            this.VorodEteleatbutton.Size = new System.Drawing.Size(108, 26);
            this.VorodEteleatbutton.TabIndex = 1;
            this.VorodEteleatbutton.Text = "فرم ورود اطلاعات";
            this.VorodEteleatbutton.UseVisualStyleBackColor = true;
            this.VorodEteleatbutton.Click += new System.EventHandler(this.VorodEteleatbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(872, 430);
            this.Controls.Add(this.VorodEteleatbutton);
            this.Name = "MainForm";
            this.Text = "فرم اصلي برنامه";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Controls.SetChildIndex(this.VorodEteleatbutton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Smm.Windows.Forms.Button VorodEteleatbutton;
    }
}
