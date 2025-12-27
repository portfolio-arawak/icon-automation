using Newtonsoft.Json;

namespace RestSharp.Automation.Model.Domain.Users;

public class UsersResponseModel
{
	public int Page { get; set; }
	public int PerPage { get; set; }
	public int Total { get; set; }
	public int TotalPages { get; set; }
	public User[] Data { get; set; }
	public Support Support { get; set; }
}

public class Support
{
	public string Url { get; set; }
	public string Text { get; set; }
}

public class User
{
	public int Id { get; set; }
	public string Email { get; set; }
	[JsonProperty("first_name")]
	public string FirstName { get; set; }
	[JsonProperty("last_name")]
	public string LastName { get; set; }
	public string Avatar { get; set; }
}
