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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void SavingButton_Click(object sender, EventArgs e)
        {
            if (SavingEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }

        }

        private void CashOutButton_Click(object sender, EventArgs e)
        {
            if (CashOutEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
        }

        private void TransferEdit_Click(object sender, EventArgs e)
        {
            if (TransferSumEdit.Text == "" || IdOfRecepientEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
        }

        private void AccumulationButton_Click(object sender, EventArgs e)
        {
            if (AccumulationEdit.Text == "" || AccumulationPercentEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
        }

        private void FreezingButton_Click(object sender, EventArgs e)
        {
            if (DaysOfFreezingEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
        }
    }
}
