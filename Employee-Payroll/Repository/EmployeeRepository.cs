using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll.Repository
{
    public class EmployeeRepository
    {
        public void CreateDatabase()
        {
            try
            {
                SqlConnection connectin = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial catalog=master;
                Integrated Security=true");
                connectin.Open();
                SqlCommand cmd = new SqlCommand("create database EmpPayroll", connectin);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database created successfully");
                Console.WriteLine("Connection is established with database");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Connection is not established with database");
            }
        }
    }
}

    