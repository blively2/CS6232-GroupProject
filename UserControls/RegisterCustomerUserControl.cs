using System.Windows.Forms;

namespace SofaSoGood
{
    /// <summary>
    /// UserControl for Registering Customers in the database.
    /// Has an CustomerController instance to interact with the DB.
    /// </summary>
    public partial class RegisterCustomerUserControl : UserControl
    {
        /// <summary>
        /// Constructor for RegisterCustomerUserControl.
        /// Initializes the controller and the component for the UI.
        /// </summary>
        public RegisterCustomerUserControl()
        {
            InitializeComponent();
        }
    }
}
