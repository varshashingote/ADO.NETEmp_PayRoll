using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            EmployeeRepository model = new EmployeeRepository();
            model.Name = 'Vishu';
            model.id = 7;
            model.Basic_pay = 1234;


            EmployeeRepository.AddEmployee(model);

            Console.ReadLine();

        }
    }
}
