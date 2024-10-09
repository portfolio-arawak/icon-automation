using System.Threading.Tasks;

using RestSharp.Automation.Model.Domain.Users;
using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.Platform.Extensions;

namespace RestSharp.Automation.Domain.Users;

public class UsersSteps : IUsersSteps
{
	private readonly IUsersApiClient _usersApiClient;

	public UsersSteps(
		IUsersApiClient usersApiClient)
	{
		_usersApiClient = usersApiClient;
	}

	public async Task<UsersResponseModel> GetUsersResponseAsync(
		string endpoint)
	{
		var response = await _usersApiClient.GetUsersResponseAsync(endpoint);
		return response.GetModel<UsersResponseModel>();
	}

	public async Task<ClientResponse> GetClientResponseAsync(
		string endpoint)
	{
		return await _usersApiClient.GetUsersResponseAsync(endpoint);
	}
}