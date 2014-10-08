using System;

namespace MvcJsonBootstrapMenu
{
	public static class ListItemBuilder
	{
		private const string Template = @"<li class=""{0}"">{1}</li>";
		public static String MenuItem(MenuItem item)
		{
			return string.Format(Template, item.CssClass, LinkBuilder.LinkItem(item));
		}

		public static string DividerItem()
		{
			return @"<li class=""divider""></li>";
		}
	}
}
