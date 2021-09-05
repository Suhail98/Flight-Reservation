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
    public partial class Form10 : Form
    {
        private string email;
       // private object Int32;

        public Form10()
        {
            InitializeComponent();
        }

        public Form10(string email)
        {
            this.email = email;
            InitializeComponent();

        }

        [Obsolete]
        private void Add_Click(object sender, EventArgs e)
        {
            string connetionString = @"Data Source=DESKTOP-5S2709M\SQLEXPRESS;
            Initial Catalog=FlightSystem; Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = null;
            
            int seatsOfPlan = 1,makePlan = 1;
            Int32.TryParse(SeatsBox2.Text, out seatsOfPlan);
            Int32.TryParse(MakeBox2.Text, out makePlan);
            //int model1 = Convert.INT.TryParse(ModelBox.Text);
            //int userVal = int.Parse(SeatsBox.Text);

            cmd = new SqlCommand("Insert Into AIRCRAFT (ADMIN_EMAIL,MODEL,MAKE,NO_SEATS) " +
            "values('" + email +"','"+ ModelBox.Text + "','" + seatsOfPlan + "','" + makePlan + "')", con );


            /*String query = "INSERT INTO AIRCRAFT (MODEL,MAKE,NO_SEATS) " +
                         "VALUES (@MODEL,@MAKE, @NO_SEATS)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("ADMIN_EMAIL", email);
            cmd.Parameters.Add("MODEL", ModelBox.Text);
            cmd.Parameters.Add("MAKE", make1);
            cmd.Parameters.Add("NO_SEATS", seats);*/ 

            cmd.ExecuteNonQuery();
            MessageBox.Show(cmd.CommandText);

            con.Close();

            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
