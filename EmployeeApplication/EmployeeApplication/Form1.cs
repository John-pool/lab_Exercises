namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void ComputeSalary_Click(object sender, EventArgs e)
        {
            PartTime employee = new PartTime
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Department = DepartmentTextBox.Text,
                JobTitle = JobTitleTextBox.Text,

                ratePerHour = double.Parse(RatePerHourTextBox.Text),
                TotalHoursWorked = int.Parse(TotalHoursTextBox.Text),
            };

            double salary = employee.ComputeSalary();
            string Fname = employee.FirstName;
            string Lname = employee.LastName;

            FirstNameTextBox.Text = Fname;
            LastNameTextBox.Text = Lname;

            label9.Text = salary.ToString("C");
        }
    }
}
