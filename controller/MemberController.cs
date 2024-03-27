using SofaSoGood.DAL;
using SofaSoGood.Model;
using System;
using System.Collections.Generic;

namespace SofaSoGood.Controller
{
    /// <summary>
    /// This class is the controller for Members
    /// </summary>
    public class MemberController
    {
        private readonly MemberDAL memberDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberController"/> class.
        /// </summary>
        public MemberController()
        {
            memberDAL = new MemberDAL();
        }

        /// <summary>
        /// Adds the member.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns></returns>
        public int AddMember(Member member)
        {
            try
            {
                int newMemberId = memberDAL.AddMember(member);
                return newMemberId;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// Gets the member by identifier.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <returns></returns>
        public Member GetMemberById(int memberId)
        {
            return memberDAL.GetMemberById(memberId);
        }

        /// <summary>
        /// Gets the member by contactPhone.
        /// </summary>
        /// <param name="contactPhone">The member contactPhone.</param>
        /// <returns></returns>
        public List<Member> GetMemberByPhone(string contactPhone)
        {
            return memberDAL.GetMemberByPhone(contactPhone);
        }

        /// <summary>
        /// Gets the member by firstName and lastName together.
        /// </summary>
        /// <param name="firstName">The member firstName.</param>
        /// /// <param name="lastName">The member lastName.</param>
        /// <returns></returns>
        public List<Member> GetMemberByName(string firstName, string lastName)
        {
            return memberDAL.GetMembersByName(firstName, lastName);
        }

        /// <summary>
        /// Updates the member.
        /// </summary>
        /// <param name="updatedMember">The updated member.</param>
        /// <returns></returns>
        public int UpdateMember(Member updatedMember)
        {
            var currentMember = memberDAL.GetMemberById(updatedMember.MemberID);
            if (currentMember != null && !currentMember.HasChanges(updatedMember))
            {
                return -1;
            }
            return memberDAL.UpdateMember(updatedMember) ? 1 : 0;
        }
    }
}
