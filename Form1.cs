using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;


namespace advertising
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SayHello();
            SayWorld();
            contracts();
            calls();
            using (MySqlConnection con=new MySqlConnection("server= localhost; port=	3307; username = root; password=root; database=adverisiting; SSL Mode=none"))
             {
                 con.Open();
             }
         
        }
        void SayHello()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string SqlQueryCountry = "SELECT * FROM advertising";
            MySqlCommand sqlcomm = new MySqlCommand(SqlQueryCountry, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sdl = new MySqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdl.Fill(dt);
            adventionCompanyesComboBox.ComboBox.DataSource = dt;
            adventionCompanyesComboBox.ComboBox.DisplayMember = "Name";
            adventionCompanyesComboBox.ComboBox.ValueMember = "id";
            
        }
        void SayWorld()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string SqlQueryCountry = "SELECT * FROM organizations";
            MySqlCommand sqlcomm = new MySqlCommand(SqlQueryCountry, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sdl = new MySqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdl.Fill(dt);
            orgSummaryDataGrid.AutoGenerateColumns = false;
            orgSummaryDataGrid.DataSource = dt;
            name_organiz.DataPropertyName = "name_organiz";
            OrganizationIdColumn.DataPropertyName = "id";
            Col2.DataPropertyName = "date";
            Col3.DataPropertyName = "inn";
            Col4.DataPropertyName = "supervizor";
            Col5.DataPropertyName = "number_tel";
            Col6.DataPropertyName = "address";
            Col7.DataPropertyName = "site";
            Col8.DataPropertyName = "ogrn";
            Col9.DataPropertyName = "okpo";
            Col10.DataPropertyName = "bik/kpp";
        }
        void calls()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string SqlQueryCountry = "SELECT * FROM calls";
            MySqlCommand sqlcomm = new MySqlCommand(SqlQueryCountry, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sdl = new MySqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdl.Fill(dt);
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = dt;
            col14.DataPropertyName = "calls_organization";
            Col15.DataPropertyName = "numberTel1";
            Col16.DataPropertyName = "numberTel2";
            Col17.DataPropertyName = "e_mail";
            Col18.DataPropertyName = "status";
            Col19.DataPropertyName = "dateCalls";
            col20.DataPropertyName = "dateNext";
        }
        void contracts()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string SqlQueryCountry = "SELECT * FROM contacts";
            MySqlCommand sqlcomm = new MySqlCommand(SqlQueryCountry, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sdl = new MySqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdl.Fill(dt);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt;
            Col11.DataPropertyName = "name_oranization";
            Col12.DataPropertyName = "number";
            Col13.DataPropertyName = "Supervizor";
        }
         
    
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            registration newForm = new registration();
            newForm.ShowDialog();
            SayHello();
        }

        private void adventionCompanyesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UInt32 idAdvention= (adventionCompanyesComboBox.SelectedItem as DataRowView).Row.Field<UInt32>("id");
            using(MySqlConnection con=new MySqlConnection(db.ConnectionString))
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = $"SELECT o.* FROM advertising_organizations a, organizations o WHERE a.OrganizationId=o.id AND a.AdvertisingId={idAdvention}";

                MySqlDataAdapter sdl = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdl.Fill(dt);
                orgSummaryDataGrid.DataSource = dt;
            }
            
        }

        private void orgSummaryDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if(orgSummaryDataGrid.SelectedRows.Count>0)
            {
                int idOrg = Convert.ToInt32(orgSummaryDataGrid.SelectedRows[0].Cells[OrganizationIdColumn.Name].Value);
                UInt32 idAdvention = (adventionCompanyesComboBox.SelectedItem as DataRowView).Row.Field<UInt32>("id");
                using (MySqlConnection con = new MySqlConnection(db.ConnectionString))
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"SELECT * FROM organizations WHERE id={idOrg}";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox1.Text = (dr["name_organiz"].ToString());
                        textBox7.Text = (dr["date"].ToString());
                        textBox8.Text = (dr["supervizor"].ToString());
                        textBox9.Text = (dr["number_tel"].ToString());
                        textBox10.Text = (dr["address"].ToString());
                        textBox2.Text = (dr["ogrn"].ToString());
                        textBox3.Text = (dr["okpo"].ToString());
                        textBox4.Text = (dr["bik_kpp"].ToString());
                        textBox5.Text = (dr["inn"].ToString());
                        textBox6.Text = (dr["site"].ToString());
                    }
                }
                var idAdvestion = orgSummaryDataGrid.SelectedRows[0].Cells[OrganizationIdColumn.Name].Value as int?;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            UInt32 idAdvention = (adventionCompanyesComboBox.SelectedItem as DataRowView).Row.Field<UInt32>("id");
            addendum newForm = new addendum(idAdvention);
            if (newForm.ShowDialog() == DialogResult.OK)
                adventionCompanyesComboBox_SelectedIndexChanged(null, null);

        }

        private void importSave_Click(object sender, EventArgs e)
        {

        }

    }
}
