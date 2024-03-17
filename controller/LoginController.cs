using SofaSoGood.DAL;
using System;

namespace SofaSoGood.Controller
{
    /// <summary>
    /// This class is the controller for Login.
    /// </summary>
    public class LoginController
    {
        private readonly LoginDAL loginDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        public LoginController()
        {
            loginDAL = new LoginDAL();
        }

        /// <summary>
        /// Verifies the user credentials.
        /// </summary>
        /// <param name="Username">The username.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        public Boolean VerifyUserCredentials(string Username, string Password)
        {
            return loginDAL.VerifyUserCredentials(Username, Password);
        }

        /// <summary>
        /// Gets the login identifier by username and password.
        /// </summary>
        /// <param name="Username">The username.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        public int GetLoginIDByUsernameAndPassword(string Username, string Password)
        {
            return loginDAL.GetLoginIDByUsernameAndPassword(Username, Password);
        }
    }
}