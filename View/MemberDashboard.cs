using System.Windows.Forms;

namespace SofaSoGood.View
{
    /// <summary>
    /// MainDashboard is primary form for Sofa So Good's Furniture Management System.
    /// </summary>
    public partial class MemberDashboard : Form
    {
        /// <summary>
        /// Accessible instance of the LoginForm passed into MainDashboard.
        /// </summary>
        private readonly LoginForm LoginForm;

        /// <summary>
        /// Initializes a new instance of the MainDashboard.
        /// Uses the LoginForm as a component
        /// </summary>
        public MemberDashboard(LoginForm LoginForm)
        {
            InitializeComponent();
            this.LoginForm = LoginForm;
        }

        /// <summary>
        /// Logs the User out of the MainDashboard and shows the component LoginForm.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Provides data for the FormClosed event.</param>
        private void LogoutLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.LoginForm.Show();
        }

        /// <summary>
        /// Sets the current user label to welcome them to the application.
        /// </summary>
        /// <param name="CurrentUser">The current user.</param>
        public void SetCurrentUserLabel(string CurrentUser)
        {
            this.WelcomeUserLabel.Text = "Welcome, " + CurrentUser;
        }

        /// <summary>
        /// Ensures that the application exits properly when closed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Provides data for the FormClosed event.</param>
        private void MainDashboardFormClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
