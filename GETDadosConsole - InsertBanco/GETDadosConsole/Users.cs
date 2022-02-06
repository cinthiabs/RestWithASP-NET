using Newtonsoft.Json;

public partial class Users
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("nome")]
    public string Nome { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }
}