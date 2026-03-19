using System.Threading.Tasks;
using RestSharp;
using WATIApi.Models;
using WATIApi.Utils;

namespace WATIApi.Actions {
    public interface ISalesAnalyticsActions {
        Task<GetSalesPipelineResponse> GetPipeline(GetSalesPipelineRequest requestData);
        Task<GetLeadStagesResponse> GetLeadStages();
    }

    public class SalesAnalyticsActions : ISalesAnalyticsActions {
        private readonly RestClient client;
        public SalesAnalyticsActions(RestClient client) {
            this.client = client;
        }

        //https://docs.wati.io/reference/post_api-ext-v3-salesanalytics-pipeline
        public async Task<GetSalesPipelineResponse> GetPipeline(GetSalesPipelineRequest requestData) {
            var request = new RestRequest("salesAnalytics/pipeline", Method.Post)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetSalesPipelineResponse>(request, Method.Post));
        }

        //https://docs.wati.io/reference/get_api-ext-v3-salesanalytics-leadstages
        public async Task<GetLeadStagesResponse> GetLeadStages() {
            var request = new RestRequest("salesAnalytics/leadStages", Method.Get);

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetLeadStagesResponse>(request, Method.Get));
        }
    }
}
