using System.Windows.Forms;

namespace SofaSoGood.View
{
    /// <summary>
    /// Admin Dashboard
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AdminDashboard : Form
    {
        private readonly LoginForm LoginForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDashboard"/> class.
        /// </summary>
        public AdminDashboard()
        {
            InitializeComponent();
            this.LoginForm = new LoginForm();
        }

        /// <summary>
        /// Sets the current admin.
        /// </summary>
        /// <param name="adminName">Name of the admin.</param>
        public void SetCurrentAdmin(string adminName)
        {
            this.welcomeAdminLabel.Text = "Welcome, " + adminName;
        }

        /// <summary>
        /// Handles the LinkClicked event of the LogoutLinkLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.LoginForm.Show();
        }
    }
}
