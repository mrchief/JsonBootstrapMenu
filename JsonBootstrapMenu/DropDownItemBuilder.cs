using System;
using System.Text;

namespace MvcJsonBootstrapMenu
{
	public static class DropDownItemBuilder
	{
		public static String MenuItem(MenuItem item)
		{
			var builder = new StringBuilder();
			builder.Append(@"<li class=""dropdown"">");
			builder.AppendFormat(@"<a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""><span>{0}</span> <b class=""caret""></b></a>", item.Text);
			builder.Append(@"<ul class=""dropdown-menu"">");

			foreach (var submenu in item.Submenus)
			{
				builder.Append(GenerateSubMenuItem(submenu));
			}

			builder.Append("</ul></li>");

			return builder.ToString();
		}

		private static string GenerateSubMenuItem(MenuItem item)
		{
			return item.IsDivider ? ListItemBuilder.DividerItem() : ListItemBuilder.MenuItem(item);
		}
	}
}