using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class EmployeeData
    {
        public EmployeeName GetEmployeeName(EmployeeNameRequest request)
        {
            EmployeeName empName = new EmployeeName();
            switch (request.EmpId)
            {
                case "1":
                    empName.FirstName = "Andrew";
                    empName.LastName = "Kang";
                    break;
                case "2":
                    empName.FirstName = "Dave";
                    empName.LastName = "Williams";
                    break;
                default:
                    break;
            }
            return empName;
        }
    }
}