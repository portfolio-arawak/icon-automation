using System.Threading.Tasks;

using Newtonsoft.Json;

using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.Model.Platform.Communication;
using RestSharp.Automation.Platform.Extensions;

using Serilog;

namespace RestSharp.Automation.Platform.Client
{
	public abstract class ApiClientBase : IApiClient
	{
		protected readonly ILogger Logger;
		private readonly IClient _client;

		protected ApiClientBase(
			IClient client,
			ILogger logger)
		{
			_client = client;
			Logger = logger;
		}

		public async Task<T1> ExecutePostAsync<T1, T2>(string uri, T2 body, string accessToken = null)
			where T1 : class
			where T2 : class
		{
			var request = CreateRequest(uri, Method.Post, body, accessToken);
			var response = await _client.ExecuteAsync(request);
			return response.GetModel<T1>();
		}

		public async Task<ClientResponse> ExecutePostAsync<T1>(string uri, T1 body, string accessToken = null)
		   where T1 : class
		{
			var request = CreateRequest(uri, Method.Post, body, accessToken);
			var response = await _client.ExecuteAsync(request);
			return response;
		}

		public async Task<T1> ExecuteGetAsync<T1>(string uri, string accessToken = null)
			where T1 : class
		{
			var request = CreateRequest<ClientRequest>(uri, Method.Get, null, accessToken);
			var response = await _client.ExecuteAsync(request);
			return response.GetModel<T1>();
		}

		protected async Task<ClientResponse> ExecuteDeleteAsync(string uri, string accessToken = null)
		{
			var request = new ClientRequest(uri, Method.Delete)
				.AddAuthorizationHeader(accessToken);
			return await _client.ExecuteAsync(request);
		}

		protected async Task<ClientResponse> ExecuteGetAsync(string uri, string accessToken = null)
		{
			var request = new ClientRequest(uri, Method.Get)
				.AddAuthorizationHeader(accessToken);
			return await _client.ExecuteAsync(request);
		}

		protected async Task<ClientResponse> ExecutePutAsync<T>(string uri, T body, string accessToken)
		{
			var request = CreateRequest(uri, Method.Put, body, accessToken);
			var response = await _client.ExecuteAsync(request);
			return response;
		}

		protected async Task<ClientResponse> ExecutePutAsync(string uri) =>
			await _client.ExecuteAsync(new ClientRequest(uri, Method.Put));

		protected virtual ClientRequest CreateRequest<T>(string uri, Method method, T body, string accessToken = null)
		{
			var restRequest = new ClientRequest(uri, method);
			if (body != null)
			{
				var json = JsonConvert.SerializeObject(body);
				restRequest.AddJsonBody(json);
			}

			return restRequest;
		}
	}
}
