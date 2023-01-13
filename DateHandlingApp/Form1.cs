using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandlingApp
{
    public partial class DateHandling : Form
    {
        public DateHandling()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculateDueDates_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime futureDate = DateTime.Parse(txtFutureDate.Text);

            TimeSpan ts = futureDate.Subtract(currentDate);

            int daysUntilDue = ts.Days;
            MessageBox.Show(
                "Current Date:\t" + currentDate.ToShortDateString() + "\n\n" +
                "Future Date:\t" + futureDate.ToShortDateString() + "\n\n" +
                "Days until Due:\t" + daysUntilDue,
                "Due Days Calculation"
                );
        }

        private void btnCalculateAge_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime birthDate = DateTime.Parse(txtBirthDate.Text);

            int age = currentDate.Year - birthDate.Year;

            if (currentDate.DayOfYear < birthDate.DayOfYear)
                age--;

            MessageBox.Show(
                "Current Date:\t" + currentDate.ToLongDateString() + "\n\n" +
                "Birth Date:\t" + birthDate.ToLongDateString() + "\n\n" +
                "Age:\t" + age,
                "Age Calculation"
                );

        }
    }
}
