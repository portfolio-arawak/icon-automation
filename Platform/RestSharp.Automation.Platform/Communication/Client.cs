using System;
using System.Threading.Tasks;

using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.Model.Platform.Communication;

namespace RestSharp.Automation.Platform.Communication;

public class Client : IClient
{
	private readonly IRestClient _restClient;

	public Client(
		IRestClient restClient)
	{
		_restClient = restClient;
	}

	public async Task<ClientResponse> ExecuteAsync(
		ClientRequest request)
	{
		var response = await _restClient.ExecuteAsync<ClientResponse>(request);
		ClientResponse clientResponse;
		try
		{
			clientResponse = new ClientResponse
			{
				Content = response.Content,
				ContentType = response.ContentType,
				StatusCode = response.StatusCode,
				ResponseUri = response.ResponseUri?.AbsoluteUri,
				Request = (ClientRequest)response.Request,
				RawBytes = response.RawBytes
			};
		}
		catch (Exception ex)
		{
			throw new OperationCanceledException($"The send API request returns exception. " +
												 $"\n\t\t\tMessage: [{ex.Message}], " +
												 $"\n\t\t\tSource: [{ex.Message}], " +
												 $"\n\t\t\tResponse status code: [{response.StatusCode}]," +
												 $"\n\t\t\tContent: [{response.Content}]," +
												 $"\n\t\t\tError Message: [{response.ErrorMessage}].");
		}
		return clientResponse;
	}
}