using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Mediator
{
    // Colleague (User) nesneler arasındaki iletişim arayüzünü tanımlar.
    interface IChatRoomMediator
    {
        void SendMessage(string message, int userId);
        void AddUserInRoom(User user);
    }
}
