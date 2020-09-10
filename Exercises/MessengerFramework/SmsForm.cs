using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MessengerFramework
{
    public partial class SmsForm : Form
    {
        public SmsForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            const string accountSid = "";
            const string authToken = "";

            TwilioClient.Init(accountSid, authToken);



         
                var message = MessageResource.Create(
                        body: txtMessage.Text,
                        from: new Twilio.Types.PhoneNumber(""),
                        to: new Twilio.Types.PhoneNumber(txtTo.Text)
         );

        }
    }
}
