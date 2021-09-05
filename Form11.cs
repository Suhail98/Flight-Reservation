using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    public partial class Form11 : Form
    {
        private string email;

        public Form11()
        {
            InitializeComponent();
        }

        public Form11(string email)
        {
            this.email = email;
            InitializeComponent();

        }

        private void Ubdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-5S2709M\SQLEXPRESS;
            Initial Catalog=FlightSystem; Trusted_Connection=True;";

            int seatsOfPlan = 1, makePlan = 1;
            int seatsOfPlan2 = 1, makePlan2 = 1;

            Int32.TryParse(NewSeatsBox.Text, out seatsOfPlan);
            Int32.TryParse(NewMakeBox.Text, out makePlan);

            Int32.TryParse(previousSeatsBox.Text, out seatsOfPlan2);
            Int32.TryParse(previousMakeBox.Text, out makePlan2);

            /*SqlCommand cmd = new SqlCommand("update AirCRAFT set MODEL ='" +
             NewModelBox.Text + "' , MAKE ='" + makePlan + "' , NO_SEATS ='"
            + seatsOfPlan + "', ADMIN_EMAIL ='" + email + "'where ADMIN_EMAIL like '" + email + "'", con);*/
             SqlCommand cmd = new SqlCommand("update AirCRAFT set MODEL ='" +
                 NewModelBox.Text + "' , MAKE ='" + makePlan + "' , NO_SEATS ='" 
                 + seatsOfPlan + "', ADMIN_EMAIL ='" + email +"'where MODEL like'" + previousModelBox.Text + "'AND MAKE like'"+ makePlan2+
                 "'AND NO_SEATS like '"+ seatsOfPlan2 + "'", con);
            con.Open();
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.Close();

        }

        private void NewMakeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewModelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewSeatsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeatsBox_Click(object sender, EventArgs e)
        {

        }

        private void MakeBox_Click(object sender, EventArgs e)
        {

        }

        private void ModelBox_Click(object sender, EventArgs e)
        {

        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightSystemDataSet.AIRCRAFT' table. You can move, or remove it, as needed.
            this.aIRCRAFTTableAdapter.Fill(this.flightSystemDataSet.AIRCRAFT);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
