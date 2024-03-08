using System.Windows.Forms;

namespace SofaSoGood.UserControls
{
    /// <summary>
    /// UserControl for Editing Customers in the database.
    /// Has an CustomerController instance to interact with the DB.
    /// </summary>
    public partial class EditCustomerUserControl : UserControl
    {
        /// <summary>
        /// Constructor for EditCustomerUserControl.
        /// Initializes the controller and the component for the UI.
        /// </summary>
        public EditCustomerUserControl()
        {
            InitializeComponent();
        }
    }
}
