/*
 * User: ben
 * Date: 25/08/2012
 * Time: 15:25
 * 
 */
using System;

namespace OpenOptimal.web.Resources
{
	/// <summary>
	/// Factory that builds OpenRasta resources using the Windsor Container
	/// (Does not need an implementation)
	/// </summary>
	public interface IResourceFactory:IDisposable
	{
		IHomeResource GetHomeResource(string Title);
	}
}
