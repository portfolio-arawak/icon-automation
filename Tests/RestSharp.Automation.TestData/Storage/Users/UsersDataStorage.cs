using System.Collections.Generic;

using Bogus;

using RestSharp.Automation.Model.Domain.Users;

namespace RestSharp.Automation.TestData.Storage.Users;

public static class UsersDataStorage
{
	public static Dictionary<string, UsersResponseModel> UsersPreset =>
		new()
		{
			{ "Page1Preset", new UsersResponseModel { Data = new [] { GeorgeBluth, JanetWeaver, EmmaWong, EveHolt, CharlesMorris, TraceyRamos } } },
			{ "Page2Preset", new UsersResponseModel { Data = new [] { MichaelLawson, LindsayFerguson, TobiasFunke, ByronFields, GeorgeEdwards, RachelHowell } } }
		};

	public static Dictionary<string, User> Users =>
		new()
		{
			{ "ByronFields", ByronFields },
		};

	private static User GeorgeBluth =>
		new Faker<User>()
			.RuleFor(u => u.Id, 1)
			.RuleFor(u => u.Email, "george.bluth@reqres.in")
			.RuleFor(u => u.FirstName, "George")
			.RuleFor(u => u.LastName, "Bluth")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/1-image.jpg");

	private static User JanetWeaver =>
		new Faker<User>()
			.RuleFor(u => u.Id, 2)
			.RuleFor(u => u.Email, "janet.weaver@reqres.in")
			.RuleFor(u => u.FirstName, "Janet")
			.RuleFor(u => u.LastName, "Weaver")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/2-image.jpg");

	private static User EmmaWong =>
		new Faker<User>()
			.RuleFor(u => u.Id, 3)
			.RuleFor(u => u.Email, "emma.wong@reqres.in")
			.RuleFor(u => u.FirstName, "Emma")
			.RuleFor(u => u.LastName, "Wong")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/3-image.jpg");

	private static User EveHolt =>
		new Faker<User>()
			.RuleFor(u => u.Id, 4)
			.RuleFor(u => u.Email, "eve.holt@reqres.in")
			.RuleFor(u => u.FirstName, "Eve")
			.RuleFor(u => u.LastName, "Holt")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/4-image.jpg");

	private static User CharlesMorris =>
		new Faker<User>()
			.RuleFor(u => u.Id, 5)
			.RuleFor(u => u.Email, "charles.morris@reqres.in")
			.RuleFor(u => u.FirstName, "Charles")
			.RuleFor(u => u.LastName, "Morris")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/5-image.jpg");

	private static User TraceyRamos =>
		new Faker<User>()
			.RuleFor(u => u.Id, 6)
			.RuleFor(u => u.Email, "tracey.ramos@reqres.in")
			.RuleFor(u => u.FirstName, "Tracey")
			.RuleFor(u => u.LastName, "Ramos")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/6-image.jpg");

	private static User MichaelLawson =>
		new Faker<User>()
			.RuleFor(u => u.Id, 7)
			.RuleFor(u => u.Email, "michael.lawson@reqres.in")
			.RuleFor(u => u.FirstName, "Michael")
			.RuleFor(u => u.LastName, "Lawson")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/7-image.jpg");

	private static User LindsayFerguson =>
		new Faker<User>()
			.RuleFor(u => u.Id, 8)
			.RuleFor(u => u.Email, "lindsay.ferguson@reqres.in")
			.RuleFor(u => u.FirstName, "Lindsay")
			.RuleFor(u => u.LastName, "Ferguson")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/8-image.jpg");

	private static User TobiasFunke =>
		new Faker<User>()
			.RuleFor(u => u.Id, 9)
			.RuleFor(u => u.Email, "tobias.funke@reqres.in")
			.RuleFor(u => u.FirstName, "Tobias")
			.RuleFor(u => u.LastName, "Funke")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/9-image.jpg");

	private static User ByronFields =>
		new Faker<User>()
			.RuleFor(u => u.Id, 10)
			.RuleFor(u => u.Email, "byron.fields@reqres.in")
			.RuleFor(u => u.FirstName, "Byron")
			.RuleFor(u => u.LastName, "Fields")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/10-image.jpg");

	private static User GeorgeEdwards =>
		new Faker<User>()
			.RuleFor(u => u.Id, 11)
			.RuleFor(u => u.Email, "george.edwards@reqres.in")
			.RuleFor(u => u.FirstName, "George")
			.RuleFor(u => u.LastName, "Edwards")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/11-image.jpg");

	private static User RachelHowell =>
		new Faker<User>()
			.RuleFor(u => u.Id, 12)
			.RuleFor(u => u.Email, "rachel.howell@reqres.in")
			.RuleFor(u => u.FirstName, "Rachel")
			.RuleFor(u => u.LastName, "Howell")
			.RuleFor(u => u.Avatar, "https://reqres.in/img/faces/12-image.jpg");
}