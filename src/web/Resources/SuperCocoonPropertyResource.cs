/*
 * User: 721116
 * Date: 10/09/2012
 * Time: 11:17
 * 
 *  */
using System;
using OpenRasta.Web;

namespace OpenOptimal.web.Resources
{
	/// <summary>
	/// Description of SuperCocoonPropertyResouce.
	/// </summary>
	public class SuperCocoonPropertyResource
	{
		public SuperCocoonPropertyResource()
		{
		}
		
		public Guid	Id { get; set;}
		public string Company_Organisation { get; set; }
		public string Address { get; set; }
		public string Town { get; set; }
		public string County { get; set; }
		public string PostCode { get; set; }
		public double Easting { get; set; }
		public double Northing { get; set; }
		
		
	}
}
