
using System;
using System.Collections.Generic;
using System.IO;

using OpenRasta.Web;

namespace OpenOptimal.Web.Handlers
{
	/// <summary>
	/// Description of StaticResourceHandler.
	/// </summary>
	public class StaticResourceHandler
	{
		private readonly ICommunicationContext context;
		private Dictionary<string, Stream> cache;
		
		public StaticResourceHandler(ICommunicationContext context)
		{
			this.context = context;
			this.cache = new Dictionary<string, Stream>();
		}
		
		public Stream Get(string path)
		{
			if (!this.cache.ContainsKey(path))
			{
				this.cache[path] = new FileStream(path,FileMode.Open);
			}
			return this.cache[path];
		}
	}
}
