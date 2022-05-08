using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace AlarmSystem
{
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=DESKTOP-970G76V\\SQLEXPRESS;Initial Catalog=ScadaLAB;Integrated Security=True; TrustServerCertificate=Yes;";
        public string sql = "SELECT * FROM ALARM";

        public string sortingString = "AlarmId";
        public int selectedRowIndex = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "ALARM");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ALARM";
            dataGridView1.Sort(dataGridView1.Columns[sortingString], ListSortDirection.Descending);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) > 98)
                    dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Red;
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) > 70)
                    dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Yellow;

            }
            lblRealTime.Text = DateTime.Now.ToString();
        }
        private void btnAcknowledgeAll_Click(object sender, EventArgs e)
        {
            var result =     MessageBox.Show("Do you want to Acknowledge all alarms?", "Alarm Acknowledge",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string sqlStatement = "UPDATE ALARM SET AlarmAckStatus = 'Acknowledged'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnSortId_Click(object sender, EventArgs e)
        {
            sortingString = "AlarmId";
        }

        private void btnSortUnack_Click(object sender, EventArgs e)
        {
            sortingString = "AlarmAckStatus";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnAckSelected_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlStatement = "UPDATE ALARM SET AlarmAckStatus = 'Acknowledged' where AlarmId = " + Convert.ToString(selectedRowIndex);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlStatement, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
