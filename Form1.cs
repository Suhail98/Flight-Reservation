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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string con = @"Data Source=DESKTOP-5S2709M\SQLEXPRESS;
            Initial Catalog=FlightSystem; Trusted_Connection=True;";

            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from ADMIN where ADMIN_EMAIL=@mail";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@mail", mailBox.Text);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {

                    if (oReader.Read())
                    {
                        if (oReader["ADMIN_PASSWORD"].ToString() == passwordBox.Text)
                        {
                            Form3 form3 = new Form3(true, mailBox.Text);
                            form3.Show();
                            this.Hide();
                            return;
                        }

                    }

                    myConnection.Close();
                }
            }

            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Customer where Customer_EMAIL=@mail";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@mail", mailBox.Text);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {

                    if (oReader.Read())
                    {
                        if (oReader["Customer_PASSWORD"].ToString() == passwordBox.Text)
                        {
                            Form3 form3 = new Form3(false, mailBox.Text);
                            form3.Show();
                            this.Hide();
                            return;
                        }

                    }

                    myConnection.Close();
                }
            }
            MessageBox.Show("wrong data");
        }
    }
}
