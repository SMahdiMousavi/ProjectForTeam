namespace WindowsFormsApplication1
{
    public partial class MessageBoxForm : WindowsFormsApplication1.BaseForm
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }
     
        private void MessageBoxForm_Load(object sender,System. EventArgs e)
        {

        }

        private void Yesbutton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Nobutton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
