using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerFramework
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string to = txtTo.Text;
            string subject = txtSubject.Text;
            string body = txtBody.Text;

            if(string.IsNullOrEmpty(to) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(body))
            {
                MessageBox.Show("Entries cannot be empty");
            }

            Messenger messenger = new Messenger();
            messenger.Send(to,body,subject);
            MessageBox.Show("Message succes");

            txtBody.Text = "";
            txtSubject.Text = "";
            txtTo.Text = "";
        }

        private void btnSmsForm_Click(object sender, EventArgs e)
        {
            SmsForm frm = new SmsForm();
            frm.Show();
        }
    }
}
