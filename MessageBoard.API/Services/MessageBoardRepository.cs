using MessageBoard.API.DbContexts;
using MessageBoard.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageBoard.API.Services
{
    public class MessageBoardRepository : IMessageBoardRepository
    {
        private readonly MessageBoardContext _context;

        public MessageBoardRepository(MessageBoardContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddMessage(Message message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            _context.Messages.Add(message);
        }

        public IEnumerable<Message> GetAll()
        {
            return _context.Messages
                           .OrderBy(m => m.Body)
                           .ToList();
        }

        public Message GetMessage(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return _context.Messages.FirstOrDefault(a => a.Id == id);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
