using Link_D.Models.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Link_D.Extensions
{
    public static class Session
    {

        #region keys

        public static readonly string User_Id = "User_Id";

        #endregion

        public static readonly string User_;

        #region UserId

        public static void SetUserId(this ISession session, int? val)
        {
            byte[] bytes = BitConverter.GetBytes(val.Value);
            session.Set(User_Id, bytes);
        }
        
        public static int GetUserId(this ISession session)
        {
            byte[] val = session.Get(User_Id);
           return  BitConverter.ToInt32(val);
        }

        #endregion

    }
}
