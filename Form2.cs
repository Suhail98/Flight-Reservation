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
    public partial class Form2 : Form
    {
        public static string AdminEmail = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            string connetionString = @"Data Source=DESKTOP-5S2709M\SQLEXPRESS;
            Initial Catalog=FlightSystem; Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = null;
            if (adminRdioButton.Checked)
            {
                AdminEmail = mailBox.Text;
                cmd = new SqlCommand("Insert Into ADMIN values ( '" + passwordBox.Text
                + "','" + mailBox.Text + "','" + FnameBox.Text + "','" + LnameBox.Text + "')", con);
                Form3 form3 = new Form3(true, mailBox.Text);
                form3.Show();
            }
            else
            {
                cmd = new SqlCommand("Insert Into CUSTOMER values ( '" + FnameBox.Text
                + "','" + LnameBox.Text + "','" + mailBox.Text + "','" + passwordBox.Text + "')", con);
                Form3 form3 = new Form3(true, mailBox.Text);
                form3.Show();
            }
            cmd.ExecuteNonQuery();
            con.Close();

            this.Close();

        }

        private void MailBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void LnameBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void FnameBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void CustomerRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void AdminRdioButton_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void Label4_Click(object sender, System.EventArgs e)
        {

        }

        private void Label3_Click(object sender, System.EventArgs e)
        {

        }

        private void Label2_Click(object sender, System.EventArgs e)
        {

        }

        private void Label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}