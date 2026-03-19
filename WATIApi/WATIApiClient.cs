using System.Text.Json;
using RestSharp;
using RestSharp.Serializers.Json;
using WATIApi.Actions;

namespace WATIApi {
    public interface IWATIApiClient {
        ICampaignActions Campaigns { get; }
        IChannelActions Channels { get; }
        IChatbotActions Chatbots { get; }
        IContactActions Contacts { get; }
        IConversationActions Conversations { get; }
        IMessageTemplateActions MessageTemplates { get; }
        ISalesAnalyticsActions SalesAnalytics { get; }
    }

    public class WATIApiClient : IWATIApiClient {
        private readonly RestClient client;

        public WATIApiClient(string accessToken) {
            Utils.Utils.RequireArgument(nameof(accessToken), string.IsNullOrWhiteSpace(accessToken) ? null : accessToken);

            client = new RestClient("https://live-mt-server.wati.io/api/ext/v3", configureSerialization: config => config.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.Web)));

            client.AddDefaultHeader("Accept", "application/json");
            client.AddDefaultHeader("Authorization", $"Bearer {accessToken}");
        }

        public ICampaignActions Campaigns => new CampaignActions(client);
        public IChannelActions Channels => new ChannelActions(client);
        public IChatbotActions Chatbots => new ChatbotActions(client);
        public IContactActions Contacts => new ContactActions(client);
        public IConversationActions Conversations => new ConversationActions(client);
        public IMessageTemplateActions MessageTemplates => new MessageTemplateActions(client);
        public ISalesAnalyticsActions SalesAnalytics => new SalesAnalyticsActions(client);
    }
}
