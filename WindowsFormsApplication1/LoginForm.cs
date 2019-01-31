namespace WindowsFormsApplication1
{
    public partial class LoginForm : WindowsFormsApplication1.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void Exit()
        {
            base.Exit();
        }

        private void Okbutton_Click(object sender, System.EventArgs e)
        {
            Smm.Windows.Forms.MessageBox msg = new Smm.Windows.Forms.MessageBox();
            if (UserNametextBox.Text == "123" && PasswordtextBox.Text == "123")
            {
                MainForm form = new MainForm();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                msg.ShowMessageForCloseForm();
            }
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
