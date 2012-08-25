/*
 * User: ben
 * Date: 25/08/2012
 * Time: 12:49
 * 
 */

using System;
using OpenOptimal.web.Handlers;
using OpenOptimal.web.Resources;
using OpenRasta.Codecs.WebForms;
using OpenRasta.Configuration;

namespace OpenOptimal.web.Plumbing
{
	/// <summary>
	/// Configuring OpenRasta
	/// </summary>
	public class Configuration:IConfigurationSource
	{
		
		public void Configure()
		{
			using(OpenRastaConfiguration.Manual){
				ResourceSpace.Has.ResourcesOfType<HomeResource>()
					.AtUri("/home")
					.And.AtUri("/")
					.HandledBy<HomeHandler>()
					.RenderedByAspx("~/Views/HomeView.aspx");
				
			}
		}
	}
}
