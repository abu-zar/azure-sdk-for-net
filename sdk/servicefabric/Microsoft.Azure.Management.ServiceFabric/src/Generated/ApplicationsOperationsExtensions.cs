// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApplicationsOperations.
    /// </summary>
    public static partial class ApplicationsOperationsExtensions
    {
            /// <summary>
            /// Gets a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Get a Service Fabric application resource created or in the process of
            /// being created in the Service Fabric cluster resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            public static ApplicationResource Get(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName)
            {
                return operations.GetAsync(resourceGroupName, clusterName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Get a Service Fabric application resource created or in the process of
            /// being created in the Service Fabric cluster resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationResource> GetAsync(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, applicationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric application resource with the specified
            /// name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='parameters'>
            /// The application resource.
            /// </param>
            public static ApplicationResource Create(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, ApplicationResource parameters)
            {
                return operations.CreateAsync(resourceGroupName, clusterName, applicationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric application resource with the specified
            /// name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='parameters'>
            /// The application resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationResource> CreateAsync(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, ApplicationResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, clusterName, applicationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Update a Service Fabric application resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='parameters'>
            /// The application resource for patch operations.
            /// </param>
            public static ApplicationResource Update(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, ApplicationResourceUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, clusterName, applicationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Update a Service Fabric application resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='parameters'>
            /// The application resource for patch operations.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationResource> UpdateAsync(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, ApplicationResourceUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, clusterName, applicationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric application resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            public static void Delete(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric application resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, applicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of application resources created in the specified Service
            /// Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Gets all application resources created or in the process of being created
            /// in the Service Fabric cluster resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            public static ApplicationResourceList List(this IApplicationsOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.ListAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of application resources created in the specified Service
            /// Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Gets all application resources created or in the process of being created
            /// in the Service Fabric cluster resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationResourceList> ListAsync(this IApplicationsOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric application resource with the specified
            /// name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='parameters'>
            /// The application resource.
            /// </param>
            public static ApplicationResource BeginCreate(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, ApplicationResource parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, clusterName, applicationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric application resource with the specified
            /// name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='parameters'>
            /// The application resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationResource> BeginCreateAsync(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, ApplicationResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, clusterName, applicationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Update a Service Fabric application resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='parameters'>
            /// The application resource for patch operations.
            /// </param>
            public static ApplicationResource BeginUpdate(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, ApplicationResourceUpdate parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, clusterName, applicationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Update a Service Fabric application resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='parameters'>
            /// The application resource for patch operations.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationResource> BeginUpdateAsync(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, ApplicationResourceUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, applicationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric application resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            public static void BeginDelete(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName)
            {
                operations.BeginDeleteAsync(resourceGroupName, clusterName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Service Fabric application resource.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric application resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IApplicationsOperations operations, string resourceGroupName, string clusterName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, clusterName, applicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}