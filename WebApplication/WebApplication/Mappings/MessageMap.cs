using FluentNHibernate.Mapping;
using WebApplication.Models;

namespace WebApplication.Mappings
{
    public class MessageMap : ClassMap<Message>
    {
        public MessageMap()
        {
            Id(x => x.Id).Column("id").GeneratedBy.Identity();
            References(x => x.Author).Column("author_id").Not.Nullable();
            References(x => x.Topic).Column("topic_id").Not.Nullable();
            Map(x => x.Content).Column("content").Not.Nullable();
            Map(x => x.CreatedAt).Column("created_at").Not.Nullable();
        }
    }
}