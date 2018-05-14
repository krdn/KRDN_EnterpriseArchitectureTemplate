using KRDN.IDAL;
using KRDN.Model;
using System;
using System.Collections.Generic;

namespace KRDN.BLL
{
    public class UserBll
    {
        private readonly IUserDal _userDal; // DI에 사용함.

        public UserBll(IUserDal userDal)
        {
            _userDal = userDal;
        }
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
