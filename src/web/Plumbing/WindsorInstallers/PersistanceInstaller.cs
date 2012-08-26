/*
 * User: ben
 * Date: 26/08/2012
 * Time: 16:42
 * 
 */
using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using OpenOptimal.web.Plumbing.NHibernateInstall;

namespace OpenOptimal.web.Plumbing.WindsorInstallers
{
	/// <summary>
	/// Description of PersistanceInstaller.
	/// </summary>
	public class PersistanceInstaller:IWindsorInstaller
	{

		
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.AddFacility<NHibernateFacility>();
		}
	}
}
