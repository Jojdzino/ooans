using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Strategy
{
    class AddUnknownUserStrategy : IAddUserStrategy
    {
        public User AddUser(string name)
        {
            Console.WriteLine("Adding unknown person into room");
            return new User();

        }
    }
}
