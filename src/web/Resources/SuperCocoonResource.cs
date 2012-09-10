/*
 * User: 721116
 * Date: 10/09/2012
 * Time: 11:02
 * 
 *  */
using System;
using System.Collections.Generic;
using OpenOptimal.web.Domain;

namespace OpenOptimal.web.Resources
{
	/// <summary>
	/// Description of SuperCocoonResource.
	/// </summary>
	public class SuperCocoonResource
	{
		public SuperCocoonResource()
		{
			this.Properties=new List<SuperCocoonPropertyResource>();
		}
		
		public string CrimeReference {
			get;
			set ;
		}
		
		public string Address {
			get ;
			set ;
		}
		
		public IList<SuperCocoonPropertyResource> Properties{get;set;}
	}
}
