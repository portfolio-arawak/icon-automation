using System.Threading.Tasks;
using RestSharp.Automation.Model.Domain.Users;
using TechTalk.SpecFlow;

namespace RestSharp.Automation.Tests.Features;

[Binding, Scope(Feature = "Users")]
public class UsersDefinition
{
	private readonly IUsersSteps _usersSteps;

	public UsersDefinition(
		IUsersSteps usersSteps)
	{
		_usersSteps = usersSteps;
	}

	[Given(@"I have access to the users api")]
	public async Task GivenIHaveAccessToTheUsersApiAsync()
	{
		// semantic sugar
	}

	[When(@"I receive response from '([^']*)'")]
	public async Task WhenIReceiveResponseFromAsync(string endpoint)
	{
		var response = await _usersSteps.GetUsersResponseAsync();
	}

}