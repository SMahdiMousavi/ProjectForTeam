using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : WindowsFormsApplication1.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            MyExitButton.Top = 400;
            MyExitButton.Left = 380;
        }

        private void VorodEteleatbutton_Click(object sender, EventArgs e)
        {
            DataEntryForm form = new DataEntryForm();
            form.ShowDialog();
        }
    }
}
