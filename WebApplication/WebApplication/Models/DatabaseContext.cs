using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.AspNet.Identity;
using NHibernate;
using WebApplication.Models.Identity;

namespace WebApplication.Models
{
    public class DatabaseContext
    {
        private readonly ISessionFactory sessionFactory;

        public DatabaseContext()
        {
            sessionFactory = Fluently.Configure()
                .Database(
                    MySQLConfiguration.Standard.ConnectionString(
                        c => c
                            .Server("localhost")
                            .Database("forum")
                            .Username("root")
                            .Password("root")
                    )   
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DatabaseContext>())
                .BuildSessionFactory();
        }
        public ISession MakeSession()
        {
            return sessionFactory.OpenSession();
        }

        public IUserStore<User, int> Users
        {
            get { return new IdentityStore(MakeSession()); }
        }
    }
}