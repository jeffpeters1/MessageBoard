using MessageBoard.API.Entities;
using System;
using System.Collections.Generic;

namespace MessageBoard.API.Services
{
    public interface IMessageBoardRepository
    {
        void AddMessage(Message message);
        IEnumerable<Message> GetAll();
        Message GetMessage(Guid id);
        bool Save();
    }
}
