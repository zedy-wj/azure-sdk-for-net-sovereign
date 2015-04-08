// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute
{
    /// <summary>
    /// The Compute Management API includes operations for managing the dns
    /// servers for your subscription.
    /// </summary>
    internal partial class DNSServerOperations : IServiceOperations<ComputeManagementClient>, IDNSServerOperations
    {
        /// <summary>
        /// Initializes a new instance of the DNSServerOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal DNSServerOperations(ComputeManagementClient client)
        {
            this._client = client;
        }
        
        private ComputeManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ComputeManagementClient.
        /// </summary>
        public ComputeManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Add a definition for a DNS server to an existing deployment. VM's
        /// in this deployment will be programmed to use this DNS server for
        /// all DNS resolutions
        /// </summary>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Add DNS Server operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public async Task<OperationStatusResponse> AddDNSServerAsync(string serviceName, string deploymentName, DNSAddParameters parameters, CancellationToken cancellationToken)
        {
            ComputeManagementClient client = this.Client;
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serviceName", serviceName);
                tracingParameters.Add("deploymentName", deploymentName);
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "AddDNSServerAsync", tracingParameters);
            }
            
            cancellationToken.ThrowIfCancellationRequested();
            OperationStatusResponse response = await client.DnsServer.BeginAddingDNSServerAsync(serviceName, deploymentName, parameters, cancellationToken).ConfigureAwait(false);
            if (response.Status == OperationStatus.Succeeded)
            {
                return response;
            }
            cancellationToken.ThrowIfCancellationRequested();
            OperationStatusResponse result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
            int delayInSeconds = 30;
            if (client.LongRunningOperationInitialTimeout >= 0)
            {
                delayInSeconds = client.LongRunningOperationInitialTimeout;
            }
            while ((result.Status != OperationStatus.InProgress) == false)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await TaskEx.Delay(delayInSeconds * 1000, cancellationToken).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested();
                result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
                delayInSeconds = 30;
                if (client.LongRunningOperationRetryTimeout >= 0)
                {
                    delayInSeconds = client.LongRunningOperationRetryTimeout;
                }
            }
            
            if (shouldTrace)
            {
                TracingAdapter.Exit(invocationId, result);
            }
            
            if (result.Status != OperationStatus.Succeeded)
            {
                if (result.Error != null)
                {
                    CloudException ex = new CloudException(result.Error.Code + " : " + result.Error.Message);
                    ex.Error = new CloudError();
                    ex.Error.Code = result.Error.Code;
                    ex.Error.Message = result.Error.Message;
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
                else
                {
                    CloudException ex = new CloudException("");
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
            }
            
            return result;
        }
        
        /// <summary>
        /// Add a definition for a DNS server to an existing deployment. VM's
        /// in this deployment will be programmed to use this DNS server for
        /// all DNS resolutions
        /// </summary>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Add DNS Server operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public async Task<OperationStatusResponse> BeginAddingDNSServerAsync(string serviceName, string deploymentName, DNSAddParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (serviceName == null)
            {
                throw new ArgumentNullException("serviceName");
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException("deploymentName");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serviceName", serviceName);
                tracingParameters.Add("deploymentName", deploymentName);
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "BeginAddingDNSServerAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/services/hostedservices/";
            url = url + Uri.EscapeDataString(serviceName);
            url = url + "/deployments/";
            url = url + Uri.EscapeDataString(deploymentName);
            url = url + "/dnsservers";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2015-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                XDocument requestDoc = new XDocument();
                
                XElement dnsServerElement = new XElement(XName.Get("DnsServer", "http://schemas.microsoft.com/windowsazure"));
                requestDoc.Add(dnsServerElement);
                
                if (parameters.Name != null)
                {
                    XElement nameElement = new XElement(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                    nameElement.Value = parameters.Name;
                    dnsServerElement.Add(nameElement);
                }
                
                if (parameters.Address != null)
                {
                    XElement addressElement = new XElement(XName.Get("Address", "http://schemas.microsoft.com/windowsazure"));
                    addressElement.Value = parameters.Address;
                    dnsServerElement.Add(addressElement);
                }
                
                requestContent = requestDoc.ToString();
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/xml");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    OperationStatusResponse result = null;
                    // Deserialize Response
                    result = new OperationStatusResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deletes a definition for an existing DNS server from the deployment
        /// </summary>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public async Task<OperationStatusResponse> BeginDeletingDNSServerAsync(string serviceName, string deploymentName, string dnsServerName, CancellationToken cancellationToken)
        {
            // Validate
            if (serviceName == null)
            {
                throw new ArgumentNullException("serviceName");
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException("deploymentName");
            }
            if (dnsServerName == null)
            {
                throw new ArgumentNullException("dnsServerName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serviceName", serviceName);
                tracingParameters.Add("deploymentName", deploymentName);
                tracingParameters.Add("dnsServerName", dnsServerName);
                TracingAdapter.Enter(invocationId, this, "BeginDeletingDNSServerAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/services/hostedservices/";
            url = url + Uri.EscapeDataString(serviceName);
            url = url + "/deployments/";
            url = url + Uri.EscapeDataString(deploymentName);
            url = url + "/dnsservers/";
            url = url + Uri.EscapeDataString(dnsServerName);
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Delete;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2015-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    OperationStatusResponse result = null;
                    // Deserialize Response
                    result = new OperationStatusResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Updates a definition for an existing DNS server. Updates to address
        /// is the only change allowed. DNS server name cannot be changed
        /// </summary>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update DNS Server operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public async Task<OperationStatusResponse> BeginUpdatingDNSServerAsync(string serviceName, string deploymentName, string dnsServerName, DNSUpdateParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (serviceName == null)
            {
                throw new ArgumentNullException("serviceName");
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException("deploymentName");
            }
            if (dnsServerName == null)
            {
                throw new ArgumentNullException("dnsServerName");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serviceName", serviceName);
                tracingParameters.Add("deploymentName", deploymentName);
                tracingParameters.Add("dnsServerName", dnsServerName);
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "BeginUpdatingDNSServerAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/services/hostedservices/";
            url = url + Uri.EscapeDataString(serviceName);
            url = url + "/deployments/";
            url = url + Uri.EscapeDataString(deploymentName);
            url = url + "/dnsservers/";
            url = url + Uri.EscapeDataString(dnsServerName);
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Put;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2015-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                XDocument requestDoc = new XDocument();
                
                XElement dnsServerElement = new XElement(XName.Get("DnsServer", "http://schemas.microsoft.com/windowsazure"));
                requestDoc.Add(dnsServerElement);
                
                if (parameters.Name != null)
                {
                    XElement nameElement = new XElement(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                    nameElement.Value = parameters.Name;
                    dnsServerElement.Add(nameElement);
                }
                
                if (parameters.Address != null)
                {
                    XElement addressElement = new XElement(XName.Get("Address", "http://schemas.microsoft.com/windowsazure"));
                    addressElement.Value = parameters.Address;
                    dnsServerElement.Add(addressElement);
                }
                
                requestContent = requestDoc.ToString();
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/xml");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    OperationStatusResponse result = null;
                    // Deserialize Response
                    result = new OperationStatusResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deletes a definition for an existing DNS server from the deployment
        /// </summary>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public async Task<OperationStatusResponse> DeleteDNSServerAsync(string serviceName, string deploymentName, string dnsServerName, CancellationToken cancellationToken)
        {
            ComputeManagementClient client = this.Client;
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serviceName", serviceName);
                tracingParameters.Add("deploymentName", deploymentName);
                tracingParameters.Add("dnsServerName", dnsServerName);
                TracingAdapter.Enter(invocationId, this, "DeleteDNSServerAsync", tracingParameters);
            }
            
            cancellationToken.ThrowIfCancellationRequested();
            OperationStatusResponse response = await client.DnsServer.BeginDeletingDNSServerAsync(serviceName, deploymentName, dnsServerName, cancellationToken).ConfigureAwait(false);
            if (response.Status == OperationStatus.Succeeded)
            {
                return response;
            }
            cancellationToken.ThrowIfCancellationRequested();
            OperationStatusResponse result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
            int delayInSeconds = 30;
            if (client.LongRunningOperationInitialTimeout >= 0)
            {
                delayInSeconds = client.LongRunningOperationInitialTimeout;
            }
            while ((result.Status != OperationStatus.InProgress) == false)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await TaskEx.Delay(delayInSeconds * 1000, cancellationToken).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested();
                result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
                delayInSeconds = 30;
                if (client.LongRunningOperationRetryTimeout >= 0)
                {
                    delayInSeconds = client.LongRunningOperationRetryTimeout;
                }
            }
            
            if (shouldTrace)
            {
                TracingAdapter.Exit(invocationId, result);
            }
            
            if (result.Status != OperationStatus.Succeeded)
            {
                if (result.Error != null)
                {
                    CloudException ex = new CloudException(result.Error.Code + " : " + result.Error.Message);
                    ex.Error = new CloudError();
                    ex.Error.Code = result.Error.Code;
                    ex.Error.Message = result.Error.Message;
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
                else
                {
                    CloudException ex = new CloudException("");
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
            }
            
            return result;
        }
        
        /// <summary>
        /// Updates a definition for an existing DNS server. Updates to address
        /// is the only change allowed. DNS server name cannot be changed
        /// </summary>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='dnsServerName'>
        /// Required. The name of the dns server.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update DNS Server operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public async Task<OperationStatusResponse> UpdateDNSServerAsync(string serviceName, string deploymentName, string dnsServerName, DNSUpdateParameters parameters, CancellationToken cancellationToken)
        {
            ComputeManagementClient client = this.Client;
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serviceName", serviceName);
                tracingParameters.Add("deploymentName", deploymentName);
                tracingParameters.Add("dnsServerName", dnsServerName);
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "UpdateDNSServerAsync", tracingParameters);
            }
            
            cancellationToken.ThrowIfCancellationRequested();
            OperationStatusResponse response = await client.DnsServer.BeginUpdatingDNSServerAsync(serviceName, deploymentName, dnsServerName, parameters, cancellationToken).ConfigureAwait(false);
            if (response.Status == OperationStatus.Succeeded)
            {
                return response;
            }
            cancellationToken.ThrowIfCancellationRequested();
            OperationStatusResponse result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
            int delayInSeconds = 30;
            if (client.LongRunningOperationInitialTimeout >= 0)
            {
                delayInSeconds = client.LongRunningOperationInitialTimeout;
            }
            while ((result.Status != OperationStatus.InProgress) == false)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await TaskEx.Delay(delayInSeconds * 1000, cancellationToken).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested();
                result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
                delayInSeconds = 30;
                if (client.LongRunningOperationRetryTimeout >= 0)
                {
                    delayInSeconds = client.LongRunningOperationRetryTimeout;
                }
            }
            
            if (shouldTrace)
            {
                TracingAdapter.Exit(invocationId, result);
            }
            
            if (result.Status != OperationStatus.Succeeded)
            {
                if (result.Error != null)
                {
                    CloudException ex = new CloudException(result.Error.Code + " : " + result.Error.Message);
                    ex.Error = new CloudError();
                    ex.Error.Code = result.Error.Code;
                    ex.Error.Message = result.Error.Message;
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
                else
                {
                    CloudException ex = new CloudException("");
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
            }
            
            return result;
        }
    }
}
