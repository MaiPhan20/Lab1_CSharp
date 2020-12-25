using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// The program demonstrates the use of XML comments.
/// 
/// Employee class uses constructors to initialize th ID and
/// name of the employee and displays them.
/// </summary>
/// <remarks>
/// This program uses both parameter and 
/// non-parameterized constructors.
/// </remarks>
/// 
namespace CodeSnipet5
{
    class Employee
    {
        /// <summary>
        /// Integer field to store employee ID.
        /// </summary>
        private int id;
        /// <summary>
        /// String field to store employee name.
        /// </summary>
        private string name;
        /// <summary>
        /// This constructor initializes the id and name to -1 and null.
        /// </summary>
        /// <remarks>
        /// <seealsccref="Employee(int,string)">Employee(int,string)</seealsccref>
    
        /// </remarks>
        public Employee()
        {
            id = -1;
            name = null;

        }
        /// <summary>
        /// This constructor initializes the id and name.
        /// (paramref name="id"/>,<paramref name="name"/>.
   
        /// </summary>
      
        /// <param name="id">Employee</param>
        /// <param name="name">Employee name</param>
        public Employee(int id,string name)
        {
            this.id = id;
            this.name = name;
        /// <summary>
        /// The entry point for the application.
        /// <param name="args">A list of command line arguments</param>
       
        /// </summary>
        /// 
        }
        static void Main(string[] args)
        {
            Employee objEmp = new Employee(101, "David Smith");
            Console.WriteLine("Employee id: {0} \nEmployeeName:{1}",
                objEmp.name);
        }
    }
}
