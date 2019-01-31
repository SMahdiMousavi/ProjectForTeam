namespace Smm.Windows.Forms
{
    public class MessageBox
    {
        public MessageBox() : base()
        {

        }

        public void ShowMessageForExitProgram()
        {
            System.Windows.Forms.DialogResult result=
            System.Windows.Forms.MessageBox.Show("آيا از برنامه خارج ميشويد؟","سوال",
            System.Windows.Forms.MessageBoxButtons.YesNo,System.Windows.Forms.MessageBoxIcon.Question,
            System.Windows.Forms.MessageBoxDefaultButton.Button1,
            System.Windows.Forms.MessageBoxOptions.RightAlign|System.Windows.Forms.MessageBoxOptions.RtlReading);
            if (result==System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        public void ShowMessageForCloseForm()
        {
            System.Windows.Forms.DialogResult result =
            System.Windows.Forms.MessageBox.Show("آيا از فرم خارج ميشويد؟", "سوال",
            System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question,
            System.Windows.Forms.MessageBoxDefaultButton.Button1,
            System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MemberwiseClone();
            }
        }
    }
}
