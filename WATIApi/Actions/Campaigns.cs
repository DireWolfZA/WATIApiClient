using System;
using System.Threading.Tasks;
using RestSharp;
using WATIApi.Models;
using WATIApi.Utils;

namespace WATIApi.Actions {
    public interface ICampaignActions {
        Task<GetBroadcastsResponse> GetCampaigns(int pageNumber = 1, int pageSize = 100, string? channel = null);
        Task<BroadcastDetails> GetCampaignDetails(string broadcastID);
        Task<GetBroadcastRecipientsResponse> GetCampaignRecipients(string broadcastID, int pageNumber = 1, int pageSize = 100);
        Task<GetBroadcastsOverviewResponse> GetCampaignsOverview(DateTime dateFrom, DateTime dateTo, string? channel = null, string? searchString = null);
    }

    public class CampaignActions : ICampaignActions {
        private readonly RestClient client;
        public CampaignActions(RestClient client) {
            this.client = client;
        }

        //https://docs.wati.io/reference/get_api-ext-v3-broadcasts
        public async Task<GetBroadcastsResponse> GetCampaigns(int pageNumber = 1, int pageSize = 100, string? channel = null) {
            var request = new RestRequest("broadcasts", Method.Get)
                .AddParameter("page_number", pageNumber)
                .AddParameter("page_size", pageSize);
            if (channel != null)
                request.AddParameter("channel", channel);

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetBroadcastsResponse>(request, Method.Get));
        }

        //https://docs.wati.io/reference/get_api-ext-v3-broadcasts-broadcast-id
        public async Task<BroadcastDetails> GetCampaignDetails(string broadcastID) {
            Utils.Utils.RequireArgument(nameof(broadcastID), broadcastID);
            var request = new RestRequest($"broadcasts/{broadcastID}", Method.Get);

            return RestResponseHandler.Handle(await client.ExecuteAsync<BroadcastDetails>(request, Method.Get));
        }

        //https://docs.wati.io/reference/get_api-ext-v3-broadcasts-broadcast-id-recipients
        public async Task<GetBroadcastRecipientsResponse> GetCampaignRecipients(string broadcastID, int pageNumber = 1, int pageSize = 100) {
            Utils.Utils.RequireArgument(nameof(broadcastID), broadcastID);
            var request = new RestRequest($"broadcasts/{broadcastID}/recipients", Method.Get)
                .AddParameter("page_number", pageNumber)
                .AddParameter("page_size", pageSize);

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetBroadcastRecipientsResponse>(request, Method.Get));
        }

        //https://docs.wati.io/reference/get_api-ext-v3-broadcasts-overview
        public async Task<GetBroadcastsOverviewResponse> GetCampaignsOverview(DateTime dateFrom, DateTime dateTo, string? channel = null, string? searchString = null) {
            var request = new RestRequest("broadcasts/overview", Method.Get)
                .AddParameter("date_from", dateFrom.ToUniversalTime().ToString("O")) // O is ISO8601-compatible, which OpenAPI v3 date-time format works with - https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings#Roundtrip
                .AddParameter("date_to", dateTo.ToUniversalTime().ToString("O"));
            if (channel != null)
                request.AddParameter("channel", channel);
            if (searchString != null)
                request.AddParameter("search_string", searchString);

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetBroadcastsOverviewResponse>(request, Method.Get));
        }
    }
}
