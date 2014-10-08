using System.Collections.Generic;

namespace MvcJsonBootstrapMenu
{
	public class MenuItem
	{
		public string Url { get; set; }
		public string Text { get; set; }
		public string CssClass { get; set; }
		public string Target { get; set; }
		public IList<MenuItem> Submenus { get; set; }

		public bool IsDivider { get; set; }

		public MenuItem()
		{
			Submenus = new MenuItem[0];
		}
	}
}
