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
    public partial class BankForm : Form
    {
        public BankForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }
    }
}
