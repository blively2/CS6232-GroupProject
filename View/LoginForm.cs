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

        private readonly AdminController adminController;

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
            if (loginController.VerifyUserCredentials(this.UsernameTextBox.Text, this.PasswordTextBox.Text))
            {
                int loginID = loginController.GetLoginIDByUsernameAndPassword(this.UsernameTextBox.Text, this.PasswordTextBox.Text);

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
            this.LoginWarningLabel.Text = "Incorrect Username/Password";
            this.UsernameTextBox.Text = string.Empty;
            this.PasswordTextBox.Text = string.Empty;
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
