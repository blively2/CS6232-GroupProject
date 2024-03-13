using SofaSoGood.DAL;
using SofaSoGood.Model;
using System;

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
    }
}
