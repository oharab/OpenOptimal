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
		private readonly IResourceFactory resourceFactory;
		public CocoonHandler(IResourceFactory resourceFactory)
		{
			this.resourceFactory = resourceFactory;
		}
		
		public INewCocoonResource Get()
		{
			return resourceFactory.GetNewCocoonResource();
		}
		
		public OperationResult Post(INewCocoonResource newCocoonResource){
			
			return new OperationResult.SeeOther{
					ResponseResource="~/"
			};
		}
	}
}
