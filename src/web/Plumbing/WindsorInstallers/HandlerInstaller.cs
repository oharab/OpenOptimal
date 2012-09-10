/*
 * User: ben
 * Date: 25/08/2012
 * Time: 15:45
 * 
 */
using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace OpenOptimal.web.Plumbing.WindsorInstallers
{
	/// <summary>
	/// Description of HandlerInstaller.
	/// </summary>
	public class HandlerInstaller:IWindsorInstaller
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{

			container.Register(AllTypes.FromThisAssembly()
			                   .Where(t=>t.Namespace.EndsWith("Handlers"))
			                   .LifestyleTransient()
			                   .WithService.FirstInterface()
			                  );
		}		
	}
}
