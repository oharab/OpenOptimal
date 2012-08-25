/*
 * User: ben
 * Date: 25/08/2012
 * Time: 17:22
 * 
 */
using System;
using OpenRasta.IO;

namespace OpenOptimal.web.Resources
{
	/// <summary>
	/// Description of NewCocoonResource.
	/// </summary>
	public class NewCocoonResource:INewCocoonResource
	{
		public NewCocoonResource()
		{
		}
		
		public string CrimeReference {
			get;
			set ;
		}
		
		public string Address {
			get ;
			set ;
		}
		
		public IFile AddressList {
			get;
			set ;
		}
	}
}
