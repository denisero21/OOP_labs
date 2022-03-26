using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab1
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void CreditButton_Click(object sender, EventArgs e)
        {
            CreditForm StartForm = new CreditForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            //this.Close();
            //this.Dispose();
        }

        private void InstallmentButton_Click(object sender, EventArgs e)
        {
            InstallmentForm StartForm = new InstallmentForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            //this.Close();
            //this.Dispose();
        }

        private void OpenAccountButton_Click(object sender, EventArgs e)
        {
            if(SumEdit.Text == "" || BankBox.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all the fields.");
            }
            else
            {
                

            }
        }
    }
}
