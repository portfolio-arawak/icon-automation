using System.Threading.Tasks;

using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.Model.Platform.Communication;

using Serilog;

namespace RestSharp.Automation.Platform.Communication
{
	public class Client : IClient
	{
		private readonly IRestClient _restClient;
		private readonly ILogger _logger;

		public Client(
			IRestClient restClient,
			ILogger logger)
		{
			_restClient = restClient;
			_logger = logger;
		}

		public async Task<ClientResponse> ExecuteAsync(ClientRequest request)
		{
			//if (string.IsNullOrEmpty(_restClient.BaseUrl?.ToString()))
			//{
			//	_logger.Warning("Base uri was not set.");
			//}

			var response = await _restClient.ExecuteAsync<RestResponse>(request);
			var clientResponse = new ClientResponse
			{
				Content = response.Content,
				ContentType = response.ContentType,
				StatusCode = response.StatusCode,
				ResponseUri = response.ResponseUri.AbsoluteUri,
				Request = (ClientRequest)response.Request,
				RawBytes = response.RawBytes
			};
			return clientResponse;
		}

		public void SetBaseUri(string baseUri)
		{
			var rest = _restClient;
			//_restClient.AddDefaultUrlSegment = new Uri(baseUri);
		}
	}
}
