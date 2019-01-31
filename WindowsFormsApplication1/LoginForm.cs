using System.Data;
using System.Data.SqlClient;
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDatabaseNew;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.Parameters.AddWithValue("@username",UserNametextBox.Text );
            com.Parameters.AddWithValue("@password",PasswordtextBox.Text );
            com.CommandText = "select*from Users where UserName=@username and Password=@password";
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //con.Open();
            Smm.Windows.Forms.MessageBox msg = new Smm.Windows.Forms.MessageBox();
            if (dt.Rows.Count>0)
            {
                MainForm form = new MainForm();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(text:"نام كاربري يا رمز عبور اشتباه است",caption:"خطا",
                    buttons:System.Windows.Forms.MessageBoxButtons.OK,defaultButton:System.Windows.Forms.MessageBoxDefaultButton.Button1,
                    icon:System.Windows.Forms.MessageBoxIcon.Error,
                    options:System.Windows.Forms.MessageBoxOptions.RightAlign|
                    System.Windows.Forms.MessageBoxOptions.RtlReading);
            }
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
