using System.Threading.Tasks;
using RestSharp.Automation.Model.Domain.Users;

namespace RestSharp.Automation.Domain.Users;

public class UsersSteps : IUsersSteps
{
	private readonly IUsersApiClient _usersApiClient;

	public UsersSteps(
		IUsersApiClient usersApiClient)
	{
		_usersApiClient = usersApiClient;
	}

	public async Task<object> GetUsersResponseAsync()
	{
		return await _usersApiClient.GetUsersResponseAsync();
	}
}