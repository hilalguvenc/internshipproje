using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecthg
{
    public partial class ınternship : Form
    {
        private DateTime datestartint, dateendint, datestartdep;
        public ınternship()
        {
            InitializeComponent();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void StartingDateIntChanged(object sender, EventArgs e)
        {
            
        }

        private void EndingDateIntChanged(object sender, EventArgs e)
        {

        }

        private void StartingDateDeptChanged(object sender, EventArgs e)
        {

        }

        private void firmNameChanged(object sender, EventArgs e)
        {

        }

        private void WebChanged(object sender, EventArgs e)
        {

        }

        private void CityChanged(object sender, EventArgs e)
        {

        }

        private void NameSurnameChanged(object sender, EventArgs e)
        {

        }

        private void IdChanged(object sender, EventArgs e)
        {

        }

        private void EmailChanged(object sender, EventArgs e)
        {

        }

        private void CheckboxWorkshopChecked(object sender, EventArgs e)
        {

        }

        private void FinishButton(object sender, EventArgs e)
        {
            MessageBox.Show("Internship days are " + datediff() + "\nSemester Completed is " + semestercalc());

        }

        private void ChechboxSaturdayChecked(object sender, EventArgs e)
        {

        }

        private void CheckboxCoursesChecked(object sender, EventArgs e)
        {

        }

        private int datediff()
        {
            TimeSpan diff = dateEndingInternship.Value - dateStartingInternship.Value;
            return diff.Days + 1;
        }

        private int semestercalc()
        {
            TimeSpan diff = DateTime.Today - dateStartingDepartment.Value;
            return (int)(diff.Days / 30) / 6;
        }
    }
}
