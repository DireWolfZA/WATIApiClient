using System.Threading.Tasks;
using RestSharp;
using WATIApi.Models;
using WATIApi.Utils;

namespace WATIApi.Actions {
    public interface IChannelActions {
        Task<GetChannelsResponse> GetChannels(int pageNumber = 1, int pageSize = 100);
    }

    public class ChannelActions : IChannelActions {
        private readonly RestClient client;
        public ChannelActions(RestClient client) {
            this.client = client;
        }

        //https://docs.wati.io/reference/get_api-ext-v3-broadcasts-overview
        public async Task<GetChannelsResponse> GetChannels(int pageNumber = 1, int pageSize = 100) {
            var request = new RestRequest("channels", Method.Get)
                .AddParameter("page_number", pageNumber)
                .AddParameter("page_size", pageSize);

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetChannelsResponse>(request, Method.Get));
        }
    }
}
