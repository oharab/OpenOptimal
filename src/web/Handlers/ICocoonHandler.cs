/*
 * User: ben
 * Date: 25/08/2012
 * Time: 17:13
 * 
 */
using System;
using OpenOptimal.web.Resources;
using OpenRasta.Web;

namespace OpenOptimal.web.Handlers
{
	/// <summary>
	/// Description of ICocoonHandler.
	/// </summary>
	public interface ICocoonHandler
	{
		NewCocoonResource Get();
		OperationResult Post(NewCocoonResource newCocoonResource);
		OperationResult Get(string CrimeReference);
		OperationResult Get(string CrimeReference,Guid Id);
	}
}
