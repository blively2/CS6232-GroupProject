using SofaSoGood.DAL;
using SofaSoGood.Model;

namespace SofaSoGood.Controller
{
    /// <summary>
    /// This class is the controller for Admin
    /// </summary>
    public class AdminController
    {
        private readonly AdminDAL adminDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminController"/> class.
        /// </summary>
        public AdminController()
        {
            adminDAL = new AdminDAL();
        }

        /// <summary>
        /// Gets the admin by login identifier.
        /// </summary>
        /// <param name="loginID">The login identifier.</param>
        /// <returns></returns>
        public Admin GetAdminByLoginID(int loginID)
        {
            return adminDAL.GetAdminByLoginID(loginID);
        }
    }
}
