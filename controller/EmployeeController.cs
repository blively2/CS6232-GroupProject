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

        public Employee GetEmployeeByLoginID(int LoginID)
        {
            return employeeDAL.GetEmployeeByLoginID(LoginID);
        }
    }
}
