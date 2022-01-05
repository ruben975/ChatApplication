using System;

namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatServer = new ChatServer();

            var john = new ChatUser("John", chatServer,Activity.Observer);
            var doe = new ChatUser("Doe", chatServer, Activity.Activ);
            var andrew = new ChatUser("Andrew", chatServer, Activity.Activ);
            var andrea = new ChatUser("Andrea", chatServer, Activity.Activ);
            

            chatServer.RegisterUser(andrea);
            chatServer.RegisterUser(john);
            chatServer.RegisterUser(doe);

            chatServer.RegisterUser(andrew);



            john.SendMessage("Are you ok?");
            doe.SendMessage("YEs");

            Console.ReadLine();
        }
    }
}