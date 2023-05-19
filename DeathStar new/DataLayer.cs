using System;
using System.Collections.Generic;
using System.Linq;
using Oracle.ManagedDataAccess.Client;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Windows.Forms;

namespace DeathStar_new
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();


        //funkcija na zahtev otvara sesiju
        public static ISession GetSession()
        {
            //ukoliko session factory nije kreiran
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        //konfiguracija i kreiranje session factory
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                .ShowSql()
                .ConnectionString(c =>
                    c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S19040;Password=SQLSord321"));

                return Fluently.Configure()
                    .Database(cfg.ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DeathStar_new.Mapiranja.KvadrantMapiranja>())
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(ec.Message);
                Exception er = ec.InnerException;
                int a = 4;
                while (er != null)
                {
                    sb.AppendLine($"{new string(' ', a)}-> {er.Message}");
                    er = er.InnerException;
                    a += 4;
                }
                MessageBox.Show(sb.ToString());
                return null;
            }

        }
    }
}
