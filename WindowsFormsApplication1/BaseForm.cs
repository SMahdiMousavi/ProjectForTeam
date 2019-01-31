namespace WindowsFormsApplication1
{
    public partial class BaseForm : System.Windows.Forms.Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public Smm.Windows.Forms.Button MyExitButton
        {
            get
            {
                return Exitbutton;
            }
            set
            {
                Exitbutton = value;
            }
        }

        protected virtual void Exit()
        {
            //Smm.Windows.Forms.MessageBox msg = new Smm.Windows.Forms.MessageBox();
            //msg.Show("شما از برنامه خارج شديد", "پيام");
            //System.Windows.Forms.Application.Exit();
            MessageBoxForm form = new MessageBoxForm();
            form.ShowDialog();

        }

        private void Exitbutton_Click(object sender, System.EventArgs e)
        {
            Exit();
        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
