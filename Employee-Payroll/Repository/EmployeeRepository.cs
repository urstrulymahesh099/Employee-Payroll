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
        public static void CreateTable()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial catalog=EmpPayroll;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create table employee(id int primary key identity(1,1),name varchar(200)," +
                            "PhoneNumber bigint, Address varchar(200),Department varchar(200),Gender char,Basic_Pay bigint," +
                               "Deduction bigint, Taxable_pay bigint, Tax bigint,Net_Pay bigint,start_date date )", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created");
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

    