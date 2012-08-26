/*
 * User: ben
 * Date: 26/08/2012
 * Time: 15:49
 * 
 */
using System;

namespace OpenOptimal.web.Domain
{
	/// <summary>
	/// Description of Property.
	/// </summary>
	public class Property
	{
		public virtual string Company_Organisation { get; set; }
		public virtual string Address { get; set; }
		public virtual string Town { get; set; }
		public virtual string County { get; set; }
		public virtual string PostCode { get; set; }
		public virtual double Easting { get; set; }
		public virtual double Northing { get; set; }
	}
}
