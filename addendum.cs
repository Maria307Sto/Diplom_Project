using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace advertising
{
    public partial class addendum : Form
    {
        UInt32 idAdven;
        public addendum(UInt32 idAdven)
        {
            this.idAdven = idAdven;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите название организации");
                return;
            }
            using (MySqlConnection con = new MySqlConnection(db.ConnectionString))
                try
                {
                    con.Open();
                    MySqlTransaction tr = con.BeginTransaction();
                    try
                    {
                        MySqlCommand command = con.CreateCommand();
                        command.CommandText = "INSERT INTO organizations (name_organiz,date,inn,supervizor,number_tel,address,site,ogrn,okpo,bik_kpp) VALUES (@name,@date,@inn,@supervizor,@number,@adres,@site,@ogrn,@okpo,@bik)";
                        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
                        command.Parameters.Add("@date", MySqlDbType.Date).Value = dateTimePicker1.Value;
                        command.Parameters.Add("@inn", MySqlDbType.VarChar).Value = textBox2.Text;
                        command.Parameters.Add("@supervizor", MySqlDbType.VarChar).Value = textBox3.Text;
                        command.Parameters.Add("@number", MySqlDbType.VarChar).Value = textBox4.Text;
                        command.Parameters.Add("@adres", MySqlDbType.VarChar).Value = textBox5.Text;
                        command.Parameters.Add("@site", MySqlDbType.VarChar).Value = textBox6.Text;
                        command.Parameters.Add("@ogrn", MySqlDbType.VarChar).Value = textBox7.Text;
                        command.Parameters.Add("@okpo", MySqlDbType.VarChar).Value = textBox8.Text;
                        command.Parameters.Add("@bik", MySqlDbType.VarChar).Value = textBox9.Text;
                        command.ExecuteNonQuery();
                        long idOrg = command.LastInsertedId;

                        command.Parameters.Clear();
                        command.CommandText = $"INSERT INTO advertising_organizations (AdvertisingId, OrganizationId) VALUES ({idAdven}, {idOrg})";
                        command.ExecuteNonQuery();

                        tr.Commit();
                        DialogResult = DialogResult.OK;
                    }
                    catch (SystemException ex)
                    {
                        tr.Rollback();
                    }


                }
                catch (SystemException ex)
                {

                }
        }
    }
}
