using System.Threading.Tasks;

using RestSharp.Automation.Model.Domain.Users;
using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.Model.Platform.Communication;
using RestSharp.Automation.Platform.Client;

using Serilog;

namespace RestSharp.Automation.Domain.Users;

public class UsersApiClient : ApiClientBase, IUsersApiClient
{
	private readonly IClient _client;

	public UsersApiClient(
		IClient client,
		ILogger logger) : base(client, logger)
	{
		_client = client;
	}

	public async Task<ClientResponse> GetUsersResponseAsync(
		string endpoint)
	{
		var request = new ClientRequest(endpoint, Method.Get);
		return await _client.ExecuteAsync(request);
	}
}