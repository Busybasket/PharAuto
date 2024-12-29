using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharAuto
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=SQLOLEDB;Data Source=emin.italynorth.cloudapp.azure.com;Initial Catalog=LOCALDB;User ID=emin2;Password=emin;";
            OleDbConnection conn = new OleDbConnection(connectionString);
            Form1.ConnectDB(conn);
            var pass = Form1.CheckCredentials(conn,usernameTextbox.Text,passwordTextbox.Text);
            Form1.DismountDB(conn);
            if (pass) { Form1.CloseUI(this.ParentForm, this); }

        }


        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
