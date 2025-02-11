// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableHybridComputeResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableHybridComputeResourceGroupResource"/> class for mocking. </summary>
        protected MockableHybridComputeResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHybridComputeResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHybridComputeResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of HybridComputeLicenseResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of HybridComputeLicenseResources and their operations over a HybridComputeLicenseResource. </returns>
        public virtual HybridComputeLicenseCollection GetHybridComputeLicenses()
        {
            return GetCachedClient(client => new HybridComputeLicenseCollection(client, Id));
        }

        /// <summary>
        /// Retrieves information about the view of a license.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/licenses/{licenseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Licenses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeLicenseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="licenseName"> The name of the license. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="licenseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="licenseName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HybridComputeLicenseResource>> GetHybridComputeLicenseAsync(string licenseName, CancellationToken cancellationToken = default)
        {
            return await GetHybridComputeLicenses().GetAsync(licenseName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information about the view of a license.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/licenses/{licenseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Licenses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeLicenseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="licenseName"> The name of the license. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="licenseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="licenseName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<HybridComputeLicenseResource> GetHybridComputeLicense(string licenseName, CancellationToken cancellationToken = default)
        {
            return GetHybridComputeLicenses().Get(licenseName, cancellationToken);
        }

        /// <summary> Gets a collection of HybridComputeMachineResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of HybridComputeMachineResources and their operations over a HybridComputeMachineResource. </returns>
        public virtual HybridComputeMachineCollection GetHybridComputeMachines()
        {
            return GetCachedClient(client => new HybridComputeMachineCollection(client, Id));
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a hybrid machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HybridComputeMachineResource>> GetHybridComputeMachineAsync(string machineName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetHybridComputeMachines().GetAsync(machineName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a hybrid machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<HybridComputeMachineResource> GetHybridComputeMachine(string machineName, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetHybridComputeMachines().Get(machineName, expand, cancellationToken);
        }

        /// <summary> Gets a collection of HybridComputePrivateLinkScopeResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of HybridComputePrivateLinkScopeResources and their operations over a HybridComputePrivateLinkScopeResource. </returns>
        public virtual HybridComputePrivateLinkScopeCollection GetHybridComputePrivateLinkScopes()
        {
            return GetCachedClient(client => new HybridComputePrivateLinkScopeCollection(client, Id));
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputePrivateLinkScopeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HybridComputePrivateLinkScopeResource>> GetHybridComputePrivateLinkScopeAsync(string scopeName, CancellationToken cancellationToken = default)
        {
            return await GetHybridComputePrivateLinkScopes().GetAsync(scopeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputePrivateLinkScopeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScope(string scopeName, CancellationToken cancellationToken = default)
        {
            return GetHybridComputePrivateLinkScopes().Get(scopeName, cancellationToken);
        }
    }
}
