using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public class ChatServer : IChatServer
    {
        private List<IUser> _users = new List<IUser>();
        private int  counter = 0;

        public void RegisterUser(IUser user)
        {
            //register user and notify each user that a new one joined the club

            if (user.Activity == Activity.Observer) counter++;
            if (!_users.Contains(user) && _users.Count() != 10 && counter < 3)
            {
                
                _users.ForEach(x => x.ReceiveMessage(x.Name, $"User {user.Name} is online"));
                _users.Add(user);
            }

        }

        public void Unregister(IUser user)
        {
            //unregister user and notify each user that one leaved the club
            if (_users.Contains(user))
            {
                if (user.Activity == Activity.Observer) counter--;
                _users.Remove(user);
                _users.ForEach(x => x.ReceiveMessage(x.Name, $"User {user.Name} is offline"));
            }
        }

        public void SendMessage(string sendername , string message)
        {
            foreach (IUser us in _users) {
                if (us.Name == sendername)
                    foreach (IUser user in _users)
                    {
                      if(user.Name != sendername)  Console.WriteLine($"Message from {sendername} to {user.Name} : {message}");
                    };
            }

           
        }
    }
}
