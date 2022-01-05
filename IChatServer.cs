using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public interface IChatServer
    {
        void RegisterUser(IUser user);
        void Unregister(IUser user);
        void SendMessage(string senderName, string message);
    }
}
