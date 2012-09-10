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
	public class OpenRastaSetup:IConfigurationSource
	{
		
		public void Configure()
		{
			using(OpenRastaConfiguration.Manual){
				ResourceSpace.Has.ResourcesOfType<HomeResource>()
					.AtUri("/home")
					.And.AtUri("/")
					.HandledBy<IHomeHandler>()
					.RenderedByAspx("~/Views/HomeView.aspx");
				
				ResourceSpace.Has.ResourcesOfType<NewCocoonResource>()
					.AtUri("/cocoons/new")
					.HandledBy<ICocoonHandler>()
					.RenderedByAspx("~/Views/NewCocoonView.aspx");
				
				ResourceSpace.Has.ResourcesOfType<SuperCocoonResource>()
					.AtUri("/cocoons/{CrimeReference}")
					.HandledBy<ICocoonHandler>()
					.RenderedByAspx("~/Views/SuperCocoonView.aspx");
				ResourceSpace.Has.ResourcesOfType<SuperCocoonPropertyResource>()
					.AtUri("/cocoons/{CrimeReference}/{Id}")
					.HandledBy<ICocoonHandler>()
					.RenderedByAspx("~/Views/SuperCocoonPropertyView.aspx");
			}
		}
	}
}
