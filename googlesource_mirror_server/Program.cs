using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WalkingTec.Mvvm.Core;

namespace googlesource_mirror_server {
	public class Program {
		public static void Main (string [] args) {
			Host.CreateDefaultBuilder (args).ConfigureLogging ((hostingContext, logging) => {
				 logging.ClearProviders ();
				 logging.AddConsole ();
				 logging.AddWTMLogger ();
			}).ConfigureWebHostDefaults (webBuilder => {
				webBuilder.UseStartup<Startup> ();
			}).Build ().Run ();
		}
	}
}
