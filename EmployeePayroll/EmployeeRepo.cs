using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace EmployeePayroll
{
    class EmployeeRepo
    {
        public static string connectionString = "Data Source=LAPTOP-N26M7CQ8\\SQLEXPRESS;Initial Catalog=payroll_service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void CheckConnection()
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel();
                using (this.connection)
                {
                    Console.WriteLine("Connection Established Successfully");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        
    }
}
