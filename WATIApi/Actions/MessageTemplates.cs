using System.Threading.Tasks;
using RestSharp;
using WATIApi.Models;
using WATIApi.Utils;

namespace WATIApi.Actions {
    public interface IMessageTemplateActions {
        Task<MessageTemplate> GetOne(string templateID);
        /// <param name="channel">Name or phone number of the channel (null for default channel).</param>
        Task<GetMessageTemplatesResponse> Get(string? channel, int pageNumber = 1, int pageSize = 100);
        Task<SendTemplateMessagesResponse> Send(SendTemplateMessagesRequest requestData);
        Task<SendTemplateMessagesResponse> Schedule(ScheduleTemplateMessagesRequest requestData);
    }

    public class MessageTemplateActions : IMessageTemplateActions {
        private readonly RestClient client;
        public MessageTemplateActions(RestClient client) {
            this.client = client;
        }

        //https://docs.wati.io/reference/get_api-ext-v3-messagetemplates-template-id
        public async Task<MessageTemplate> GetOne(string templateID) {
            var request = new RestRequest($"messageTemplates/{templateID}", Method.Get);

            return RestResponseHandler.Handle(await client.ExecuteAsync<MessageTemplate>(request, Method.Get));
        }

        //https://docs.wati.io/reference/get_api-ext-v3-messagetemplates
        /// <inheritdoc/>
        public async Task<GetMessageTemplatesResponse> Get(string? channel, int pageNumber = 1, int pageSize = 100) {
            var request = new RestRequest($"messageTemplates", Method.Get)
                .AddParameter("channel", channel)
                .AddParameter("page_number", pageNumber)
                .AddParameter("page_size", pageSize);

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetMessageTemplatesResponse>(request, Method.Get));
        }

        //https://docs.wati.io/reference/post_api-ext-v3-messagetemplates-send
        public async Task<SendTemplateMessagesResponse> Send(SendTemplateMessagesRequest requestData) {
            var request = new RestRequest("messageTemplates/send", Method.Post)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<SendTemplateMessagesResponse>(request, Method.Post));
        }

        //https://docs.wati.io/reference/post_api-ext-v3-messagetemplates-schedule
        public async Task<SendTemplateMessagesResponse> Schedule(ScheduleTemplateMessagesRequest requestData) {
            var request = new RestRequest("messageTemplates/schedule", Method.Post)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<SendTemplateMessagesResponse>(request, Method.Post));
        }
    }
}
