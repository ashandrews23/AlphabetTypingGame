using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace AlphabetTypingGame
{

    public partial class GameScreen : Form
    { 
        //int ticks;
        public Stopwatch stopWatch = new Stopwatch();
        public string elapsedTime;
        public string gameMode = StartMenu.gameMode;
        public string gameModeAlphabet;


        public GameScreen()
        {
            InitializeComponent();
            CenterToScreen();
            
            switch (gameMode)
            {
                case "A-Z (Normal)":
                    gameModeAlphabet = "abcdefghijklmnopqrstuvwxyz";
                    MessageBox.Show(gameModeAlphabet);
                    break;
                case "Z-A (Backwards)":
                    gameModeAlphabet = "zyxwvutsrqponmlkjihgfedcba";
                    MessageBox.Show(gameModeAlphabet);
                    break;
            }
            
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void textBoxLetterInput_KeyDown(object sender, KeyEventArgs e)
        {

            switch (gameMode)
            {
                case "A-Z (Normal)":
                    if (e.KeyCode == Keys.A)
                    {
                        //timer1.Start();
                        stopWatch.Start();
                        timer1.Enabled = true;
                    }
                    break;
                case "Z-A (Backwards)":
                    if (e.KeyCode == Keys.Z)
                    {
                        //timer1.Start();
                        stopWatch.Start();
                        timer1.Enabled = true;
                    }
                    break;
            }

        }

        private void textBoxLetterInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLetterInput.TextLength == 26 && textBoxLetterInput.Text != gameModeAlphabet)
            {
                textBoxLetterInput.ForeColor = Color.Red;

            }else
            {
                textBoxLetterInput.ForeColor = Color.Black;
            }

            if (textBoxLetterInput.Text == gameModeAlphabet)
            {

                //timer1.Stop();
                textBoxLetterInput.ForeColor = Color.Green;
                stopWatch.Stop();
                timer1.Enabled = false;
                MessageBox.Show(elapsedTime);

                //var oldElapsedTime = elapsedTime;
                if (lblFastestTime.Text == "-")
                {
                    lblFastestTime.Text = elapsedTime;
                }else
                {
                    //if (elapsedTime > oldElapsedTime)
                    //{
                    //    lblFastestTime.Text = elapsedTime;
                    //}
                }

                MessageBox.Show("Finished!\n\nYour time is: "+ elapsedTime);
                btnSaveToHighScore.Visible = true;
                //Application.Exit();
            }
            //if (textBoxLetterInput.Text == lblLetterA.Text)
            //{
            //    lblLetterA.ForeColor = Color.Green;
            //}
            //else
            //{
            //    lblLetterA.ForeColor = Color.Red;
            //}

                //if (textBoxLetterInput.Text == lblLetterB.Text)
                //{
                //    lblLetterB.ForeColor = Color.Green;
                //}
                //else
                //{
                //    lblLetterB.ForeColor = Color.Red;
                //}
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            //ticks++;
            //lblTimer.Text = "Time: "+ticks.ToString();
            //stopWatch.ElapsedMilliseconds.ToString();
            TimeSpan timeSpan = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}.{1:000}",
            timeSpan.Seconds,
            timeSpan.Milliseconds);
            lblTimer.Text = "Time: " + elapsedTime;
            //+stopWatch.Elapsed.Seconds.ToString() + "." + stopWatch.ElapsedMilliseconds.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            stopWatch.Reset();
            textBoxLetterInput.Text = "";
            textBoxLetterInput.Focus();
            btnSaveToHighScore.Visible = false;
        }

        private void btnBackToStart_Click(object sender, EventArgs e)
        {
            StartMenu startmenu = new StartMenu();
            startmenu.Tag = this;
            startmenu.Show(this);
            Hide();
        }

        private void btnSaveToHighScore_Click(object sender, EventArgs e)
        {
            string highScoreName = "";
            ShowInputDialog(ref highScoreName);
            string connectionString = null;
            //***DEV CONNECTION*** 
            connectionString = "Data Source=SQLDV02;Initial Catalog=HighScores; Database=zTestAA09AlphabetTypingGame; integrated security=SSPI";
            string insStmt = "INSERT INTO HighScores ([Date], [Name], [Time]) Values (GETDATE(), @Name, @Time)";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand insCmd = new SqlCommand(insStmt, cnn);
                // use sqlParameters to prevent sql injection!
                insCmd.Parameters.AddWithValue("@Name", highScoreName);
                insCmd.Parameters.AddWithValue("@Time", elapsedTime);
                int affectedRows = insCmd.ExecuteNonQuery();
                MessageBox.Show(affectedRows + " rows inserted!");
                cnn.Close();
            }
         
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            Size size = new Size(225, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.ClientSize = size;
            inputBox.Text = "Please enter your highscore name";

            TextBox textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 5);
            textBox.Location = new Point(5, 5);
            textBox.MaxLength = 15;
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;

        }

        
    }
}
