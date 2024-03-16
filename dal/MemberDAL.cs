using SofaSoGood.Model;
using System;
using System.Data.SqlClient;
using System.Data;

namespace SofaSoGood.DAL
{
    /// <summary>
    /// This class is data access layer between model and view for Members
    /// </summary>
    public class MemberDAL
    {
        /// <summary>
        /// Adds a new member to the database.
        /// </summary>
        /// <param name="member">The member to add.</param>
        public int AddMember(Member member)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string insertQuery = @"
                    INSERT INTO [dbo].[Member]
                    (FirstName, LastName, Gender, DateOfBirth, Address1, Address2, City, State, Zip, ContactPhone)
                    VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @Address1, @Address2, @City, @State, @Zip, @ContactPhone);
                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

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
                    int newMemberId = Convert.ToInt32(cmd.ExecuteScalar());
                    return newMemberId;
                }
            }
        }

        /// <summary>
        /// Gets the member by identifier.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <returns></returns>
        public Member GetMemberById(int memberId)
        {
            Member member = null;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Member] WHERE MemberID = @MemberID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("MemberID", SqlDbType.Int).Value = memberId;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            member = new Member
                            {
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Address1 = reader.GetString(reader.GetOrdinal("Address1")),
                                Address2 = reader.IsDBNull(reader.GetOrdinal("Address2")) ? null : reader.GetString(reader.GetOrdinal("Address2")),
                                City = reader.GetString(reader.GetOrdinal("City")),
                                State = reader.GetString(reader.GetOrdinal("State")),
                                Zip = reader.GetString(reader.GetOrdinal("Zip")),
                                ContactPhone = reader.GetString(reader.GetOrdinal("ContactPhone")),
                            };
                        }
                    }
                }
            }
            return member;
        }

        /// <summary>
        /// Gets the member by identifier.
        /// </summary>
        /// <param name="contactPhone">The member phone number.</param>
        /// <returns></returns>
        public Member GetMemberByPhone(string contactPhone)
        {
            Member member = null;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Member] WHERE ContactPhone = @ContactPhone";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ContactPhone", SqlDbType.VarChar, 10).Value = contactPhone;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            member = new Member
                            {
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Address1 = reader.GetString(reader.GetOrdinal("Address1")),
                                Address2 = reader.IsDBNull(reader.GetOrdinal("Address2")) ? null : reader.GetString(reader.GetOrdinal("Address2")),
                                City = reader.GetString(reader.GetOrdinal("City")),
                                State = reader.GetString(reader.GetOrdinal("State")),
                                Zip = reader.GetString(reader.GetOrdinal("Zip")),
                                ContactPhone = reader.GetString(reader.GetOrdinal("ContactPhone")),
                            };
                        }
                    }
                }
            }
            return member;
        }

        /// <summary>
        /// Gets the member by firstName and lastName.
        /// </summary>
        /// <param name="firstName">The member's first name.</param>
        /// <param name="lastName">The member's last name.</param>
        /// <returns></returns>
        public Member GetMemberByName(string firstName, string lastName)
        {
            Member member = null;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Member] WHERE FirstName = @FirstName AND LastName = @LastName";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 200).Value = firstName;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar, 200).Value = lastName;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            member = new Member
                            {
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Address1 = reader.GetString(reader.GetOrdinal("Address1")),
                                Address2 = reader.IsDBNull(reader.GetOrdinal("Address2")) ? null : reader.GetString(reader.GetOrdinal("Address2")),
                                City = reader.GetString(reader.GetOrdinal("City")),
                                State = reader.GetString(reader.GetOrdinal("State")),
                                Zip = reader.GetString(reader.GetOrdinal("Zip")),
                                ContactPhone = reader.GetString(reader.GetOrdinal("ContactPhone")),
                            };
                        }
                    }
                }
            }
            return member;
        }

        /// <summary>
        /// Updates the member.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns></returns>
        public bool UpdateMember(Member member)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                var query = @"UPDATE Member SET Address1 = @Address1, Address2 = @Address2,
                          City = @City, State = @State, Zip = @Zip, ContactPhone = @ContactPhone
                          WHERE MemberID = @MemberID";
                using (var command = new SqlCommand(query, connection))
                { 
                    command.Parameters.Add("@Address1", SqlDbType.VarChar, 150).Value = member.Address1;
                    command.Parameters.Add("@Address2", SqlDbType.VarChar, 150).Value = member.Address2;
                    command.Parameters.Add("@City", SqlDbType.VarChar, 45).Value = member.City;
                    command.Parameters.Add("@State", SqlDbType.VarChar, 45).Value = member.State;
                    command.Parameters.Add("@Zip", SqlDbType.VarChar, 10).Value = member.Zip;
                    command.Parameters.Add("@ContactPhone", SqlDbType.Char, 10).Value = member.ContactPhone;
                    command.Parameters.Add("MemberID", SqlDbType.Int).Value = member.MemberID;

                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
