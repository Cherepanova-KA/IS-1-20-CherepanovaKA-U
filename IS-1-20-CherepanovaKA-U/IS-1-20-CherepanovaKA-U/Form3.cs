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
    public partial class Form3 : Form
    {
        MySqlConnection conn;
        Сlass1 Connect;
        string connStr = "server= server=chuc.caseum.ru;port=33333;user=st_1_20_30;database=is_1_20_st30_KURS;password=14759434;";
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet ds = new DataSet();
        private DataTable table = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

              catch
            }

    internal class Сlass1
        {
        }
    }
}
