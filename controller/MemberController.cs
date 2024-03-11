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

        public bool AddMember(Member member)
        {
            try
            {
                memberDAL.AddMember(member);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
