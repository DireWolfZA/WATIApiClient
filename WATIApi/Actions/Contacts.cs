using System;
using System.Threading.Tasks;
using RestSharp;
using WATIApi.Models;
using WATIApi.Utils;

namespace WATIApi.Actions {
    public interface IContactActions {
        Task<Contact> Add(AddContactRequest requestData);
        Task<GetContactListResponse> Get(int pageNumber = 1, int pageSize = 100);
        Task<UpdateContactsResponse> Update(UpdateContactsRequest requestData);
        /// <param name="target">
        /// The target contact in the following formats:
        /// <br />* &#x60;ContactID&#x60;: The unique ID of a contact.
        /// <br />* &#x60;PhoneNumber&#x60;: The contact&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </param>
        Task<Contact> GetOne(string target);
        Task<AssignContactToTeamsResponse> AssignContactToTeams(AssignContactToTeamsRequest requestData);
        Task<GetContactCountResponse> GetCount(DateTime? dateFrom = null, DateTime? dateTo = null);
    }

    public class ContactActions : IContactActions {
        private readonly RestClient client;
        public ContactActions(RestClient client) {
            this.client = client;
        }

        //https://docs.wati.io/reference/post_api-ext-v3-contacts
        public async Task<Contact> Add(AddContactRequest requestData) {
            var request = new RestRequest("contacts", Method.Post)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<Contact>(request, Method.Post));
        }

        //https://docs.wati.io/reference/get_api-ext-v3-contacts
        public async Task<GetContactListResponse> Get(int pageNumber = 1, int pageSize = 100) {
            var request = new RestRequest("contacts", Method.Get)
                .AddParameter("page_number", pageNumber)
                .AddParameter("page_size", pageSize);

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetContactListResponse>(request, Method.Get));
        }

        //https://docs.wati.io/reference/put_api-ext-v3-contacts
        public async Task<UpdateContactsResponse> Update(UpdateContactsRequest requestData) {
            var request = new RestRequest("contacts", Method.Put)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<UpdateContactsResponse>(request, Method.Put));
        }

        //https://docs.wati.io/reference/get_api-ext-v3-contacts-target
        /// <inheritdoc/>
        public async Task<Contact> GetOne(string target) {
            var request = new RestRequest($"contacts/{target}", Method.Get);

            return RestResponseHandler.Handle(await client.ExecuteAsync<Contact>(request, Method.Get));
        }

        //https://docs.wati.io/reference/put_api-ext-v3-contacts-teams
        public async Task<AssignContactToTeamsResponse> AssignContactToTeams(AssignContactToTeamsRequest requestData) {
            var request = new RestRequest("contacts/teams", Method.Put)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<AssignContactToTeamsResponse>(request, Method.Put));
        }

        //https://docs.wati.io/reference/get_api-ext-v3-contacts-count
        public async Task<GetContactCountResponse> GetCount(DateTime? dateFrom = null, DateTime? dateTo = null) {
            var request = new RestRequest("contacts/count", Method.Get);
            if (dateFrom != null)
                request.AddParameter("date_from", dateFrom.Value.ToString("O"));
            if (dateTo != null)
                request.AddParameter("date_to", dateTo.Value.ToString("O"));

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetContactCountResponse>(request, Method.Get));
        }
    }
}
