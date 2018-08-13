using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//Possible button colour changes:
//91, 186, 212
//64, 152, 179

namespace AlphabetTypingGame
{
    public partial class StartMenu : Form
    {
        public static string gameMode;
        public StartMenu()
        {
            InitializeComponent();
            cmbGameMode.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (cmbGameMode.Text == "Please select a game mode")
            {
                MessageBox.Show("Please select a game mode","No game mode selected");
                return;
            }else
            {
                gameMode = cmbGameMode.Text;
                GameScreen gamescreen = new GameScreen();
                gamescreen.Tag = this;
                gamescreen.Show(this);
                Hide();
                MessageBox.Show("Begin typing the alphabet to start", "On your marks...");
            }

        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is how to play etc","How to play");
        }

        private void btnViewHighScores_Click(object sender, EventArgs e)
        {
            //string query = "Data Source = SQLDV02; Initial Catalog = HighScores; Database = zTestAA09AlphabetTypingGame; integrated security = SSPI";
            //SqlConnection con = new SqlConnection(query);
            //con.Open();
            //string query1 = "SELECT * FROM zTestAA09AlphabetTypingGame.dbo.HighScores";

            //SqlCommand cmd = new SqlCommand(query1, con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    label1.Text = dr["Name"].ToString();
            //    //label1.Text = dr.GetValue(0).ToString();
            //}
            //con.Close();

            HighScores highscores = new HighScores();
            highscores.Tag = this;
            highscores.Show(this);
        }
    }
}
