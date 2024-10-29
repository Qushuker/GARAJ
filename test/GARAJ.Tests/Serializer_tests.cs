using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace GARAJ.Tests;

public class AdminSettings
{
    public string Login { get; set; }
    public string Password { get; set; }
}

public class Serializer_tests : GARAJTestBase
{
    [Fact]
    public async Task SerializerTest()
    {
        AdminSettings adminSettings = new AdminSettings()
        {
            Login = "admin",
            Password = "123qwe"
        };

        string jsonResult = JsonSerializer.Serialize(adminSettings);

        AdminSettings fromJson = JsonSerializer.Deserialize<AdminSettings>(jsonResult);

        var l = 0;
    }
}