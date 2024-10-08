using System.Threading.Tasks;
using Automation.Common.Environment;
using RestSharp.Automation.Model.Domain.Users;
using RestSharp.Automation.Model.Platform.Communication;
using RestSharp.Automation.Platform.Client;
using Serilog;

namespace RestSharp.Automation.Domain.Users;

public class UsersApiClient : ApiClientBase, IUsersApiClient
{
	public UsersApiClient(
		IClient client, 
		ILogger logger,
		IEnvironmentConfiguration environmentConfiguration) : base(client, logger)
	{
		string baseUri = environmentConfiguration.EnvironmentUri;
		client.SetBaseUri(baseUri);
	}

	public async Task<object> GetUsersResponseAsync()
	{
		string endpoint = "/api/users?page=1";
		var response = await ExecuteGetAsync(endpoint);

		return null;
	}
}