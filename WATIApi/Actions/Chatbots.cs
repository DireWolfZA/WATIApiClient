using System.Threading.Tasks;
using RestSharp;
using WATIApi.Models;
using WATIApi.Utils;

namespace WATIApi.Actions {
    public interface IChatbotActions {
        Task<GetChatbotListResponse> GetChatbots(int pageNumber = 1, int pageSize = 100);
        Task<StartChatbotResponse> StartChatbot(StartChatbotRequest requestData);
    }

    public class ChatbotActions : IChatbotActions {
        private readonly RestClient client;
        public ChatbotActions(RestClient client) {
            this.client = client;
        }

        //https://docs.wati.io/reference/get_api-ext-v3-chatbots
        public async Task<GetChatbotListResponse> GetChatbots(int pageNumber = 1, int pageSize = 100) {
            var request = new RestRequest("chatbots", Method.Get)
                .AddParameter("page_number", pageNumber)
                .AddParameter("page_size", pageSize);

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetChatbotListResponse>(request, Method.Get));
        }

        //https://docs.wati.io/reference/post_api-ext-v3-chatbots-start
        public async Task<StartChatbotResponse> StartChatbot(StartChatbotRequest requestData) {
            var request = new RestRequest("chatbots/start", Method.Post)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<StartChatbotResponse>(request, Method.Post));
        }
    }
}
