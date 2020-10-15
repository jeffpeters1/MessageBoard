using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace MessageBoard.API.Entities
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(280)]
        public string Body { get; set; }


    }
}