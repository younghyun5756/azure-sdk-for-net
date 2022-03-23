// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class ModelSettingsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _environmentFqdn;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ModelSettingsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="environmentFqdn"> Per environment FQDN, for example 10000000-0000-0000-0000-100000000109.env.timeseries.azure.com. You can obtain this domain name from the response of the Get Environments API, Azure portal, or Azure Resource Manager. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="environmentFqdn"/> or <paramref name="apiVersion"/> is null. </exception>
        public ModelSettingsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string environmentFqdn, string apiVersion = "2020-07-31")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _environmentFqdn = environmentFqdn ?? throw new ArgumentNullException(nameof(environmentFqdn));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetRequest(string clientSessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_environmentFqdn, false);
            uri.AppendPath("/timeseries/modelSettings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (clientSessionId != null)
            {
                request.Headers.Add("x-ms-client-session-id", clientSessionId);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns the model settings which includes model display name, Time Series ID properties and default type ID. Every Gen2 environment has a model that is automatically created. </summary>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ModelSettingsResponse>> GetAsync(string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(clientSessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ModelSettingsResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ModelSettingsResponse.DeserializeModelSettingsResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns the model settings which includes model display name, Time Series ID properties and default type ID. Every Gen2 environment has a model that is automatically created. </summary>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ModelSettingsResponse> Get(string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(clientSessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ModelSettingsResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ModelSettingsResponse.DeserializeModelSettingsResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(UpdateModelSettingsRequest parameters, string clientSessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_environmentFqdn, false);
            uri.AppendPath("/timeseries/modelSettings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (clientSessionId != null)
            {
                request.Headers.Add("x-ms-client-session-id", clientSessionId);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Updates time series model settings - either the model name or default type ID. </summary>
        /// <param name="parameters"> Model settings update request body. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async Task<Response<ModelSettingsResponse>> UpdateAsync(UpdateModelSettingsRequest parameters, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateUpdateRequest(parameters, clientSessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ModelSettingsResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ModelSettingsResponse.DeserializeModelSettingsResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates time series model settings - either the model name or default type ID. </summary>
        /// <param name="parameters"> Model settings update request body. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public Response<ModelSettingsResponse> Update(UpdateModelSettingsRequest parameters, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateUpdateRequest(parameters, clientSessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ModelSettingsResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ModelSettingsResponse.DeserializeModelSettingsResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
