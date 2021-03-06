﻿/*
 * User: ben
 * Date: 26/08/2012
 * Time: 16:11
 * 
 */
using System;
using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.Registration;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using OpenOptimal.web.Domain;

namespace OpenOptimal.web.Plumbing.NHibernateInstall
{
	/// <summary>
	/// Description of NHibernateFacility.
	/// </summary>
	public class NHibernateFacility:AbstractFacility
	{
		protected override void Init()
		{
			Configuration config = BuildDatabaseConfiguration();

			Kernel.Register(
				Component.For<ISessionFactory>()
				.UsingFactoryMethod(_ => config.BuildSessionFactory())
				,
				Component.For<ISession>()
				.UsingFactoryMethod(k => k.Resolve<ISessionFactory>().OpenSession())
				.LifeStyle.PerWebRequest
			);
		}
		
		protected virtual IPersistenceConfigurer SetupDatabase()
		{
			return MsSqlConfiguration.MsSql2008
				.UseOuterJoin()
				.ConnectionString(x => x.FromConnectionStringWithKey("OpenOptimal"))
				.ShowSql();
		}
		
		private Configuration BuildDatabaseConfiguration()
		{
			return Fluently.Configure()
				.Database(SetupDatabase)
				.Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateFacility>())
				.ExposeConfiguration(c=>{
				                     	BuildSchema( c );
				                     	c.Properties[ NHibernate.Cfg.Environment.CurrentSessionContextClass ] = "web";
				                     })
				.BuildConfiguration();
		}
		
		// Drops and creates the database schema
        // private static void BuildSchema( Configuration cfg )
        // {
        //     new SchemaExport( cfg )
        //         .Create( true, true );
        // }

        // Updates the database schema if there are any changes to the model
        private static void BuildSchema( Configuration cfg )
        {
            new SchemaUpdate( cfg );
        }
		

	}
}
