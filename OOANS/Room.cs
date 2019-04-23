using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOANS.Iterator;
using OOANS.Observer;

namespace OOANS
{
    public class Room : IObservable, IIterable
    {
        // TODO: Aggregations ?
        private IList<IObserver> observers = new List<IObserver>();
        private IList<Message> messages = new List<Message>();

        private IAddUserStrategy _addUserStrategy;

        private IList<User> users = new List<User>();

        public IAddUserStrategy AddUserStrategy { get; set; }
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<Message> Messages { get => messages; }

        public void AddMessage(Message message)
        {
            NotifyObservers(message);
        }

        public void NotifyObservers(Message message)
        {
            foreach(var o in observers)
            {
                o.Update(message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            if(!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void AddUser(string name)
        {
            users.Add(AddUserStrategy.AddUser(name));
        }

        public IIterator GetIterator(User user)//if user is null then you get iterator to go over all messages otherwise you get iterator to go over messages of that user in room
        {
            if (user == null)
                return new AllUsersIterator(this);
            return new SingleUserIterator(user,this);
        }
    }
}
