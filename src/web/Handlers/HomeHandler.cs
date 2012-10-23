/*
 * User: ben
 * Date: 25/08/2012
 * Time: 13:05
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using Castle.Core.Logging;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using OpenOptimal.web.Domain;
using OpenOptimal.web.Resources;

namespace OpenOptimal.web.Handlers
{
	/// <summary>
	/// Description of HomeHandler.
	/// </summary>
	public class HomeHandler:IHomeHandler
	{
		private readonly ILogger log;
		private readonly ISession session;
		public HomeHandler(ILogger log,ISession session)
		{
			this.log = log;
			this.session=session;
		}
		
		public HomeResource Get()
		{
			IEnumerable<SuperCocoonResource> outstanding= session.QueryOver<SuperCocoon>()
				.Select(s=>s.CrimeReference,
				        s=>s.TargettedProperty)
				.List<object[]>()
				.Select(o=>new SuperCocoonResource{CrimeReference=o[0].ToString(),
				        	TargettedProperty=o[1].ToString()}
				        	);
			log.DebugFormat("{0} outstanding cocoons.",outstanding.ToList().Count);
			log.DebugFormat("First crime ref: {0}",outstanding.ToList()[0].CrimeReference);
			return new HomeResource{Title="Hello World.",OutstandingSuperCocoons=outstanding};
		}
	}
}
