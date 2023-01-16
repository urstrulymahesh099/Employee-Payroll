using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll.Repository
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Click Below Options:\n1.CreateDatabase");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    EmployeeRepository employeeRepository = new EmployeeRepository();
                    employeeRepository.CreateDatabase();
                    break;
            }
         
        }
    }
}
       