using System.Collections.Generic;

using Bogus;

using Selenium.Automation.Model.Domain.Login;

namespace Selenium.Automation.TestsData.Storage
{
	public static class UsersStorage
	{
		public static Dictionary<string, UserInformation> Users =>
			new Dictionary<string, UserInformation>
			{
				{ "ExistingUser", ExistingUser }
			};

		private static UserInformation ExistingUser =>
			new Faker<UserInformation>()
				.RuleFor(u => u.Email, "dummy@rambler.ru")
				.RuleFor(u => u.Password, "dummy");
	}
}
