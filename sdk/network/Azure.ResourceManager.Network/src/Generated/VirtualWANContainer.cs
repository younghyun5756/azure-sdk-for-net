// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualWAN and their operations over a ResourceGroup. </summary>
    public partial class VirtualWANContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualWansRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualWANContainer"/> class for mocking. </summary>
        protected VirtualWANContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualWANContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualWANContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VirtualWansRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wANParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> or <paramref name="wANParameters"/> is null. </exception>
        public virtual VirtualWanCreateOrUpdateOperation CreateOrUpdate(string virtualWANName, VirtualWANData wANParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, virtualWANName, wANParameters, cancellationToken);
                var operation = new VirtualWanCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, virtualWANName, wANParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wANParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> or <paramref name="wANParameters"/> is null. </exception>
        public async virtual Task<VirtualWanCreateOrUpdateOperation> CreateOrUpdateAsync(string virtualWANName, VirtualWANData wANParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, virtualWANName, wANParameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualWanCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, virtualWANName, wANParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualWAN> Get(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.Get");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, virtualWANName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualWAN(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualWAN>> GetAsync(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.Get");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, virtualWANName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualWAN(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualWAN> GetIfExists(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.GetIfExists");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, virtualWANName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualWAN>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualWAN(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualWAN>> GetIfExistsAsync(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.GetIfExists");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, virtualWANName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualWAN>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualWAN(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                var response = GetIfExists(virtualWANName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                var response = await GetIfExistsAsync(virtualWANName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the VirtualWANs in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualWAN" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualWAN> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualWAN> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualWAN> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the VirtualWANs in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualWAN" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualWAN> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualWAN>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualWAN>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualWAN" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualWAN.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualWAN" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualWAN.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, VirtualWAN, VirtualWANData> Construct() { }
    }
}
