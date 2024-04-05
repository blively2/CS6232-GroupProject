using SofaSoGood.Model;
using SofaSoGood.Controller;
using SofaSoGood.View;
using System;
using System.Windows.Forms;

namespace SofaSoGood
{
    /// <summary>
    /// Login form that handles user authentication.
    /// </summary>
    public partial class LoginForm : Form
    {
        // Reference to LoginController
        private readonly LoginController loginController;
        // Reference to EmployeeController
        private readonly EmployeeController employeeController;
        // Reference to MemberDashboard
        private readonly MemberDashboard MainDashboard;
        // Reference to Employee that is logged in currently
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
            if (loginController.VerifyUserCredentials(this.UsernameTextBox.Text, this.PasswordTextBox.Text))
            {
                int loggedInEmployeeID = loginController.GetLoginIDByUsernameAndPassword(this.UsernameTextBox.Text, this.PasswordTextBox.Text);
                Employee loggedInEmployee = employeeController.GetEmployeeByLoginID(loggedInEmployeeID);
                this.SetLoggedInEmployee(loggedInEmployee);
                this.Hide();
                this.MainDashboard.SetCurrentUserLabel(loggedInEmployee.FirstName + " " + loggedInEmployee.LastName);
                this.MainDashboard.Show();
                this.UsernameTextBox.Text = string.Empty;
                this.PasswordTextBox.Text = string.Empty;
            }
            else
            {
                this.UsernameTextBox.Text = string.Empty;
                this.PasswordTextBox.Text = string.Empty;
                this.LoginWarningLabel.Text = "Incorrect Username/Password";
            }
        }

        /// <summary>
        /// Clears the error message when the user begins typing their UserName or Password again.
        /// </summary>
        private void UsernameOrPasswordTextBoxTextChanged(object sender, EventArgs e)
        {
            this.LoginWarningLabel.Text = string.Empty;
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
    }
}
