using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace WebApplication.Models
{
    public class User : IUser<int>
    {
        public virtual int Id { get; protected set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual string Role { get; set; }
        public virtual IList<Message> Messages { get; set; }
        public virtual IList<Topic> TopicsBannedIn { get; set; }

        public User()
        {
            Messages = new List<Message>();
            TopicsBannedIn = new List<Topic>();
        }

        public virtual void AddMessage(Message message)
        {
            message.Author = this;
            Messages.Add(message);
            Topic topic = message.Topic;
            topic.Messages.Add(message);
        }
    }
}