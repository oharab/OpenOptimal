/*
 * User: ben
 * Date: 25/08/2012
 * Time: 17:13
 * 
 */
using System;
using OpenOptimal.web.Resources;

namespace OpenOptimal.web.Handlers
{
	/// <summary>
	/// Description of ICocoonHandler.
	/// </summary>
	public interface ICocoonHandler
	{
		INewCocoonResource Get();
	}
}
