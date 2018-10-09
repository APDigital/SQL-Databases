using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace EmployeePensionManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionRepository connection = new ConnectionRepository();
            IEnumerable<Employee> employeeList =  connection.ListAllEmployee();
            IEnumerable<JobPositions> jobPositionList = connection.ListAllJobPosition();
            IEnumerable<PensionFundTable> pensionFundList = connection.ListAllPensionFund();
            IEnumerable<PensionProvider> pensionProviderList = connection.ListAllPensionProvider();

            foreach (var pensionFund in pensionFundList)
            {
                string printEmployee = string.Format("Employee Name: {0} {1}, Job Position {2}, Pension Fund Contribution: {3}", pensionFund.Employee.FirstName, pensionFund.Employee.LastName, pensionFund.Employee.JobPosition.JobPosition, pensionFund.Contribution);
                Console.WriteLine(printEmployee);
            }

            Console.ReadLine();
        }
    }
}
