using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PopupForgetPassword : Form
    {
        public PopupForgetPassword()
        {
            InitializeComponent();
        }
        private void RjButton_resetPassword_Click(object sender, EventArgs e)
        {
            Account.GetAccounts().SingleOrDefault(acc => acc.AuthenticatedEmail == rjTextBox_email.Texts).RecoveryPassword();
        }
    }
}
