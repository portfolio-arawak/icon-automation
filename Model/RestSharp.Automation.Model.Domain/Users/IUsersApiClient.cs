using System.Threading.Tasks;

namespace RestSharp.Automation.Model.Domain.Users;

public interface IUsersApiClient
{
	Task<object> GetUsersResponseAsync();
}