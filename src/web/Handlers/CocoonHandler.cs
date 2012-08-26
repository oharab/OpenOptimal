/*
 * User: ben
 * Date: 25/08/2012
 * Time: 17:18
 * 
 */
using System;
using System.IO;
using Castle.Core.Logging;
using LumenWorks.Framework.IO.Csv;
using OpenOptimal.web.Domain;
using OpenOptimal.web.Resources;
using OpenRasta.Web;

namespace OpenOptimal.web.Handlers
{
	/// <summary>
	/// Description of CocoonHandler.
	/// </summary>
	public class CocoonHandler:ICocoonHandler
	{
		private readonly ILogger log;
		private readonly ISuperCocoonRepository repository;
		
		public CocoonHandler(ILogger log, ISuperCocoonRepository repository)
		{
			this.log = log;
			this.repository=repository;
		}

		public NewCocoonResource Get()
		{
			return new NewCocoonResource();
		}
		
		public OperationResult Post(NewCocoonResource newCocoonResource){
			log.Debug("New Cocoon Resource posted.");
			try{
				using(CsvReader csv=new CsvReader(new StreamReader(newCocoonResource.AddressList.OpenStream()),true))
				{
					log.DebugFormat("File has {0} columns.",csv.FieldCount);
					int fieldCount = csv.FieldCount;
					string[] headers = csv.GetFieldHeaders();
					while (csv.ReadNextRecord())
					{
						for (int i = 0; i < fieldCount; i++)
							log.DebugFormat("{0} = {1};",headers[i], csv[i]);
						log.Debug("");
					}
				}
				
				return new OperationResult.SeeOther{
					RedirectLocation=typeof(HomeResource).CreateUri()
				};
			}catch(MalformedCsvException)
			{
				return new OperationResult.BadRequest();
				
			}
		}
	}
}
