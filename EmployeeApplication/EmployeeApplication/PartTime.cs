using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    
        public class PartTime : IEmployee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
            public string JobTitle { get; set; }
            public double BasicSalary { get; set; }
            public double ratePerHour { get; set; }
            public int TotalHoursWorked { get; set; }

            public double ComputeSalary()
            {
                return (BasicSalary * TotalHoursWorked);
            }

        }
    }
}
