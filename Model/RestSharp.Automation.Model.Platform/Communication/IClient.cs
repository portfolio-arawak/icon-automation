using System.Threading.Tasks;

using RestSharp.Automation.Model.Platform.Client;

namespace RestSharp.Automation.Model.Platform.Communication
{
	public interface IClient
	{
		Task<ClientResponse> ExecuteAsync(ClientRequest request);
		void SetBaseUri(string baseUri);
	}
}
