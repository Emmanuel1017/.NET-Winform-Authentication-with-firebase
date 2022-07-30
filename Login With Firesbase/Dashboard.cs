using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Login_Sample
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        static Settings pub = new Settings();
        public MySqlConnection db = new MySqlConnection(pub.__DBString);
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter adtr;
        public MySqlDataReader dr;
        public DataSet ds;
        public int kid = Properties.Settings.Default.Id;
       
        private void button1_Click(object sender, EventArgs e)
        {
   
        }



     
        private void Dashboard_Load(object sender, EventArgs e)
        {

           
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

    

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 