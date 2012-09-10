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
			var superCocoon=new SuperCocoon();
			superCocoon.CrimeReference=newCocoonResource.CrimeReference;
			superCocoon.TargettedProperty=newCocoonResource.Address;
			
			try{
				using(CsvReader csv=new CsvReader(new StreamReader(newCocoonResource.AddressList.OpenStream()),true))
				{
					log.DebugFormat("File has {0} columns.",csv.FieldCount);
					int fieldCount = csv.FieldCount;
					string[] headers = csv.GetFieldHeaders();
					while (csv.ReadNextRecord())
					{
						superCocoon.CocoonProperties.Add(new Property{
						                                 	Company_Organisation=csv["Company/Organisation"],
						                                 	Address=csv["Address"],
						                                 	Town=csv["Town"],
						                                 	County=csv["County"],
						                                 	PostCode=csv["PostCode"],
						                                 	Easting=double.Parse(csv["Easting"]),
						                                 	Northing=double.Parse(csv["Northing"])
						                                 });
					}
					
					repository.Save(superCocoon);
					
					return new OperationResult.SeeOther{
						RedirectLocation=typeof(HomeResource).CreateUri()
					};
				}
			}
			catch(Exception ex)
			{
				log.Error("Error creating new SuperCocoon.",ex);
				return new OperationResult.BadRequest();
				
			}
		}
		
		
		
		
		public OperationResult Get(string CrimeReference)
		{
			var superCocoon=repository.GetByCrimeReference(CrimeReference);
			if(superCocoon==null)
				return new OperationResult.NotFound();
			var result= new SuperCocoonResource{
				CrimeReference=superCocoon.CrimeReference,
				Address=superCocoon.TargettedProperty
			};
			foreach (var property in superCocoon.CocoonProperties) {
				result.Properties.Add(new SuperCocoonPropertyResource{
				                      Id=property.Id,
				                      Address=property.Address,
				                      Company_Organisation=property.Company_Organisation,
				                      Town=property.Town,
				                      County=property.County,
				                      PostCode=property.PostCode,
				                      });
			}
			return new OperationResult.OK{ResponseResource=result};
		}
	}
}
