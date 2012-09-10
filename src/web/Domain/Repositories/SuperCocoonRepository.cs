/*
 * User: ben
 * Date: 26/08/2012
 * Time: 15:58
 * 
 */
using System;
using NHibernate;
using OpenOptimal.web.Domain;

namespace OpenOptimal.web.Domain.Repositories
{
	/// <summary>
	/// Description of SuperCocoonRepository.
	/// </summary>
	public class SuperCocoonRepository:ISuperCocoonRepository
	{
		private readonly ISession session;
		
		public SuperCocoonRepository(ISession session)
		{
			this.session = session;
		}
		
		public void Save(SuperCocoon superCocoon)
		{
			using(ITransaction transaction=session.BeginTransaction()){
				session.Save(superCocoon);
				transaction.Commit();
			}
		}
		
		
		
		public SuperCocoon GetByCrimeReference(string crimeReference)
		{
			return session.Get<SuperCocoon>(crimeReference);
		}
	}
}
