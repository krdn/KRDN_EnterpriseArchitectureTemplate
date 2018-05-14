using KRDN.Model;
using System;
using System.Collections.Generic;

namespace KRDN.IDAL
{
    public interface IUserDal
    {
        List<User> GetUserList();

        User GetUser(int userNo);
    }
}
