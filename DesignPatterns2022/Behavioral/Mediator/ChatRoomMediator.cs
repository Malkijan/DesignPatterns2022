using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Mediator
{
    // Mediator (IChatRoomMediator) arayüzünü uygular.
    // Colleague (User) nesneleri arasındaki iletişimi koordine eder.
    class ChatRoomMediator : IChatRoomMediator
    {
        private Dictionary<int, User> _userDictonary;
        public ChatRoomMediator()
        {
            _userDictonary = new Dictionary<int, User>();
        }
        public void AddUserInRoom(User user)
        {
            _userDictonary.Add(user.id, user);
        }

        public void SendMessage(string message, int userId)
        {
            User user = _userDictonary[userId];
            user.ReceiveMessage(message);
        }
    }
}
