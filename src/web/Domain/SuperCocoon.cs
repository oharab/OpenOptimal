/*
 * User: ben
 * Date: 26/08/2012
 * Time: 15:41
 * 
 */
using System;
using System.Collections.Generic;

namespace OpenOptimal.web.Domain
{
	/// <summary>
	/// Description of SuperCocoon.
	/// </summary>
	public class SuperCocoon
	{
		private IList<Property> cocoonProperties;
		
		public SuperCocoon()
		{
			cocoonProperties=new List<Property>();
		}
		public virtual string CrimeReference { get; set; }
		public virtual string TargettedProperty { get; set; }
		public virtual IList<Property> CocoonProperties{
			get{
				return cocoonProperties;
			}
			
			set {
				cocoonProperties=value;
			}
		}
		
	}
}
