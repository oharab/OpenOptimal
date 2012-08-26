/*
 * User: ben
 * Date: 26/08/2012
 * Time: 15:01
 * 
 */
using System;
using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace OpenOptimal.web.Plumbing.WindsorInstallers
{
	/// <summary>
	/// Description of LoggingInstaller.
	/// </summary>
	public class LoggingInstaller:IWindsorInstaller
	{
		public LoggingInstaller()
		{
		}
		
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.AddFacility<LoggingFacility>(f=>f.LogUsing(LoggerImplementation.Log4net));
		}
	}
}
