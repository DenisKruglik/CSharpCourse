using System;

namespace WebApplication.Models
{
    public class Message
    {
        public virtual int Id { get; set; }
        public virtual User Author { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual string Content { get; set; }
        public virtual DateTime CreatedAt { get; set; }
    }
}