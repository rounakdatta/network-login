using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OK_Button.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://192.168.10.3/connect/PortalMain");
            webBrowser1.Document.GetElementById("LoginUserPassword_auth_username").SetAttribute("value", REGNO_FIELD.Text);
            webBrowser1.Document.GetElementById("LoginUserPassword_auth_password").SetAttribute("value", PWD_FIELD.Text);
            webBrowser1.Document.GetElementById("UserCheck_Login_Button").InvokeMember("click");
        }

        private void PWD_FIELD_TextChanged(object sender, EventArgs e)
        {
            if (REGNO_FIELD.Text.Length == 15 && PWD_FIELD.Text.Length > 0)
                OK_Button.Enabled = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
