﻿
namespace Synthesis.Configuration
{
	internal static class ConfigurationUtility
	{
		/// <summary>
		/// Applies the available formats for a Synthesis configuration path (i.e. root-relative, absolute) to a given path
		/// </summary>
		public static string ResolveConfigurationPath(string configPath)
		{
			if (configPath.StartsWith("~"))
			{
				return System.Web.Hosting.HostingEnvironment.MapPath("~/") + configPath.Substring(1);
				// +1 to Stack Overflow:
				// http://stackoverflow.com/questions/4742257/how-to-use-server-mappath-when-httpcontext-current-is-nothing
			}

			return configPath;
		}
	}
}
