using System.Collections.Generic;
using Newtonsoft.Json;

namespace MvcJsonBootstrapMenu
{
	public class Menu
	{
		public static IEnumerable<MenuItem> LoadFromJson(string json)
		{
			return JsonConvert.DeserializeObject<IEnumerable<MenuItem>>(json);
		}
	}
}