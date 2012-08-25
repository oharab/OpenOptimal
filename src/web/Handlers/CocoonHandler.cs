/*
 * User: ben
 * Date: 25/08/2012
 * Time: 17:18
 * 
 */
using System;
using OpenOptimal.web.Resources;
using OpenRasta.Web;

namespace OpenOptimal.web.Handlers
{
	/// <summary>
	/// Description of CocoonHandler.
	/// </summary>
	public class CocoonHandler:ICocoonHandler
	{

		public NewCocoonResource Get()
		{
			return new NewCocoonResource();
		}
		
		public OperationResult Post(NewCocoonResource newCocoonResource){
			
			return new OperationResult.SeeOther{
				RedirectLocation=typeof(HomeResource).CreateUri()
			};
		}
	}
}
