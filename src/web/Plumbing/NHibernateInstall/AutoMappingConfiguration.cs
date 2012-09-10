/*
 * User: 721116
 * Date: 10/09/2012
 * Time: 17:40
 * 
 *  */
using System;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using OpenOptimal.web.Domain;

namespace OpenOptimal.web.Plumbing.NHibernateInstall
{
	/// <summary>
	/// Description of AutoMappingConfiguration.
	/// </summary>
	public class AutoMappingConfiguration:DefaultAutomappingConfiguration
	{
		public override bool ShouldMap(Type type)
		{
			return type.Namespace=="OpenOptimal.web.Domain";
		}
		
		public override bool IsId(Member member)
		{
			return base.IsId(member) || member.Name=="CrimeReference" ;
		}
		
		
	}
}
