/*
 * User: ben
 * Date: 25/08/2012
 * Time: 15:31
 * 
 */
using System;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using OpenOptimal.web.Plumbing;

namespace OpenOptimal.web.Plumbing.WindsorInstallers
{
	/// <summary>
	/// Description of ResourceInstaller.
	/// </summary>
	public class ResourcesInstaller:IWindsorInstaller
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{

			container.Register(AllTypes.FromThisAssembly()
			                   .Where(t=>t.Namespace.EndsWith("Resources"))
			                   .Configure(c=>c.LifeStyle.Transient)
			                   .WithService.FirstInterface()
			                  );
		}
	}
}
