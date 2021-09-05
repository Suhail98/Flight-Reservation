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
    public partial class Form12 : Form
    {
        private string email;

        public Form12()
        {
            InitializeComponent();
        }

        public Form12(string email)
        {
            this.email = email;
        }

        private void MakeBox_Click(object sender, EventArgs e)
        {

        }

        private void SeatsBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connetionString = @"Data Source=DESKTOP-5S2709M\SQLEXPRESS;
            Initial Catalog=FlightSystem; Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = null;

            cmd = new SqlCommand("Insert Into FLIGHT (ADMIN_EMAIL,SOURCE,DESTINATION) " +
           "values('" + email + "','" + SourceBox.Text + "','" + destonationBox.Text +  "')", con);

            /*//____________________________________________________
            string expression;
            expression = "FLIGHT_ID like " + ;
            DataRow foundRows;

            // Use the Select method to find all rows matching the filter.
            foundRows = FLIGHT.Select(expression);




            cmd = new SqlCommand("Insert Into FLIGHT_DETIALS (ID,DATE) " +
          "values('" +  "Select From FLIGHT " + "','" + SourceBox.Text + "','" + destonationBox.Text + "')", con);
          */
            cmd.ExecuteNonQuery();
            MessageBox.Show(cmd.CommandText);

            con.Close();

            this.Close();

        }
    }
}
