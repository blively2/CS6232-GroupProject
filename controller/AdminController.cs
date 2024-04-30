using SofaSoGood.DAL;
using SofaSoGood.Model;
using System;
using System.Collections.Generic;

namespace SofaSoGood.Controller
{
    /// <summary>
    /// This class is the controller for Admin
    /// </summary>
    public class AdminController
    {
        private readonly AdminDAL adminDAL;
        private readonly FurnitureReportDAL furnitureReportDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminController"/> class.
        /// </summary>
        public AdminController()
        {
            this.adminDAL = new AdminDAL();
            this.furnitureReportDAL = new FurnitureReportDAL();
        }

        /// <summary>
        /// Gets the admin by login identifier.
        /// </summary>
        /// <param name="loginID">The login identifier.</param>
        /// <returns></returns>
        public Admin GetAdminByLoginID(int loginID)
        {
            return adminDAL.GetAdminByLoginID(loginID);
        }

        /// <summary>
        /// Fetches the popular furniture.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public List<FurnitureReportItem> FetchPopularFurniture(DateTime startDate, DateTime endDate)
        {
            return furnitureReportDAL.GetPopularFurniture(startDate, endDate);
        }
    }
}
