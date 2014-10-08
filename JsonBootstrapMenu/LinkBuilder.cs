using System;
using System.Web;

namespace MvcJsonBootstrapMenu
{
	public static class LinkBuilder
	{
		private const string Template = @"<a href=""{0}"" target=""{1}"">{2}</a>";
		
		public static String LinkItem(string linkText, string url, string target)
		{
			var contentPath = url;

			// transform it so that virtual dirs and rooted sites work consitently
			if (contentPath[0] == '/')
				contentPath = contentPath.Insert(0, "~");

			var isAppRelative = contentPath[0] == '~';
			

			var absoluteContentPath = isAppRelative && HttpContext.Current != null
				? VirtualPathUtility.ToAbsolute(contentPath, HttpContext.Current.Request.ApplicationPath)
				: contentPath;

			return string.Format(Template, absoluteContentPath, target ?? "_self", linkText);
		}

		public static String LinkItem(MenuItem item)
		{
			return LinkItem(item.Text, item.Url, item.Target);
		}
	}
}