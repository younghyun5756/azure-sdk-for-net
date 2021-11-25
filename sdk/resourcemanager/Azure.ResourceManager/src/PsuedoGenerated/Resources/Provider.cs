// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> The Providers service client. </summary>
    public partial class Provider : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ProviderRestOperations _restClient;
        private readonly ProviderData _data;

        /// <summary>
        /// Initializes a new instance of the <see cref="Provider"/> class for mocking.
        /// </summary>
        protected Provider()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Provider"/> class.
        /// </summary>
        /// <param name="clientContext"></param>
        /// <param name="id"></param>
        internal Provider(ClientContext clientContext, ResourceIdentifier id)
            : base(clientContext, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ProviderRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Provider"/> class.
        /// </summary>
        /// <param name="operations"> The operations object to copy the client parameters from. </param>
        /// <param name="providerData"></param>
        internal Provider(ArmResource operations, ProviderData providerData)
            : base(operations, providerData.Id)
        {
            _data = providerData;
            HasData = true;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ProviderRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <inheritdoc/>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary>
        /// Gets the resource type definition for a ResourceType.
        /// </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/providers";

        /// <summary>
        /// Gets whether or not the current instance has data.
        /// </summary>
        public bool HasData { get; }

        /// <summary>
        /// Gets the data representing this provider.
        /// </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProviderData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data you must call Get first");
                return _data;
            }
        }

        /// <summary> Unregisters a subscription from a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to unregister. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> UnregisterAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Provider.Unregister");
            scope.Start();
            try
            {
                var result = await _restClient.UnregisterAsync(resourceProviderNamespace, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Provider(this, result), result.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unregisters a subscription from a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to unregister. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Unregister(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Provider.Unregister");
            scope.Start();
            try
            {
                var result = _restClient.Unregister(resourceProviderNamespace, cancellationToken);
                return Response.FromValue(new Provider(this, result), result.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Registers a subscription with a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to register. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> RegisterAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Provider.Register");
            scope.Start();
            try
            {
                var result = await _restClient.RegisterAsync(resourceProviderNamespace, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Provider(this, result), result.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Registers a subscription with a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to register. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Register(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Provider.Register");
            scope.Start();
            try
            {
                var result = _restClient.Register(resourceProviderNamespace, cancellationToken);
                return Response.FromValue(new Provider(this, result), result.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the current Provider from Azure. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Provider.Get");
            scope.Start();

            try
            {
                var result = _restClient.Get(Id.Name, null, cancellationToken);
                if (result.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(result.GetRawResponse());

                return Response.FromValue(new Provider(this, result), result.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the current Provider from Azure. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Provider.Get");
            scope.Start();

            try
            {
                var response = await _restClient.GetAsync(Id.Name, null, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);

                return Response.FromValue(new Provider(this, response), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the features under this provider
        /// </summary>
        /// <returns></returns>
        public virtual FeatureCollection GetFeatures()
        {
            return new FeatureCollection(this);
        }
    }
}
