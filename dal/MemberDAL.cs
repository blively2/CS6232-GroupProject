using SofaSoGood.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaSoGood.DAL
{
    internal class MemberDAL
    {
        /// <summary>
        /// Adds a new member to the database.
        /// </summary>
        /// <param name="member">The member to add.</param>
        public static void AddMember(Member member)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string insertQuery = @"
                INSERT INTO [dbo].[Member] 
                (FirstName, LastName, Gender, DateOfBirth, Address1, Address2, City, State, Zip, ContactPhone)
                VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @Address1, @Address2, @City, @State, @Zip, @ContactPhone);";

                using (var cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 200).Value = member.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 200).Value = member.LastName;
                    cmd.Parameters.Add("@Gender", SqlDbType.Char, 1).Value = member.Gender;
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = member.DateOfBirth;
                    cmd.Parameters.Add("@Address1", SqlDbType.VarChar, 150).Value = member.Address1;
                    cmd.Parameters.Add("@Address2", SqlDbType.VarChar, 150).Value = member.Address2;
                    cmd.Parameters.Add("@City", SqlDbType.VarChar, 45).Value = member.City;
                    cmd.Parameters.Add("@State", SqlDbType.VarChar, 45).Value = member.State;
                    cmd.Parameters.Add("@Zip", SqlDbType.VarChar, 10).Value = member.Zip;
                    cmd.Parameters.Add("@ContactPhone", SqlDbType.Char, 10).Value = member.ContactPhone;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
