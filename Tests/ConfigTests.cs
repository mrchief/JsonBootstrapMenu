using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcJsonBootstrapMenu;

namespace Tests
{
	[TestClass]
	public class ConfigTests
	{
		[TestMethod]
		public void ShouldLoadConfigWithSubmenu()
		{
			const string menuConfig = @"[
								  {
									""text"": ""Help"",
									""submenus"": [
									  {
										""url"": ""/documentation/GeneralHelp.pdf"",
										""text"": ""General Help"",
										""target"": ""new""
									  },
									  {
										""url"": ""/documentation/DeployHelp.pdf"",
										""text"": ""Deploy Help"",
										""target"": ""new""
									  }
									]
								  }
								]";

			var menuItems = Menu.LoadFromJson(menuConfig).ToArray();

			Assert.IsNotNull(menuItems);
			Assert.AreEqual(1, menuItems.Count());
			Assert.AreEqual(2, menuItems.First().Submenus.Count);
		}
	}
}
