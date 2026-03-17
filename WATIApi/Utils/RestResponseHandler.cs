using System;
using RestSharp;

namespace WATIApi.Utils {
    internal static class RestResponseHandler {
        public static T Handle<T>(RestResponse<T> response) {
            if (response.ResponseStatus == ResponseStatus.Error && response.ErrorException != null && response.ErrorException is System.Text.Json.JsonException)
                throw new ApplicationException(response.Content, response.ErrorException).WithContent(response.Content);
            if (response.ErrorException != null)
                throw response.ErrorException.WithContent(response.Content);
            if (response.Data == null)
                throw new ApplicationException("Empty Data!").WithContent(response.Content);
            return response.Data;
        }

        public static (string? ContentType, byte[] Contents, string? FileName) HandleRaw(RestResponse response) {
            if (response.ResponseStatus == ResponseStatus.Error && response.ErrorException != null && response.ErrorException is System.Text.Json.JsonException)
                throw new ApplicationException(response.Content, response.ErrorException).WithContent(response.Content);
            if (response.ErrorException != null)
                throw response.ErrorException.WithContent(response.Content);
            if (response.RawBytes == null)
                throw new ApplicationException("Empty Response!").WithContent(response.Content);

            var contentDisposition = response.GetContentHeaderValue("Content-Disposition");
            if (contentDisposition != null)
                contentDisposition = System.Net.Http.Headers.ContentDispositionHeaderValue.Parse(contentDisposition).FileName;
            return (response.ContentType, response.RawBytes, contentDisposition);
        }
    }
}
