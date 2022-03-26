using System;
using System.Windows.Forms;
using System.Threading;

namespace lab1
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            //this.database = database;
        }

        public void Open()
        {
            ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChoosingOptionForm StartForm = new ChoosingOptionForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginEdit.Text == "" || PasswordEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                ClientForm StartForm = new ClientForm();
                Thread myThread1 = new Thread(StartForm.Open);
                myThread1.Start();
                this.Close();
                this.Dispose();
            }
        }
    }
}
