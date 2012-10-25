﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using OpenOptimal.Web.Handlers;
using OpenOptimal.Web.Resources;
using OpenRasta.Configuration;
using OpenRasta.Web;
using OpenRasta.Codecs;
using OpenRasta.Codecs.WebForms;

namespace OpenOptimal.Web
{
	public class Configuration : IConfigurationSource
	{
		public void Configure()
		{
			ResourceSpace.Has.Resource<Home>()
				.Uri("/optimal/home")
				.And.Uri("/optimal")
				.Handler<HomeHandler>()
				.RenderedByAspx("~/Views/HomeView.aspx");
		}
	}
}