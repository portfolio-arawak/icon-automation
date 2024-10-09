using System.Threading.Tasks;

using RestSharp.Automation.Model.Platform.Client;

namespace RestSharp.Automation.Model.Domain.Users;

public interface IUsersApiClient
{
	Task<ClientResponse> GetUsersResponseAsync(string endpoint);
}