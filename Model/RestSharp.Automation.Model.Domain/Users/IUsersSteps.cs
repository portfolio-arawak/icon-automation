using System.Threading.Tasks;

namespace RestSharp.Automation.Model.Domain.Users;

public interface IUsersSteps
{
	Task<object> GetUsersResponseAsync();
}