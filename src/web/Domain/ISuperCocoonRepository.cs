/*
 * User: ben
 * Date: 26/08/2012
 * Time: 15:54
 * 
 */
using System;

namespace OpenOptimal.web.Domain
{
	/// <summary>
	/// Description of ISuperCocoonRepository.
	/// </summary>
	public interface ISuperCocoonRepository
	{
		void Save(SuperCocoon superCocoon);
		
		SuperCocoon GetByCrimeReference(string crimeReference);
	}
}
