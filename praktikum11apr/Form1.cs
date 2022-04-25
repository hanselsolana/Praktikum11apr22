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

namespace praktikum11apr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable ManagerandCaptain = new DataTable();
            sqlQuery = "SELECT m.manager_name AS 'Nama Manager', p.player_name AS 'Nama Captain' FROM team t, player p, manager m WHERE t.captain_id = p.player_id AND m.manager_id = t.manager_id AND t.team_id = '"+cmbbox.SelectedValue.ToString()+"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(ManagerandCaptain);
            lblmanager1.Text = ManagerandCaptain.Rows[0]["Nama Manager"].ToString();
            lblcaptain1.Text = ManagerandCaptain.Rows[0]["Nama Captain"].ToString();

            DataTable Stadium = new DataTable();
            sqlQuery = "SELECT concat(home_stadium, ', ', city) as 'Nama Stadium', capacity as 'Jumlah Capacity' from team where team_id = '"+cmbbox.SelectedValue.ToString()+"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Stadium);
            lblstadium.Text = Stadium.Rows[0]["Nama Stadium"].ToString();
            lblcapacity.Text = Stadium.Rows[0]["Jumlah Capacity"].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtTeam1 = new DataTable();
            sqlQuery = "SELECT team_id as 'ID Tim', team_name as 'Nama Tim' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam1);
            cmbbox.DisplayMember = "Nama Tim";
            cmbbox.ValueMember = "ID Tim";
            cmbbox.DataSource = dtTeam1;

            DataTable dtTeam2 = new DataTable();
            sqlQuery = "SELECT team_id as 'ID Tim', team_name as 'Nama Tim' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam2);
            cmbbox2.DisplayMember = "Nama Tim";
            cmbbox2.ValueMember = "ID Tim";
            cmbbox2.DataSource = dtTeam2;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable ManagerandCaptain2 = new DataTable();
            sqlQuery = "SELECT m.manager_name AS 'Nama Manager', p.player_name AS 'Nama Captain' FROM team t, player p, manager m WHERE t.captain_id = p.player_id AND m.manager_id = t.manager_id AND t.team_id = '" + cmbbox2.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(ManagerandCaptain2);
            lblmanager2.Text = ManagerandCaptain2.Rows[0]["Nama Manager"].ToString();
            lblcaptain2.Text = ManagerandCaptain2.Rows[0]["Nama Captain"].ToString();
        }

        private void lblstadium_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tgldanskor = new DataTable();
            sqlQuery = "select date_format(match_date, '%e %M %Y') as `Tanggal`, concat(goal_home, '-', goal_away) as Skor from match where team_home = '" + cmbbox.SelectedValue.ToString() + "' and team_away = '" + cmbbox2.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(tgldanskor);
            lbltanggal.Text = tgldanskor.Rows[0]["Tanggal"].ToString();
            lblskor.Text = tgldanskor.Rows[0]["Skor"].ToString();
        }

        private void lbltanggal_Click(object sender, EventArgs e)
        {

        }
    }
}
