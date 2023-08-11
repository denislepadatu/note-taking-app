using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;
using System.Drawing.Drawing2D;

namespace note_taking_app
{
    public partial class note_taking : Form
    {
        public note_taking()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {

            Random rnd = new Random();
            int num = rnd.Next();

            string noteText = richTextBox2.Text;

            DateTime currentDateTime = DateTime.Now;
            string currDateTime = currentDateTime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");

            string query = "INSERT INTO `notes`(`note_text`, `note_datetime`) VALUES('"+ noteText + "', '"+ currDateTime + "')";

            
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
                richTextBox2.Clear();

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        /*private void roundedButton1_Click(object sender, EventArgs e)
        {
            
        }*/

        private void note_taking_Load(object sender, EventArgs e)
        {

        }

        
    }
}
