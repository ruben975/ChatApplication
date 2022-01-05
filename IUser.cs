using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public interface IUser
    {
        void SendMessage(string message);
        void ReceiveMessage(string userName, string message);
        int Id { get; }
        string Name { get; }
        public Activity Activity { get; }

    }
}
