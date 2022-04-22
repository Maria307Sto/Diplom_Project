using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advertising
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveInfo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите название компании");
                return;
            }
            using(MySqlConnection con=new MySqlConnection(db.ConnectionString))
            {
                con.Open();
                MySqlCommand command = con.CreateCommand();
                command.CommandText= "INSERT INTO advertising (Name, DateCreate) VALUES (@name, @date)";
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@date", MySqlDbType.Date).Value = dateTimePicker1.Value;

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Сохранено!");
                else
                    MessageBox.Show("Не сохранено!");
            }

        }
    }
}
