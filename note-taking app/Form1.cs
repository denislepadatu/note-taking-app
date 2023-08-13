using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace note_taking_app
{
    public partial class note_taking : Form
    {
        public note_taking()
        {
            InitializeComponent();

            // Store the starting position of roundButton4
            roundButton4StartingPosition = roundedButton4.Location;
        }

        private Point roundButton4StartingPosition;


        private void roundedButton2_Click(object sender, EventArgs e)
        {
            runQuery();
            PopulateDataGridView();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of monthCalendar1
            monthCalendar1.Visible = !monthCalendar1.Visible;
        }

        private void runQuery()
        {

            Random rnd = new Random();
            int num = rnd.Next();

            //Current DateTime
            DateTime currentDateTime = DateTime.Now;
            string currDateTime = currentDateTime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
            //MessageBox.Show(currDateTime);

            //Get the selected calendar date and the current time to same in db
            string date1 = monthCalendar1.SelectionRange.Start.ToString("yyyy'-'MM'-'dd") + "T" + DateTime.Now.ToString("HH':'mm");
            Convert.ToDateTime(date1);
            //MessageBox.Show(date1);

            string noteText = richTextBox2.Text;

            //Insert query for notes
            string query = "INSERT INTO `notes`(`note_text`, `note_datetime`) VALUES('"+ noteText + "', '"+ date1 + "')";

            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_taking_app_db;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                //MessageBox.Show(currDateTime.ToString());

                MessageBox.Show("Notita salvata cu succes!");

                //reset the controls
                richTextBox2.Clear();
                monthCalendar1.Refresh();
                monthCalendar1.RemoveAllBoldedDates();
                monthCalendar1.Visible = false;

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                //If no date is selected in the calendar
                //insert the note and the current date and time
                if (date1 == DateTime.Now.ToString("HH:mm"))
                {
                    string query1 = "INSERT INTO `notes`(`note_text`, `note_datetime`) VALUES('" + noteText + "', '" + currentDateTime + "')";

                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    //MessageBox.Show(currDateTime.ToString());

                    MessageBox.Show("Notita salvata cu succes!");

                    //reset the controls
                    richTextBox2.Clear();
                    monthCalendar1.Refresh();
                    monthCalendar1.RemoveAllBoldedDates();
                    monthCalendar1.Visible = false;

                    databaseConnection.Close();

                }

                // Show any error message.
                // MessageBox.Show(ex.Message);
            }
        }
 

        private void note_taking_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            monthCalendar1.VisibleChanged += MonthCalendar1_VisibleChanged;
        }

        private void PopulateDataGridView()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_taking_app_db;pooling = false; convert zero datetime=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, note_text AS Note, note_datetime as Date FROM notes";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void MonthCalendar1_VisibleChanged(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible)
            {
                int newX = 405;
                int newY = monthCalendar1.Bottom + 10; // Adjust the gap as needed
                roundedButton4.Location = new Point(newX, newY);
                roundedButton4.Visible = true;
            }
            else
            {
                // Restore the starting position of roundButton4
                roundedButton4.Location = roundButton4StartingPosition;
                roundedButton4.Visible = true; // Set it to true instead of false
            }
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    DeleteFromDBGrid();
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            } else
            {
                MessageBox.Show("Te rog selecteaza notitele pe care vrei sa le stergi!");
            }
                
        }

        private void DeleteFromDBGrid()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_taking_app_db;pooling = false; convert zero datetime=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                
                int idNotes = (int)dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value;
                string query = "DELETE FROM `notes` WHERE Id = " + idNotes.ToString();
                //MessageBox.Show(query);

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    MessageBox.Show("Notita s-a sters cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
    }
}
