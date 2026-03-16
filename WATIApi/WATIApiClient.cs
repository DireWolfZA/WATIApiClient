using System.Text.Json;
using RestSharp;
using RestSharp.Serializers.Json;

namespace WATIApi {
    public interface IWATIApiClient {
    }

    public class WATIApiClient : IWATIApiClient {
        private readonly RestClient client;

        public WATIApiClient(string accessToken) {
            Utils.Utils.RequireArgument(nameof(accessToken), string.IsNullOrWhiteSpace(accessToken) ? null : accessToken);

            client = new RestClient("https://live-mt-server.wati.io/api/ext/v3", configureSerialization: config => config.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.Web)));

            client.AddDefaultHeader("Accept", "application/json");
            client.AddDefaultHeader("Authorization", $"Bearer {accessToken}");
        }
    }
}
