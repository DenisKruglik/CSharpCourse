using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Topic
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual User Author { get; set; }
        public virtual IList<Message> Messages { get; set; }
        public virtual IList<User> BannedUsers { get; set; }

        public Topic()
        {
            Messages = new List<Message>();
            BannedUsers = new List<User>();
        }

        public virtual void BanUser(User user)
        {
            BannedUsers.Add(user);
            user.TopicsBannedIn.Add(this);
        }

        public virtual void AddMessage(Message message)
        {
            Messages.Add(message);
            message.Topic = this;
            User author = message.Author;
            author.Messages.Add(message);
        }
    }
}