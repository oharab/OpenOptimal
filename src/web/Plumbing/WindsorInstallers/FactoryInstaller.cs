/*
 * User: ben
 * Date: 25/08/2012
 * Time: 15:23
 * 
 */
using System;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using OpenOptimal.web.Resources;

namespace OpenOptimal.web.Plumbing.WindsorInstallers
{
	/// <summary>
	/// Description of FactoryInstaller.
	/// </summary>
	public class FactoryInstaller:IWindsorInstaller
	{
		public FactoryInstaller()
		{
		}
		
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.AddFacility<TypedFactoryFacility>();
		}
	}
}
