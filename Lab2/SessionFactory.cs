using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Tool.hbm2ddl;

namespace Lab2
{
    public class SessionFactory
    {
        private static volatile ISessionFactory iSessionFactory;
        private static object syncRoot = new object();
        public static ISession OpenSession
        {
            get
            {
                if (iSessionFactory == null)
                {
                    lock (syncRoot)
                    {
                        if (iSessionFactory == null)
                        {
                            iSessionFactory = BuildSessionFactory();
                        }
                    }
                }
                return iSessionFactory.OpenSession();
            }
        }
        private static ISessionFactory BuildSessionFactory()
        {
            try
            {
                return Fluently.Configure().Database(PostgreSQLConfiguration.Standard.ConnectionString(
                    c => c.Host("localhost").Port(5432)
                    .Database("car_service")
                    .Username("new_user")
                    .Password("0000"))).Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>()).ExposeConfiguration(BuildSchema)
                    .BuildSessionFactory();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
            }
        }
        private static AutoPersistenceModel CreateModel()
        {
            return AutoMap.Assembly(System.Reflection.Assembly.GetCallingAssembly())
                .Where(test => test.Namespace == "Lab2.Model");
        }
        private static void BuildSchema(NHibernate.Cfg.Configuration config)
        {

        }
        /*public SessionFactory()
        {
            InitializeSessionFactory();
        }

        private static ISessionFactory _sessionFactory;

        private static ISessionFactory sessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }

                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure().Database(PostgreSQLConfiguration.Standard
                .ConnectionString(c =>
                    c.Host("localhost")
                    .Port(5432)
                    .Database("car_service")
                    .Username("new_user")
                    .Password("0000")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SessionFactory>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }*/
    }
}
