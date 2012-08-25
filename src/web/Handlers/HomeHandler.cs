/*
 * User: ben
 * Date: 25/08/2012
 * Time: 13:05
 * 
 */
using System;
using OpenOptimal.web.Resources;

namespace OpenOptimal.web.Handlers
{
	/// <summary>
	/// Description of HomeHandler.
	/// </summary>
	public class HomeHandler:IHomeHandler
	{
		IResourceFactory resourceFactory;
		public HomeHandler(IResourceFactory resourceFactory)
		{
			this.resourceFactory=resourceFactory;
		}
		
		public IHomeResource Get()
		{
			return resourceFactory.GetHomeResource("Hello World");
		}
	}
}
