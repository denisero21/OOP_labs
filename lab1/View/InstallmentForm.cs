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
    public partial class InstallmentForm : Form
    {
        public InstallmentForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            /*Client StartForm = new Client();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();*/
            this.Close();
            this.Dispose();
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            if (SumEdit.Text == "" || BankBox.SelectedIndex == -1 || MonthsBox.SelectedIndex == -1 || PercentBox.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all the fields.");
            }
            else
            {
                MessageBox.Show("The request has been sent.");
            }
        }
    }
}
