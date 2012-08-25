/*
 * User: ben
 * Date: 25/08/2012
 * Time: 15:21
 * 
 */
using System;
using Castle.Windsor;
using Castle.Windsor.Installer;
using OpenRasta.DI;
using OpenRasta.DI.Windsor;

namespace OpenOptimal.web.Plumbing
{
	/// <summary>
	/// Changes OpenRasta to use Windsor instead if it's internal IoC container.
	/// </summary>
	public class WindsorDependencyResolverAccessor:IDependencyResolverAccessor
	{
		public WindsorDependencyResolverAccessor()
		{
		}
		
		public IDependencyResolver Resolver {
			get {
				return new WindsorDependencyResolver(ConfigureContainer());
			}
		}
		
		Castle.Windsor.IWindsorContainer ConfigureContainer()
		{
			return new WindsorContainer()
		        .Install(FromAssembly.This());
		}
	}
}
