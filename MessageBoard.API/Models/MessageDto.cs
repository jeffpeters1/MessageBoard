using System;

namespace MessageBoard.API.Models
{
    public class MessageDto
    {
        public Guid Id { get; set; }

        public string Body { get; set; }
    }
}
