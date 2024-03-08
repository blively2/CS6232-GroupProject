using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SofaSoGood
{
    /// <summary>
    /// Login form that handles user authentication.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Constructs the LoginForm and initializes its components.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.LoginWarningLabel.Text = string.Empty;
        }

        /// <summary>
        /// Validates user input against predefined credentials on login button click.
        /// If validation is successful, hides the login form and shows the main dashboard.
        /// Otherwise, displays an error message.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void LoginButtonClick(object sender, EventArgs e)
        {
            if (this.UsernameTextBox.Text == "employee" && this.PasswordTextBox.Text == "test1234")
            {
                //Do something to indicate login success and show the next form
                System.Diagnostics.Debug.WriteLine("Login Successful");
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

    }
}
