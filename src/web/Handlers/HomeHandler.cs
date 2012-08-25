﻿/*
 * User: ben
 * Date: 25/08/2012
 * Time: 13:05
 * 
 */
using System;
using OpenOptimal.web.Resources;

namespace OpenOptimal.web.Handlers
{
	/// <summary>
	/// Description of HomeHandler.
	/// </summary>
	public class HomeHandler:IHomeHandler
	{
		public HomeHandler()
		{
		}
		
		public HomeResource Get()
		{
			return new HomeResource{Title="Hello World"};
		}
	}
}
