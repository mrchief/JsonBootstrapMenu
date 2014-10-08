using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcJsonBootstrapMenu;

namespace Tests
{
	[TestClass]
	public class MenuTests
	{
		[TestMethod]
		public void ShouldBuildMenu()
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

			const string expected = @"<ul class=""nav navbar-nav""><li class=""dropdown""><a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""><span>Help</span> <b class=""caret""></b></a><ul class=""dropdown-menu""><li class=""""><a href=""~/documentation/GeneralHelp.pdf"" target=""new"">General Help</a></li><li class=""""><a href=""~/documentation/DeployHelp.pdf"" target=""new"">Deploy Help</a></li></ul></li></ul>";

			var menuItems = Menu.LoadFromJson(menuConfig).ToArray();
			var menu = NavBuilder.Nav(menuItems);
			Assert.AreEqual(expected, menu);
		}

		[TestMethod]
		public void ShouldBuildMenuWithDivider()
		{
			const string menuConfig = @"[
											{
											""text"": ""Dashboard"",
											""url"": ""/dashboard""
											},
											{
											""isDivider"": true
											},
											{
											""text"": ""Help"",
											""submenus"": [
												{
												""url"": ""/documentation/GenHelp.pdf"",
												""text"": ""General"",
												""target"": ""new""
												},
												{
												""isDivider"": true
												},
												{
												""url"": ""/documentation/DeployHelp.pdf"",
												""text"": ""Deploy Help"",
												""target"": ""new""
												}
											]
											}
										]";

			const string expected = @"<ul class=""nav navbar-nav""><li class=""""><a href=""~/dashboard"" target=""_self"">Dashboard</a></li><li class=""dropdown""><a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""><span>Help</span> <b class=""caret""></b></a><ul class=""dropdown-menu""><li class=""""><a href=""~/documentation/GenHelp.pdf"" target=""new"">General</a></li><li class=""divider""></li><li class=""""><a href=""~/documentation/DeployHelp.pdf"" target=""new"">Deploy Help</a></li></ul></li></ul>";

			var menuItems = Menu.LoadFromJson(menuConfig).ToArray();
			var menu = NavBuilder.Nav(menuItems);
			Assert.AreEqual(expected, menu);
		}
	}
}
