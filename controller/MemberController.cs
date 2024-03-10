using SofaSoGood.DAL;
using SofaSoGood.Model;
using System;

namespace SofaSoGood.Controller
{
    public class MemberController
    {
        public static bool AddMember(Member member)
        {
            try
            {
                MemberDAL.AddMember(member);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
