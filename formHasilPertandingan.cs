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


namespace PraktikumWEek8
{
    public partial class formHasilPertandingan : Form
    {
        private static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable dtHomeTeam = new DataTable();
        DataTable dtAwayTeam = new DataTable();

        public formHasilPertandingan()
        {
            InitializeComponent();
        }

        private void formHasilPertandingan_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            //sqlConnect.Close();
            sqlQuery = "SELECT team.team_id, team.team_name, manager.manager_name AS 'MANAGER', IFNULL(assmanager.manager_name, '-') AS 'ASSMANAGER', player.player_name AS 'CAPTAIN', team.home_stadium AS 'STADIUM', team.city AS 'CITY', team.capacity AS 'CAPACITY' FROM team LEFT JOIN player ON team.captain_id = player.player_id LEFT JOIN manager ON team.manager_id = manager.manager_id LEFT JOIN manager assmanager ON team.assmanager_id = assmanager.manager_id ORDER BY 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHomeTeam); 
            sqlAdapter.Fill(dtAwayTeam); 

            cbHomeTeam.DisplayMember = "team_name";
            cbHomeTeam.ValueMember = "team_id";
            cbHomeTeam.DataSource = dtHomeTeam;

            cbAwayTeam.DisplayMember = "team_name";
            cbAwayTeam.ValueMember = "team_id";
            cbAwayTeam.DataSource = dtAwayTeam; 
        }

        private void cbHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblHomeManager.Text = dtHomeTeam.Rows[cbHomeTeam.SelectedIndex]["MANAGER"].ToString();
                lblHomeAssMng.Text = dtHomeTeam.Rows[cbHomeTeam.SelectedIndex]["ASSMANAGER"].ToString();
                lblHomeCaptain.Text = dtHomeTeam.Rows[cbHomeTeam.SelectedIndex]["CAPTAIN"].ToString();
                lblStadiumName.Text = $"{dtHomeTeam.Rows[cbHomeTeam.SelectedIndex]["STADIUM"].ToString()}, {dtHomeTeam.Rows[cbHomeTeam.SelectedIndex]["CITY"].ToString()}";
                lblStadiumCapacity.Text = dtHomeTeam.Rows[cbHomeTeam.SelectedIndex]["CAPACITY"].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cbAwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblAwayManager.Text = dtAwayTeam.Rows[cbAwayTeam.SelectedIndex]["MANAGER"].ToString();
                lblAwayAssMng.Text = dtAwayTeam.Rows[cbAwayTeam.SelectedIndex]["ASSMANAGER"].ToString();
                lblAwayCaptain.Text = dtAwayTeam.Rows[cbAwayTeam.SelectedIndex]["CAPTAIN"].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable match = new DataTable();
                sqlQuery = $"SELECT DATE_FORMAT(m.match_date, '%d %M %Y') AS 'DATE', CONCAT(m.goal_home, ' - ', m.goal_away) AS 'SCORE' FROM `match` m WHERE m.team_home = '{cbHomeTeam.SelectedValue}' AND m.team_away = '{cbAwayTeam.SelectedValue}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(match);

                if(match.Rows.Count > 0)
                {
                    lblTanggal.Text = match.Rows[0]["DATE"].ToString();
                    lblSkor.Text = match.Rows[0]["SCORE"].ToString();
                }
                else
                {
                    lblTanggal.Text = "Not Found";
                    lblSkor.Text = "Not Found";
                }

                DataTable dtDMatch = new DataTable();
                sqlQuery = $"SELECT dm.minute AS 'minute', IF(dm.team_id = '{cbHomeTeam.SelectedValue}', IF(dm.type = 'GW', '', p.player_name), IF(dm.type = 'GW', p.player_name, '')) AS 'Player Name 1', IF(dm.team_id = '{cbHomeTeam.SelectedValue}', IF(dm.type = 'GW', '', IF(dm.type = 'CY', 'Yellow Card', IF(dm.type = 'CR', 'Red Card', IF(dm.type = 'GO', 'Goal', IF(dm.type = 'GP','Goal Penalty', 'Penalty Miss'))))), IF(dm.type = 'GW', 'Own Goal', '')) AS 'Type 1',  IF(dm.team_id = '{cbAwayTeam.SelectedValue}', IF(dm.type = 'GW', '', p.player_name), IF(dm.type = 'GW', p.player_name, '')) AS 'Player Name 2', IF(dm.team_id = '{cbAwayTeam.SelectedValue}', IF(dm.type = 'GW', '', IF(dm.type = 'CY', 'Yellow Card', IF(dm.type = 'CR', 'Red Card', IF(dm.type = 'GO', 'Goal', IF(dm.type = 'GP','Goal Penalty', 'Penalty Miss'))))), IF(dm.type = 'GW', 'Own Goal', '')) AS 'Type 2' FROM dmatch dm, (SELECT m.match_id AS 'ID' FROM `match` m WHERE m.team_home = '{cbHomeTeam.SelectedValue}' and m.team_away = '{cbAwayTeam.SelectedValue}') mtch, player p WHERE dm.match_id = mtch.ID AND p.player_id = dm.player_id;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtDMatch);
                dgvDMatch.DataSource = dtDMatch;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
