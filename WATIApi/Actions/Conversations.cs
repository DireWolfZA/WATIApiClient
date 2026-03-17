using System.Threading.Tasks;
using RestSharp;
using WATIApi.Models;
using WATIApi.Utils;

namespace WATIApi.Actions {
    public interface IConversationActions {
        /// <param name="target"><inheritdoc cref="AssignOperator"/></param>
        Task<GetMessagesByConversationIDResponse> Get(string target, int pageNumber = 1, int pageSize = 100);
        Task<SendTextResponse> SendMessage(SendTextRequest requestData);
        Task<SendFileResponse> SendMessage(SendFileRequest requestData);
        Task<SendFileResponse> SendMessage(SendFileViaURLRequest requestData);
        Task<(string? ContentType, byte[] Contents, string? FileName)> GetMediaFile(string messageID);
        /// <param name="target">
        /// The target conversation in the following formats:
        /// <br />* &#x60;ConversationID&#x60;: The unique ID of a conversation.
        /// <br />* &#x60;PhoneNumber&#x60;: The conversation&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </param>
        Task<AssignConversationOperatorResponse> AssignOperator(string target, AssignConversationOperatorRequest requestData);
        /// <param name="target"><inheritdoc cref="AssignOperator"/></param>
        Task<UpdateConversationStatusResponse> UpdateStatus(string target, UpdateConversationStatusRequest requestData);
        Task<SendInteractiveMessageResponse> SendMessage(SendInteractiveMessageRequest requestData);
    }

    public class ConversationActions : IConversationActions {
        private readonly RestClient client;
        public ConversationActions(RestClient client) {
            this.client = client;
        }

        //https://docs.wati.io/reference/get_api-ext-v3-conversations-target-messages
        /// <inheritdoc/>
        public async Task<GetMessagesByConversationIDResponse> Get(string target, int pageNumber = 1, int pageSize = 100) {
            var request = new RestRequest($"conversations/{target}/messages", Method.Get)
                .AddParameter("page_number", pageNumber)
                .AddParameter("page_size", pageSize);

            return RestResponseHandler.Handle(await client.ExecuteAsync<GetMessagesByConversationIDResponse>(request, Method.Get));
        }

        //https://docs.wati.io/reference/post_api-ext-v3-conversations-messages-text
        public async Task<SendTextResponse> SendMessage(SendTextRequest requestData) {
            var request = new RestRequest("conversations/messages/text", Method.Post)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<SendTextResponse>(request, Method.Post));
        }

        //https://docs.wati.io/reference/post_api-ext-v3-conversations-messages-file
        public async Task<SendFileResponse> SendMessage(SendFileRequest requestData) {
            var request = new RestRequest("conversations/messages/file", Method.Post)
                .AddParameter("target", requestData.Target);
            if (requestData.FileContents != null)
                request.AddFile("file", requestData.FileContents, requestData.FileName, requestData.ContentType);
            else if (requestData.FileStream != null)
                request.AddFile("file", () => requestData.FileStream, requestData.FileName, requestData.ContentType);
            else
                throw new System.ArgumentNullException("requestData.FileContents / requestData.FileStream", "No File Data provided!");
            if (requestData.Caption != null)
                request.AddParameter("caption", requestData.Caption);

            return RestResponseHandler.Handle(await client.ExecuteAsync<SendFileResponse>(request, Method.Post));
        }

        //https://docs.wati.io/reference/post_api-ext-v3-conversations-messages-fileviaurl
        public async Task<SendFileResponse> SendMessage(SendFileViaURLRequest requestData) {
            var request = new RestRequest("conversations/messages/fileViaUrl", Method.Post)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<SendFileResponse>(request, Method.Post));
        }

        //https://docs.wati.io/reference/get_api-ext-v3-conversations-messages-file-message-id
        public async Task<(string? ContentType, byte[] Contents, string? FileName)> GetMediaFile(string messageID) {
            var request = new RestRequest($"conversations/messages/file/{messageID}", Method.Get);

            return RestResponseHandler.HandleRaw(await client.ExecuteAsync(request, Method.Get));
        }

        //https://docs.wati.io/reference/put_api-ext-v3-conversations-target-operator
        /// <inheritdoc/>
        public async Task<AssignConversationOperatorResponse> AssignOperator(string target, AssignConversationOperatorRequest requestData) {
            var request = new RestRequest($"conversations/{target}/operator", Method.Put)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<AssignConversationOperatorResponse>(request, Method.Put));
        }

        //https://docs.wati.io/reference/put_api-ext-v3-conversations-target-status
        public async Task<UpdateConversationStatusResponse> UpdateStatus(string target, UpdateConversationStatusRequest requestData) {
            var request = new RestRequest($"conversations/{target}/status", Method.Put)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<UpdateConversationStatusResponse>(request, Method.Put));
        }

        //https://docs.wati.io/reference/post_api-ext-v3-conversations-messages-interactive
        public async Task<SendInteractiveMessageResponse> SendMessage(SendInteractiveMessageRequest requestData) {
            var request = new RestRequest("conversations/messages/interactive", Method.Post)
                .AddJsonBody(requestData);

            return RestResponseHandler.Handle(await client.ExecuteAsync<SendInteractiveMessageResponse>(request, Method.Post));
        }
    }
}
