using System;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace PharAuto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
           
        }
        static public void ConnectDB(OleDbConnection conn){
            
            try
            {
                
                conn.Open();
                //MessageBox.Show("Bağlantı başarılı!");
               
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı sırasında hata: " + hata.Message);
                MessageBox.Show($"State: {conn.State}");
            }
        }
        static public void DismountDB(OleDbConnection conn)
        {
            try
            {
                conn.Close();
                //MessageBox.Show("Bağlantı kapatıldı.");
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı kapatılırken hata: " + hata.Message);
                
            }
        }
        static public bool CheckCredentials(Form1 form, OleDbConnection conn, string username, string password)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM dbo.kullanici WHERE username = ? AND sifre = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("sifre", password);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    form.referanslarToolStripMenuItem.Enabled = true;
                    form.hastaKabulToolStripMenuItem.Enabled = true;
                    form.raporlarToolStripMenuItem.Enabled = true;
                    return true;
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking credentials: " + ex.Message);
                return false;
            }
        }

        static public void CloseUI(Form parentForm, UserControl ue)
        {
            parentForm.Controls.Remove(ue);
        }
        static public void OpenUI(Form parentForm, UserControl ue)
        {
            parentForm.Controls.Add(ue);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            referanslarToolStripMenuItem.Enabled = false;
            hastaKabulToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var kullaniciTanimlamaInstance = new kullaniciTanimlama();
            Controls.Add(kullaniciTanimlamaInstance);
            
            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            referanslarToolStripMenuItem.Enabled = false;
            hastaKabulToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
            Controls.Add(login1);
        }
    }
}

