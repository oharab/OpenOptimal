using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;

using OpenFileSystem.IO;
using OpenOptimal.Web.Handlers;
using OpenOptimal.Web.Resources;
using OpenRasta.Codecs;
using OpenRasta.Codecs.WebForms;
using OpenRasta.Configuration;
using OpenRasta.Web;

namespace OpenOptimal.Web
{
	public class Configuration : IConfigurationSource
	{
		public void Configure()
		{
			ResourceSpace.Has.Resource<Home>()
				.Uri("/cocoons")
				.And.Uri("/")
				.Handler<HomeHandler>()
				.RenderedByAspx("~/Views/HomeView.aspx");
			
			ResourceSpace.Has.Resource<IFile>()
				.Uri("/css/OpenOptimal.css")
				.Handler<StaticResourceHandler>()
				.TranscodedBy<ApplicationOctetStreamCodec>()
				.ForMediaType("text/css")
				.Extension(".css")
				;
			
		}
	}
}