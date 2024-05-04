using SofaSoGood.Model;
using SofaSoGood.Controller;
using SofaSoGood.View;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text;

namespace SofaSoGood
{
    /// <summary>
    /// Login form that handles user authentication.
    /// </summary>
    public partial class LoginForm : Form
    {
        
        private readonly LoginController loginController;
       
        private readonly EmployeeController employeeController;
        
        private readonly MemberDashboard MainDashboard;

        private readonly AdminController adminController;

        public Employee LoggedInEmployee;

        /// <summary>
        /// Constructs the LoginForm and initializes its components.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.LoginWarningLabel.Text = string.Empty;
            this.MainDashboard = new MemberDashboard(this);
            loginController = new LoginController();
            employeeController = new EmployeeController();
            adminController = new AdminController();
        }

        /// <summary>
        /// Validates user input against DB credentials on login button click.
        /// If validation is successful, hides the login form and shows the main dashboard.
        /// Otherwise, displays an error message.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void LoginButtonClick(object sender, EventArgs e)
        {
            string hashedUsername = ComputeMd5Hash(this.UsernameTextBox.Text);
            string hashedPassword = ComputeMd5Hash(this.PasswordTextBox.Text);

            if (loginController.VerifyUserCredentials(hashedUsername, hashedPassword))
            {
                int loginID = loginController.GetLoginIDByUsernameAndPassword(hashedUsername, hashedPassword);

                var admin = adminController.GetAdminByLoginID(loginID);
                if (admin != null)
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.SetCurrentAdmin(admin.FirstName + " " + admin.LastName);
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    var employee = employeeController.GetEmployeeByLoginID(loginID);
                    if (employee != null)
                    {
                        MemberDashboard memberDashboard = new MemberDashboard(this);
                        memberDashboard.SetCurrentUserLabel(employee.FirstName + " " + employee.LastName);
                        this.LoggedInEmployee = employee;
                        memberDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        ShowLoginError();
                    }
                }
            }
            else
            {
                ShowLoginError();
            }
        }

        private void ShowLoginError()
        {
            this.LoginWarningLabel.ForeColor = Color.Red;
            this.LoginWarningLabel.Text = "Incorrect Username/Password";
            this.UsernameTextBox.Text = string.Empty;
            this.PasswordTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Clears the error message when the user begins typing their UserName or Password again.
        /// </summary>
        private void UsernameOrPasswordTextBoxTextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.UsernameTextBox.Text) && !string.IsNullOrWhiteSpace(this.PasswordTextBox.Text))
            {
                this.LoginWarningLabel.Text = string.Empty;
            }    
        }

        /// <summary>
        /// Ensures that the application exits properly when closed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Provides data for the FormClosed event.</param>
        private void LoginFormFormClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Sets the LoggedInEmployee.
        /// </summary>
        /// <param name="PassedInEmployee">Sets the LoggedInEmployee after logging in.</param>
        private void SetLoggedInEmployee(Employee PassedInEmployee)
        {
            this.LoggedInEmployee = PassedInEmployee;
        }

        /// <summary>
        /// Hashing because it wasn't done.
        /// </summary>
        private string ComputeMd5Hash(string input)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.Unicode.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
