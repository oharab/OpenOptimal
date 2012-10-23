/*
 * User: 721116
 * Date: 10/09/2012
 * Time: 11:02
 * 
 *  */
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

using OpenOptimal.web.Domain;
using OpenRasta.Web;

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
		
		public string TargettedProperty {
			get ;
			set ;
		}
		
		public IList<SuperCocoonPropertyResource> Properties{get;set;}
		
		
	}
}
