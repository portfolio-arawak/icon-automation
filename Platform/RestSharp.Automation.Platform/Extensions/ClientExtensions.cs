using System;

using Newtonsoft.Json;

using RestSharp.Automation.Model.Platform.Client;

namespace RestSharp.Automation.Platform.Extensions
{
	public static class ClientExtensions
	{
		public static T GetModel<T>(this ClientResponse response, bool parseOnlySuccessStatus = true)
		{
			if (response is null)
			{
				throw new ApplicationException("Can not get model from null response");
			}

			if (parseOnlySuccessStatus && !response.IsSuccessfulStatusCode())
			{
				throw new ApplicationException(
					$"Can not get model from failed response, " +
					$"StatusCode: {response.StatusCode}, " +
					$"Response: {response.Content}");
			}

			return JsonConvert.DeserializeObject<T>(response.Content);
		}

		public static ClientRequest AddAuthorizationHeader(this ClientRequest request, string accessToken)
		{
			request.AddHeader("Authorization", accessToken);
			return request;
		}

		public static bool IsSuccessfulStatusCode(this ClientResponse response)
		{
			return (int)response.StatusCode < 300 && (int)response.StatusCode >= 200;
		}
	}
}
