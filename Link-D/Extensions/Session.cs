using Link_D.Models.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Link_D.Extensions
{
    public static class Session
    {

        #region keys

        public static readonly string User_Id = "User_Id";


        #region UserId

        public static void SetUserId(this ISession session, int val)
        {
            session.Set(User_Id, val);
        }

    }
}
