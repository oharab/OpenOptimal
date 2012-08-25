/*
 * User: ben
 * Date: 25/08/2012
 * Time: 17:14
 * 
 */
using System;
using OpenRasta.IO;

namespace OpenOptimal.web.Resources
{
	/// <summary>
	/// Description of INewCocoonResource.
	/// </summary>
	public interface INewCocoonResource
	{
		string CrimeReference { get; set; }
		string Address{get;set;}
		IFile AddressList{get;set;}
	}
}
