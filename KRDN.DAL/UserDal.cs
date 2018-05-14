using KRDN.IDAL;
using KRDN.Model;
using System;
using System.Collections.Generic;

namespace KRDN.DAL
{

    /// <summary>
    /// KRDN.Oracle.DAL의 UserDal대신 사용하려면 UserInterface 프로젝트의 참조만 바꾸어 주면됨
    /// </summary>
    public class UserDal : IUserDal
    {
        public User GetUser(int userNo)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUserList()
        {
            throw new NotImplementedException();
        }
    }
}
