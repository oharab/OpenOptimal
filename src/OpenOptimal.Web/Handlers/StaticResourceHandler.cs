
using System;
using System.Collections.Generic;
using System.IO;

using OpenFileSystem.IO;
using OpenFileSystem.IO.FileSystems.Local;
using OpenRasta.Diagnostics;
using OpenRasta.Web;

namespace OpenOptimal.Web.Handlers
{
	/// <summary>
	/// Description of StaticResourceHandler.
	/// </summary>
	public class StaticResourceHandler
	{
		private readonly ICommunicationContext context;
		private Dictionary<string, IFile> cache;
		private IFileSystem filesystem;
		private IDirectory hostDir;
		private ILogger logger;
		
		public StaticResourceHandler(ICommunicationContext context,ILogger logger)
		{
			this.context = context;
			this.cache = new Dictionary<string, IFile>();
			this.logger=logger;	
			this.filesystem=LocalFileSystem.Instance;
			this.hostDir=this.filesystem.GetCurrentDirectory();
			this.logger.WriteDebug("host Dir is '{0}'.",hostDir.ToString());
		}
		
		public IFile Get(string path)
		{
			
			if (!this.cache.ContainsKey(path))
			{
				this.cache[path] = this.hostDir.GetFile(path);
			}
			return this.cache[path];
		}
	}
}
