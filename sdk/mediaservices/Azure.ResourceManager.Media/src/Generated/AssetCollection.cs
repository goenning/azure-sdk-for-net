// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="AssetResource" /> and their operations.
    /// Each <see cref="AssetResource" /> in the collection will belong to the same instance of <see cref="MediaserviceResource" />.
    /// To get an <see cref="AssetCollection" /> instance call the GetAssets method from an instance of <see cref="MediaserviceResource" />.
    /// </summary>
    public partial class AssetCollection : ArmCollection, IEnumerable<AssetResource>, IAsyncEnumerable<AssetResource>
    {
        private readonly ClientDiagnostics _assetClientDiagnostics;
        private readonly AssetsRestOperations _assetRestClient;

        /// <summary> Initializes a new instance of the <see cref="AssetCollection"/> class for mocking. </summary>
        protected AssetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AssetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AssetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _assetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", AssetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AssetResource.ResourceType, out string assetApiVersion);
            _assetRestClient = new AssetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, assetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MediaserviceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MediaserviceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Asset in the Media Services account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}
        /// Operation Id: Assets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AssetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string assetName, AssetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _assetClientDiagnostics.CreateScope("AssetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _assetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<AssetResource>(Response.FromValue(new AssetResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an Asset in the Media Services account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}
        /// Operation Id: Assets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AssetResource> CreateOrUpdate(WaitUntil waitUntil, string assetName, AssetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _assetClientDiagnostics.CreateScope("AssetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _assetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assetName, data, cancellationToken);
                var operation = new MediaArmOperation<AssetResource>(Response.FromValue(new AssetResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of an Asset in the Media Services account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}
        /// Operation Id: Assets_Get
        /// </summary>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public virtual async Task<Response<AssetResource>> GetAsync(string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var scope = _assetClientDiagnostics.CreateScope("AssetCollection.Get");
            scope.Start();
            try
            {
                var response = await _assetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of an Asset in the Media Services account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}
        /// Operation Id: Assets_Get
        /// </summary>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public virtual Response<AssetResource> Get(string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var scope = _assetClientDiagnostics.CreateScope("AssetCollection.Get");
            scope.Start();
            try
            {
                var response = _assetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Assets in the Media Services account with optional filtering and ordering
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets
        /// Operation Id: Assets_List
        /// </summary>
        /// <param name="filter"> Restricts the set of items returned. </param>
        /// <param name="top"> Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n. </param>
        /// <param name="orderby"> Specifies the key by which the result collection should be ordered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AssetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AssetResource> GetAllAsync(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AssetResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _assetClientDiagnostics.CreateScope("AssetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _assetRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AssetResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AssetResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _assetClientDiagnostics.CreateScope("AssetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _assetRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AssetResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List Assets in the Media Services account with optional filtering and ordering
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets
        /// Operation Id: Assets_List
        /// </summary>
        /// <param name="filter"> Restricts the set of items returned. </param>
        /// <param name="top"> Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n. </param>
        /// <param name="orderby"> Specifies the key by which the result collection should be ordered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AssetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AssetResource> GetAll(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Page<AssetResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _assetClientDiagnostics.CreateScope("AssetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _assetRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AssetResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AssetResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _assetClientDiagnostics.CreateScope("AssetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _assetRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AssetResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}
        /// Operation Id: Assets_Get
        /// </summary>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var scope = _assetClientDiagnostics.CreateScope("AssetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _assetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}
        /// Operation Id: Assets_Get
        /// </summary>
        /// <param name="assetName"> The Asset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public virtual Response<bool> Exists(string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var scope = _assetClientDiagnostics.CreateScope("AssetCollection.Exists");
            scope.Start();
            try
            {
                var response = _assetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AssetResource> IEnumerable<AssetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AssetResource> IAsyncEnumerable<AssetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
