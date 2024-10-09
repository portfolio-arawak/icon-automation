using System.Net;
using System.Threading.Tasks;

using FluentAssertions;

using RestSharp.Automation.Model.Domain.Users;
using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.TestData.Storage.Users;

using TechTalk.SpecFlow;

namespace RestSharp.Automation.Tests.Features;

[Binding, Scope(Feature = "Users")]
public class UsersDefinition
{
	private readonly IUsersSteps _usersSteps;
	private UsersResponseModel _usersResponseModel;
	private ClientResponse _clientResponse;

	public UsersDefinition(
		IUsersSteps usersSteps)
	{
		_usersSteps = usersSteps;
	}

	[Given(@"I have access to the users api")]
	public void GivenIHaveAccessToTheUsersApi()
	{
		// semantic sugar
	}

	[When(@"I receive response from '([^']*)' endpoint")]
	public async Task WhenIReceiveResponseFromAsync(string endpoint)
	{
		_clientResponse = await _usersSteps.GetClientResponseAsync(endpoint);
	}

	[When(@"I receive model from '([^']*)' endpoint")]
	public async Task WhenIReceiveModelFromAsync(string endpoint)
	{
		_usersResponseModel = await _usersSteps.GetUsersResponseAsync(endpoint);
	}

	[Then(@"I see '([^']*)' status code")]
	public void ThenISeeStatusCode(string expectedStatus)
	{
		_clientResponse.StatusCode
			.Should()
			.Be(HttpStatusCode.OK);
	}

	[Then(@"I see that content type is '([^']*)'")]
	public void ThenISeeThatContentTypeIs(string expectedContentType)
	{
		_clientResponse.ContentType
			.Should()
			.Be(expectedContentType);
	}

	[Then(@"I see the content of the response is not empty")]
	public void ThenISeeTheContentOfTheResponseIsNotEmpty()
	{
		_clientResponse.Content
			.Should()
			.NotBeNullOrEmpty();
	}

	[Then(@"I see '([^']*)' data in response")]
	public void ThenISeeCorrectDataInResponse(string userPresetName)
	{
		var expectedData = UsersDataStorage.UsersPreset[userPresetName];
		_usersResponseModel.Data
			.Should()
			.BeEquivalentTo(expectedData.Data);
	}

	[Then(@"I see that '([^']*)' users are returned in the response")]
	public void ThenISeeThatUsersAreReturnedInTheResponse(int expectedCount)
	{
		_usersResponseModel.Data.Length
			.Should()
			.Be(expectedCount);
	}

	[Then(@"I see page number '([^']*)' in the response the same as in the URL")]
	public void ThenISeePageNumberInTheResponseTheSameAsInTheUrl(int expectedPageNumber)
	{
		_usersResponseModel.Page
			.Should()
			.Be(expectedPageNumber);
	}

	[Then(@"I see '([^']*)' users with details in the response")]
	public void ThenISeeUsersWithDetailsInTheResponse(string entityName)
	{
		var expectedUserDetails = UsersDataStorage.Users[entityName];
		var actualUserDetails = _usersResponseModel.Data;
		actualUserDetails
			.Should()
			.ContainEquivalentOf(expectedUserDetails);
	}

	[Then(@"I see that no any users are returned in the response")]
	public void ThenISeeThatNoAnyUsersAreReturnedInTheResponse()
	{
		_usersResponseModel.Data
			.Should()
			.BeEmpty();
	}
}