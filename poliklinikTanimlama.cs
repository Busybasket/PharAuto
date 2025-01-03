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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharAuto
{
    public partial class poliklinikTanimlama : UserControl
    {
        private DataSet ds = new DataSet();

        public poliklinikTanimlama()
        {
            InitializeComponent();
        }

        private void poliklinikTanimlama_Load(object sender, EventArgs e)
        {
            string connectionString = @"Provider=SQLOLEDB;Data Source=emin.italynorth.cloudapp.azure.com;Initial Catalog=LOCALDB;User ID=emin2;Password=emin;";
            OleDbConnection conn = new OleDbConnection(connectionString);
            Form1.ConnectDB(conn);

            string sqlIfadesi = "Select poliklinikadi From dbo.poliklinik";
            OleDbCommand cmd = new OleDbCommand(sqlIfadesi, conn);

            try
            {
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["poliklinikadi"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
            finally
            {
                Form1.DismountDB(conn);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                string selectedPoliklinik = (string)comboBox1.SelectedItem;

                string connectionString = @"Provider=SQLOLEDB;Data Source=emin.italynorth.cloudapp.azure.com;Initial Catalog=LOCALDB;User ID=emin2;Password=emin;";
                OleDbConnection conn = new OleDbConnection(connectionString);
                Form1.ConnectDB(conn);

                string sqlIfadesi = "SELECT * From dbo.poliklinik where poliklinikadi = ?";
                OleDbCommand cmd = new OleDbCommand(sqlIfadesi, conn);
                cmd.Parameters.AddWithValue("?", selectedPoliklinik);

                try
                {
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                    ds.Clear();
                    dataAdapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        richTextBox1.Text = row["aciklama"].ToString(); // Replace "aciklama" with actual column name
                        checkBox1.Checked = row["durum"].ToString() == "1";
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
                finally
                {
                    Form1.DismountDB(conn);
                }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Handle the group box enter event if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle the label click event if needed
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                try
                {
                    row["aciklama"] = richTextBox1.Text; // Replace "aciklama" with actual column name

                    // Update the database with the changes
                    string connectionString = @"Provider=SQLOLEDB;Data Source=emin.italynorth.cloudapp.azure.com;Initial Catalog=LOCALDB;User ID=emin2;Password=emin;";
                    OleDbConnection conn = new OleDbConnection(connectionString);
                    Form1.ConnectDB(conn);

                    string sqlIfadesi = "UPDATE dbo.poliklinik SET aciklama = ?, durum = ? WHERE poliklinikadi = ?";
                    OleDbCommand cmd = new OleDbCommand(sqlIfadesi, conn);
                    cmd.Parameters.AddWithValue("?", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("?", checkBox1.Checked); 
                    cmd.Parameters.AddWithValue("?", comboBox1.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    Form1.DismountDB(conn);

                    MessageBox.Show("Güncelleme başarılı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme başarısız: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No data to update");
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Form1.CloseUI(this.ParentForm,this);
        }
    }
}
