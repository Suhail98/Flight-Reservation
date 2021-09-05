using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    public partial class Form3 : Form
    {
        Boolean isAdmin;
        string Email;
        public Form3()
        {

            InitializeComponent();
        }
        public Form3(Boolean isAdmin, string Email)
        {
            this.isAdmin = isAdmin;
            this.Email = Email;
            InitializeComponent();
            if (isAdmin)
            {
                addAircraftButton.Visible = true;
                updateAircraftButton.Visible = true;
                addFlightButton.Visible = true;
                updateFlightButton.Visible = true;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(isAdmin, Email);
            form9.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form12 from12 = new Form12(Email);
            from12.Show();
        }

        private void AddAircraftButton_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(Email);
            form10.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void UpdateAircraftButton_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11(Email);
            form11.Show();
        }
    }
}
