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

namespace IS_1_20_CherepanovaKA_U
{
    public partial class Task2 : Form
    {
        class ConnectionSQL
        {
            public MySqlConnection connDD()
            {
                string host = "10.90.12.110";
                string port = "33333";
                string user = "uchebka";
                string dd = "uchebka";
                string password = "uchebka";
                string connStr = $"server={host};port={port};user={user};database={dd};password={password};";
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
        }
        public Task2()
            {
                InitializeComponent();
            }

            private void Task2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionSQL connectiondd = new ConnectionSQL();
            try
            {
                connectiondd.connDD().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                MessageBox.Show("Все хорошо");
                connectiondd.connDD().Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
