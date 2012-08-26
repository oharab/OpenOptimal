/*
 * User: ben
 * Date: 26/08/2012
 * Time: 17:08
 * 
 */
using System;
using FluentNHibernate.Mapping;
using OpenOptimal.web.Domain;

namespace OpenOptimal.web.Plumbing.NHibernateInstall.ClassMaps
{
	/// <summary>
	/// Description of PropertyClassMap.
	/// </summary>
	public class PropertyMap:ClassMap<Property>
	{
		public PropertyMap()
		{
			Table("Properties");
			Id(x=>x.Id)
				.GeneratedBy.GuidComb()
				.Access.BackingField();
			Map(x=>x.Company_Organisation)
				.Nullable();
			Map(x=>x.Address);
			Map(x=>x.Town);
			Map(x=>x.County);
			Map(x=>x.PostCode);
			Map(x=>x.Easting);
			Map(x=>x.Northing);
			
			References(x=>x.SuperCocoon);
			
		}
	}
}
