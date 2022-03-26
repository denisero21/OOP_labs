
using System.Windows.Forms;
using System.Threading;

namespace lab1
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            //this.database = database;
        }

        public void Open()
        {
            ShowDialog();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            ChoosingOptionForm StartForm = new ChoosingOptionForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            

            if(NameEdit.Text == "" || SurnameEdit.Text == "" ||
                PatronymicEdit.Text == "" || LoginEdit.Text =="" ||
                PasswEdit.Text == "" || RepPasswEdit.Text == "" ||
                PhoneNumberEdit.Text == "" || EmailEdit.Text == "" ||
                PassportNumberEdit.Text == "" || IdNumbEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields.");
            }
            else if (PasswEdit.Text != RepPasswEdit.Text)
            {
                MessageBox.Show("Passwords don't match");
            }
            else
            {
                MessageBox.Show("You successfully registrated");
                ChoosingOptionForm StartForm = new ChoosingOptionForm();
                Thread myThread1 = new Thread(StartForm.Open);
                myThread1.Start();
                this.Close();
                this.Dispose();
            }

            
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            NameEdit.Text = "";
            SurnameEdit.Text = "";
            PatronymicEdit.Text = "";
            PhoneNumberEdit.Text = "";
            EmailEdit.Text = "";
            PassportNumberEdit.Text = "";
            IdNumbEdit.Text = "";
            LoginEdit.Text = "";
            PasswEdit.Text = "";
            RepPasswEdit.Text = "";
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
