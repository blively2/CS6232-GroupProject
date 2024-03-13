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

        public Boolean VerifyUserCredentials(string Username, string Password)
        {
            return loginDAL.VerifyUserCredentials(Username, Password);
        }

        public int GetLoginIDByUsernameAndPassword(string Username, string Password)
        {
            return loginDAL.GetLoginIDByUsernameAndPassword(Username, Password);
        }
    }
}