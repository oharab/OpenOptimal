/*
 * User: ben
 * Date: 26/08/2012
 * Time: 15:56
 * 
 */
using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using OpenOptimal.web.Domain;
using OpenOptimal.web.Domain.Repositories;

namespace OpenOptimal.web.Plumbing.WindsorInstallers
{
	/// <summary>
	/// Description of RepositoryInstaller.
	/// </summary>
	public class RepositoryInstaller:IWindsorInstaller
	{
		public RepositoryInstaller()
		{
		}
		
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(Component.For<ISuperCocoonRepository>()
			                   .ImplementedBy<SuperCocoonRepository>()
			                   .LifeStyle.Transient
			                   
			                  );
				
		}
	}
}
