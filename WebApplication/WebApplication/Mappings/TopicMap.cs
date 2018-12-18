using FluentNHibernate.Mapping;
using WebApplication.Models;

namespace WebApplication.Mappings
{
    public class TopicMap : ClassMap<Topic>
    {
        public TopicMap()
        {
            Id(x => x.Id).Column("id").GeneratedBy.Identity();
            Map(x => x.Title).Column("title").Not.Nullable();
            References(x => x.Author).Column("author_id").Not.Nullable();
            HasMany(x => x.Messages).KeyColumn("topic_id").Inverse().Cascade.All();
            HasManyToMany(x => x.BannedUsers).Cascade.All().Table("banned_users")
                .ParentKeyColumn("topic_id")
                .ChildKeyColumn("user_id");
        }
    }
}