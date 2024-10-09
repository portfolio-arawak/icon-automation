using System.Threading.Tasks;
using RestSharp.Automation.Model.Platform.Client;

namespace RestSharp.Automation.Model.Domain.Users;

public interface IUsersSteps
{
	Task<UsersResponseModel> GetUsersResponseAsync(string endpoint);
	Task<ClientResponse> GetClientResponseAsync(string endpoint);
}