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
    public partial class Form9 : Form
    {
        Boolean isAdmin;
        string Email;
        public Form9(Boolean isAdmin, string Email)
        {
            this.isAdmin = isAdmin;
            this.Email = Email;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-5S2709M\SQLEXPRESS;
            Initial Catalog=FlightSystem; Trusted_Connection=True;";
            if (isAdmin)
            {
                SqlCommand cmd = new SqlCommand("update ADMIN set ADMIN_EMAIL ='" +
                mailBox.Text + "' , ADMIN_FIRST_NAME ='" + FnameBox.Text
                + "' , ADMIN_LAST_NAME ='" + LnameBox.Text + "' , ADMIN_PASSWORD ='" + passwordBox.Text +
                "'where ADMIN_EMAIL ='" + Email + "'", con);
                con.Open();
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();

            }
            else
            {
                SqlCommand cmd = new SqlCommand("update CUSTOMER set CUSTOMER_EMAIL = '" +
               mailBox.Text + "' ,  CUST_FIRST_NAME ='" + FnameBox.Text
               + "' ,  CUST_LAST_NAME ='" + LnameBox.Text + "' ,  CUSTOMER_PASSWORD ='" + passwordBox.Text +
               "'where CUSTOMER_EMAIL ='" + Email + "'", con);
                con.Open();
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
