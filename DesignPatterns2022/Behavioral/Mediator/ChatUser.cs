using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Mediator
{
    // Colleague (User) soyutundan türer.
    // Mediator sayesinde diğer sınıf örnekler ile iletişim kurar.
    class ChatUser : User
    {
        public ChatUser(IChatRoomMediator chatRoomMediator) : base(chatRoomMediator)
        {
        }
    }
}
