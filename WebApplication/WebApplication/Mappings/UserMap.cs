using FluentNHibernate.Mapping;
using WebApplication.Models;

namespace WebApplication.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id).Column("id").GeneratedBy.Identity();
            Map(x => x.UserName).Column("username").Not.Nullable();
            Map(x => x.Password).Column("password").Not.Nullable();
            Map(x => x.CreatedAt).Column("created_at").Not.Nullable();
            Map(x => x.Role).Column("role").Not.Nullable();
            HasMany(x => x.Messages).KeyColumn("author_id").Inverse().Cascade.All();
            HasManyToMany(x => x.TopicsBannedIn).Cascade.All()
                .Table("banned_users")
                .ParentKeyColumn("user_id")
                .ChildKeyColumn("topic_id");
        }
    }
}