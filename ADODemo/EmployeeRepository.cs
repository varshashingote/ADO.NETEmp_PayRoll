using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    public class EmployeeRepository
    {

        public static string connectionString = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=PayRollService248;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection sqlConnection = null;
        public static void GetAllEmployees()
        {

            sqlConnection = new SqlConnection(connectionString);
            string query = "select*from Employee_PayRoll";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            EmployeePayRoll model = new EmployeePayRoll();
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();


        }
    }
}
