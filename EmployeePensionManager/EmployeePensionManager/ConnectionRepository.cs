using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePensionManager
{
    public class ConnectionRepository : ConnectionFactory
    {
        public IEnumerable<Employee> ListAllEmployee()
        {
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                string query = "select * from Employee e join JobPosition j on j.Id = e.JobPositionID Order by e.JobPositionID";
                return connection.Query<Employee, JobPositions, Employee>(query, (employee, jobPosition) => { employee.JobPosition = jobPosition; return employee; });
            }
        }
        public IEnumerable<JobPositions> ListAllJobPosition()
        {
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                string query = "select * from JobPosition";
                return connection.Query<JobPositions>(query);
            }
        }

        public IEnumerable<PensionFundTable> ListAllPensionFund()
        {
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                string query = "select * from PensionFundTable pft join Employee e on e.Id = pft.EmployeeID Order by pft.EmployeeID";
                return connection.Query<PensionFundTable, Employee, PensionFundTable>(query, (pensionFundTable, employee) => { pensionFundTable.Employee = employee; return pensionFundTable; });
            }
        }

        public IEnumerable<PensionProvider> ListAllPensionProvider()
        {
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                string query = "select * from PensionProvider";
                return connection.Query<PensionProvider>(query);
            }
        }
    }
}
