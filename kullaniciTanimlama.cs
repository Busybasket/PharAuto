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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharAuto
{
    public partial class kullaniciTanimlama : UserControl
    {
        private DataSet ds;
        private OleDbDataAdapter dataAdapter;

        public kullaniciTanimlama()
        {
            InitializeComponent();
        }

        private void kullaniciTanimlama_Load(object sender, EventArgs e)
        {
            string connectionString = @"Provider=SQLOLEDB;Data Source=emin.italynorth.cloudapp.azure.com;Initial Catalog=LOCALDB;User ID=emin2;Password=emin;";
            OleDbConnection conn = new OleDbConnection(connectionString);
            Form1.ConnectDB(conn);
            string[] kodu = new string[100];
            string query = "SELECT kodu FROM dbo.kullanici";
            OleDbCommand command = new OleDbCommand(query, conn);
            OleDbDataReader reader = command.ExecuteReader();
            int index = 0;
            while (reader.Read() && index < kodu.Length)
            {
                kodu[index++] = reader["kodu"].ToString();
            }
            reader.Close();
            kodu = kodu.Where(c => c != null).ToArray();
            comboBox1.Items.AddRange(kodu);
            Form1.DismountDB(conn);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Provider=SQLOLEDB;Data Source=emin.italynorth.cloudapp.azure.com;Initial Catalog=LOCALDB;User ID=emin2;Password=emin;";
            OleDbConnection conn = new OleDbConnection(connectionString);
            Form1.ConnectDB(conn);

            string sqlIfadesi = "Select * From dbo.kullanici Where kodu = ?";
            dataAdapter = new OleDbDataAdapter(sqlIfadesi, conn);
            OleDbCommand command = new OleDbCommand(sqlIfadesi, conn);
            OleDbParameter parameter = new OleDbParameter("?", OleDbType.VarChar, 50); // Set the size to 50 or appropriate value
            parameter.Value = comboBox1.Text;
            command.Parameters.Add(parameter);
            command.Prepare();

            dataAdapter.SelectCommand = command;

            ds = new DataSet();
            dataAdapter.Fill(ds);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                adiTextbox.Text = row["ad"] != DBNull.Value ? row["ad"].ToString() : string.Empty;
                soyadiBox8.Text = row["soyad"] != DBNull.Value ? row["soyad"].ToString() : string.Empty;
                unvanCombobox.Text = row["unvan"] != DBNull.Value ? row["unvan"].ToString() : string.Empty;
                maasTextbox.Text = row["maas"] != DBNull.Value ? row["maas"].ToString() : string.Empty;
                iseBaslamadateTimePicker.Value = row["isebaslama"] != DBNull.Value ? Convert.ToDateTime(row["isebaslama"]) : DateTime.Now;
                cinsiyetCombobox.Text = row["cinsiyet"] != DBNull.Value ? row["cinsiyet"].ToString() : string.Empty;
                medeniHalCombobox.Text = row["medenihal"] != DBNull.Value ? row["medenihal"].ToString() : string.Empty;
                kanCombobox.Text = row["kangrubu"] != DBNull.Value ? row["kangrubu"].ToString() : string.Empty;
                adresRichtextbox.Text = row["adres"] != DBNull.Value ? row["adres"].ToString() : string.Empty;
                tcTextBox.Text = row["tckimlikno"] != DBNull.Value ? row["tckimlikno"].ToString() : string.Empty;
                dogumTextbox.Text = row["dogumyeri"] != DBNull.Value ? row["dogumyeri"].ToString() : string.Empty;
                babaTextbox.Text = row["babaad"] != DBNull.Value ? row["babaad"].ToString() : string.Empty;
                anneTextbox.Text = row["annead"] != DBNull.Value ? row["annead"].ToString() : string.Empty;
                telTextbox.Text = row["evtel"] != DBNull.Value ? row["evtel"].ToString() : string.Empty;
                gsmTextbox.Text = row["ceptel"] != DBNull.Value ? row["ceptel"].ToString() : string.Empty;
                kullaniciTextbox.Text = row["username"] != DBNull.Value ? row["username"].ToString() : string.Empty;
                sifreTextbox.Text = row["sifre"] != DBNull.Value ? row["sifre"].ToString() : string.Empty;
                yetkiRadiobutton.Checked = row["yetki"].ToString() == "1" ? true : false;
            }
            else
            {
                MessageBox.Show("No data found for the selected item.", "Data Not Found");
            }

            Form1.DismountDB(conn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (ds != null && dataAdapter != null)
            {
                DataRow row = ds.Tables[0].Rows[0];

                row["ad"] = adiTextbox.Text;
                row["soyad"] = soyadiBox8.Text;
                row["unvan"] = unvanCombobox.Text;
                row["maas"] = maasTextbox.Text;
                row["isebaslama"] = iseBaslamadateTimePicker.Value;
                row["cinsiyet"] = cinsiyetCombobox.Text;
                row["medenihal"] = medeniHalCombobox.Text;
                row["kangrubu"] = kanCombobox.Text;
                row["adres"] = adresRichtextbox.Text;
                row["tckimlikno"] = tcTextBox.Text;
                row["dogumyeri"] = dogumTextbox.Text;
                row["babaad"] = babaTextbox.Text;
                row["annead"] = anneTextbox.Text;
                row["evtel"] = telTextbox.Text;
                row["ceptel"] = gsmTextbox.Text;
                row["username"] = kullaniciTextbox.Text;
                row["sifre"] = sifreTextbox.Text;
                row["yetki"] = yetkiRadiobutton.Checked ? "1" : "0";

                OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
                dataAdapter.Update(ds);
                MessageBox.Show("Veriler guncellendi.", "Guncelleme Basarili");
            }
            else
            {
                MessageBox.Show("Veri bulunamadi.", "Guncelleme Basarisiz");
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Form1.CloseUI(ParentForm, this);
        }
    }
}
