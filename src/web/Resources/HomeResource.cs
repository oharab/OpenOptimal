/*
 * User: ben
 * Date: 25/08/2012
 * Time: 13:03
 * 
 */
using System;
using System.Collections.Generic;

namespace OpenOptimal.web.Resources
{
	/// <summary>
	/// Description of HomeResource.
	/// </summary>
	public class HomeResource
	{
		public string Title { get; set; }
		public IEnumerable<SuperCocoonResource> OutstandingSuperCocoons{get;set;}
		
	}
}
