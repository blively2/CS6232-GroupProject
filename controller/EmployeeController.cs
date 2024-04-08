using SofaSoGood.DAL;
using SofaSoGood.Model;

namespace SofaSoGood.Controller
{
    /// <summary>
    /// This class is the controller for Employees
    /// </summary>
    public class EmployeeController
    {
        private readonly EmployeeDAL employeeDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        public EmployeeController()
        {
            employeeDAL = new EmployeeDAL();
        }

        /// <summary>
        /// Gets an Employee by LoginID.
        /// </summary>
        public Employee GetEmployeeByLoginID(int LoginID)
        {
            return employeeDAL.GetEmployeeByLoginID(LoginID);
        }

        /// <summary>
        /// Gets an Employee by EmployeeID.
        /// </summary>
        public Employee GetEmployeeByEmployeeID(int EmployeeID)
        {
            return employeeDAL.GetEmployeeByEmployeeID(EmployeeID);
        }
    }
}
