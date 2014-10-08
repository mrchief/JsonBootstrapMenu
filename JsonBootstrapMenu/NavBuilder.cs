using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcJsonBootstrapMenu
{
	public static class NavBuilder
	{
		public static String Nav(IEnumerable<MenuItem> items)
		{
			var builder = new StringBuilder();
			builder.Append(@"<ul class=""nav navbar-nav"">");

			foreach (var menuItem in items.Where(menuItem => !menuItem.IsDivider))
			{
				builder.Append(menuItem.Submenus.Any() ? DropDownItemBuilder.MenuItem(menuItem) : ListItemBuilder.MenuItem(menuItem));
			}

			builder.Append("</ul>");

			return builder.ToString();
		}
	}
}