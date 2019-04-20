using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Strategy
{
    class AddFriendUserStrategy : IAddUserStrategy
    {
        public User AddUser(string name)
        {
            Console.WriteLine("Adding user into room from friends.");
            return new User();
        }
    }
}
