using SofaSoGood.DAL;
using SofaSoGood.Model;
using System;

namespace SofaSoGood.Controller
{
    public class MemberController
    {
        private readonly MemberDAL memberDAL;

        public MemberController()
        {
            memberDAL = new MemberDAL();
        }

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
    }
}
