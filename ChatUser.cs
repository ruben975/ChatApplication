using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public class ChatUser:IUser
    {
        private readonly IChatServer _chatServer;

        public int Id { get; }
        public string Name { get; }
        public Activity Activity { get; }

        public ChatUser(string name, IChatServer chatServer,Activity activity)
        {
            Activity = activity;
            Id = new Random().Next();
            Name = name;
            _chatServer = chatServer;
        }


        public void SendMessage(string message)
        {
            if (this.Activity == Activity.Observer)
                Console.WriteLine($"Sorry {this.Name} you are only observer, you can't send a message");
            else
            _chatServer.SendMessage(this.Name, message);
        }

        public void ReceiveMessage(string userName, string message)
        {
            Console.WriteLine($"Received message from {userName}: {message}");
        }


    }
}
