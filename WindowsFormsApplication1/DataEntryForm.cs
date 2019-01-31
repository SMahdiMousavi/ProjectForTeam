namespace WindowsFormsApplication1
{
    public partial class DataEntryForm : WindowsFormsApplication1.BaseForm
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        protected override void Exit()
        {
            Smm.Windows.Forms.MessageBox msg = new Smm.Windows.Forms.MessageBox();
            //msg.Show("شما از فرم خارج شديد");
            //this.Close();
            msg.ShowMessageForCloseForm();
            //base.Exit(); 
               
        }
        private void DataEntryForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            MyExitButton.Top = 360;
            MyExitButton.Left = 250;
        }

       
        private void DataEntryForm_Load(object sender, System.EventArgs e)
        {
            

        }
    }
}
