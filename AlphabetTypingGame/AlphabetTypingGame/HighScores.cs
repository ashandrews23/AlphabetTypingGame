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

namespace AlphabetTypingGame
{
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            string connString = @"Data Source = SQLDV02; Initial Catalog = HighScores; Database = zTestAA09AlphabetTypingGame; integrated security = SSPI";
            string query = "SELECT TOP (10) [Name], [Time] FROM zTestAA09AlphabetTypingGame.dbo.HighScores ORDER BY [Time] ASC";
            int rowNumber = 0;
            string RowNumberString = "";
            string name = "";
            string time = "";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                rowNumber += 1;
                RowNumberString = RowNumberString + rowNumber + ".\n\n";

                name += row["name"].ToString();
                name = name + "\n\n";

                time += row["time"].ToString();
                time = time + "\n\n";

            }

            name = name.TrimEnd('\r', '\n');
            time = time.TrimEnd('\r', '\n');

            lblRow.Text = RowNumberString;
            lblName.Text = name;
            lblTime.Text = time;

            conn.Close();
            da.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
