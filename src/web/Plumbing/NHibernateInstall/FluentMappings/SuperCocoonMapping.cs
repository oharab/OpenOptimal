/*
 * User: ben
 * Date: 26/08/2012
 * Time: 17:17
 * 
 */
using System;
using FluentNHibernate.Mapping;
using OpenOptimal.web.Domain;

namespace OpenOptimal.web.Plumbing.NHibernateInstall.FluentMappings
{
	/// <summary>
	/// Description of SuperCocoonMapping.
	/// </summary>
	public class SuperCocoonMapping:ClassMap<SuperCocoon>
	{
		public SuperCocoonMapping()
		{
			Table("SuperCocoons");
			Id(x=>x.CrimeReference)
				.GeneratedBy.Assigned();
			Map(x=>x.TargettedProperty);
			HasMany(x=>x.CocoonProperties)
				.Cascade.AllDeleteOrphan();
		}
	}
}
