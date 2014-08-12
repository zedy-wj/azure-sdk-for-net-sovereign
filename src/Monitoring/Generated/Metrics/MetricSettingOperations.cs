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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Monitoring.Metrics;
using Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.WindowsAzure.Management.Monitoring.Metrics
{
    internal partial class MetricSettingOperations : IServiceOperations<MetricsClient>, Microsoft.WindowsAzure.Management.Monitoring.Metrics.IMetricSettingOperations
    {
        /// <summary>
        /// Initializes a new instance of the MetricSettingOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal MetricSettingOperations(MetricsClient client)
        {
            this._client = client;
        }
        
        private MetricsClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Metrics.MetricsClient.
        /// </summary>
        public MetricsClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// The Put Metric Settings operation creates or updates the metric
        /// settings for the resource.
        /// </summary>
        /// <param name='parameters'>
        /// Required. Metric settings to be created or updated.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async System.Threading.Tasks.Task<OperationResponse> CreateOrUpdateAsync(MetricSettingsPutParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.MetricSetting == null)
            {
                throw new ArgumentNullException("parameters.MetricSetting");
            }
            if (parameters.MetricSetting.ResourceId == null)
            {
                throw new ArgumentNullException("parameters.MetricSetting.ResourceId");
            }
            if (parameters.MetricSetting.Value == null)
            {
                throw new ArgumentNullException("parameters.MetricSetting.Value");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("parameters", parameters);
                Tracing.Enter(invocationId, this, "CreateOrUpdateAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/services/monitoring/metricsettings";
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
                httpRequest.Headers.Add("Accept", "application/json");
                httpRequest.Headers.Add("x-ms-version", "2013-10-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                requestDoc = new JObject();
                requestDoc["ResourceId"] = parameters.MetricSetting.ResourceId;
                
                if (parameters.MetricSetting.Namespace != null)
                {
                    requestDoc["Namespace"] = parameters.MetricSetting.Namespace;
                }
                
                JObject valueValue = new JObject();
                requestDoc["Value"] = valueValue;
                if (parameters.MetricSetting.Value is AvailabilityMetricSettingValue)
                {
                    valueValue["odata.type"] = parameters.MetricSetting.Value.GetType().FullName;
                    AvailabilityMetricSettingValue derived = ((AvailabilityMetricSettingValue)parameters.MetricSetting.Value);
                    
                    if (derived.AvailableLocations != null)
                    {
                        JArray availableLocationsArray = new JArray();
                        foreach (NameConfig availableLocationsItem in derived.AvailableLocations)
                        {
                            JObject nameConfigValue = new JObject();
                            availableLocationsArray.Add(nameConfigValue);
                            
                            if (availableLocationsItem.Name != null)
                            {
                                nameConfigValue["Name"] = availableLocationsItem.Name;
                            }
                            
                            if (availableLocationsItem.DisplayName != null)
                            {
                                nameConfigValue["DisplayName"] = availableLocationsItem.DisplayName;
                            }
                        }
                        valueValue["AvailableLocations"] = availableLocationsArray;
                    }
                    
                    if (derived.Endpoints != null)
                    {
                        JArray endpointsArray = new JArray();
                        foreach (EndpointConfig endpointsItem in derived.Endpoints)
                        {
                            JObject endpointConfigValue = new JObject();
                            endpointsArray.Add(endpointConfigValue);
                            
                            if (endpointsItem.ConfigId != null)
                            {
                                endpointConfigValue["ConfigId"] = endpointsItem.ConfigId;
                            }
                            
                            if (endpointsItem.Name != null)
                            {
                                endpointConfigValue["Name"] = endpointsItem.Name;
                            }
                            
                            if (endpointsItem.Location != null)
                            {
                                endpointConfigValue["Location"] = endpointsItem.Location;
                            }
                            
                            if (endpointsItem.Url != null)
                            {
                                endpointConfigValue["Url"] = endpointsItem.Url.AbsoluteUri;
                            }
                        }
                        valueValue["Endpoints"] = endpointsArray;
                    }
                }
                
                requestContent = requestDoc.ToString(Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                httpRequest.Content.Headers.ContentType.CharSet = "utf-8";
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    OperationResponse result = null;
                    result = new OperationResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
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
        /// The List Metric Settings operation lists the metric settings for
        /// the resource.
        /// </summary>
        /// <param name='resourceId'>
        /// Required. The id of the resource.
        /// </param>
        /// <param name='metricNamespace'>
        /// Required. The namespace of the metrics.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list metric settings operation response.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models.MetricSettingListResponse> ListAsync(string resourceId, string metricNamespace, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceId == null)
            {
                throw new ArgumentNullException("resourceId");
            }
            if (metricNamespace == null)
            {
                throw new ArgumentNullException("metricNamespace");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceId", resourceId);
                tracingParameters.Add("metricNamespace", metricNamespace);
                Tracing.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/services/monitoring/metricsettings?";
            url = url + "&resourceId=" + Uri.EscapeDataString(resourceId.Trim());
            url = url + "&namespace=" + Uri.EscapeDataString(metricNamespace.Trim());
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
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                httpRequest.Headers.Add("x-ms-version", "2013-10-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    MetricSettingListResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new MetricSettingListResponse();
                    JToken responseDoc = null;
                    if (string.IsNullOrEmpty(responseContent) == false)
                    {
                        responseDoc = JToken.Parse(responseContent);
                    }
                    
                    if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                    {
                        MetricSettingCollection metricSettingCollectionInstance = new MetricSettingCollection();
                        result.MetricSettingCollection = metricSettingCollectionInstance;
                        
                        JToken valueArray = responseDoc["Value"];
                        if (valueArray != null && valueArray.Type != JTokenType.Null)
                        {
                            foreach (JToken valueValue in ((JArray)valueArray))
                            {
                                MetricSetting metricSettingInstance = new MetricSetting();
                                metricSettingCollectionInstance.Value.Add(metricSettingInstance);
                                
                                JToken resourceIdValue = valueValue["ResourceId"];
                                if (resourceIdValue != null && resourceIdValue.Type != JTokenType.Null)
                                {
                                    string resourceIdInstance = ((string)resourceIdValue);
                                    metricSettingInstance.ResourceId = resourceIdInstance;
                                }
                                
                                JToken namespaceValue = valueValue["Namespace"];
                                if (namespaceValue != null && namespaceValue.Type != JTokenType.Null)
                                {
                                    string namespaceInstance = ((string)namespaceValue);
                                    metricSettingInstance.Namespace = namespaceInstance;
                                }
                                
                                JToken valueValue2 = valueValue["Value"];
                                if (valueValue2 != null && valueValue2.Type != JTokenType.Null)
                                {
                                    string typeName = ((string)valueValue2["odata.type"]);
                                    if (typeName == "Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models.AvailabilityMetricSettingValue")
                                    {
                                        AvailabilityMetricSettingValue availabilityMetricSettingValueInstance = new AvailabilityMetricSettingValue();
                                        
                                        JToken availableLocationsArray = valueValue2["AvailableLocations"];
                                        if (availableLocationsArray != null && availableLocationsArray.Type != JTokenType.Null)
                                        {
                                            foreach (JToken availableLocationsValue in ((JArray)availableLocationsArray))
                                            {
                                                NameConfig nameConfigInstance = new NameConfig();
                                                availabilityMetricSettingValueInstance.AvailableLocations.Add(nameConfigInstance);
                                                
                                                JToken nameValue = availableLocationsValue["Name"];
                                                if (nameValue != null && nameValue.Type != JTokenType.Null)
                                                {
                                                    string nameInstance = ((string)nameValue);
                                                    nameConfigInstance.Name = nameInstance;
                                                }
                                                
                                                JToken displayNameValue = availableLocationsValue["DisplayName"];
                                                if (displayNameValue != null && displayNameValue.Type != JTokenType.Null)
                                                {
                                                    string displayNameInstance = ((string)displayNameValue);
                                                    nameConfigInstance.DisplayName = displayNameInstance;
                                                }
                                            }
                                        }
                                        
                                        JToken endpointsArray = valueValue2["Endpoints"];
                                        if (endpointsArray != null && endpointsArray.Type != JTokenType.Null)
                                        {
                                            foreach (JToken endpointsValue in ((JArray)endpointsArray))
                                            {
                                                EndpointConfig endpointConfigInstance = new EndpointConfig();
                                                availabilityMetricSettingValueInstance.Endpoints.Add(endpointConfigInstance);
                                                
                                                JToken configIdValue = endpointsValue["ConfigId"];
                                                if (configIdValue != null && configIdValue.Type != JTokenType.Null)
                                                {
                                                    string configIdInstance = ((string)configIdValue);
                                                    endpointConfigInstance.ConfigId = configIdInstance;
                                                }
                                                
                                                JToken nameValue2 = endpointsValue["Name"];
                                                if (nameValue2 != null && nameValue2.Type != JTokenType.Null)
                                                {
                                                    string nameInstance2 = ((string)nameValue2);
                                                    endpointConfigInstance.Name = nameInstance2;
                                                }
                                                
                                                JToken locationValue = endpointsValue["Location"];
                                                if (locationValue != null && locationValue.Type != JTokenType.Null)
                                                {
                                                    string locationInstance = ((string)locationValue);
                                                    endpointConfigInstance.Location = locationInstance;
                                                }
                                                
                                                JToken urlValue = endpointsValue["Url"];
                                                if (urlValue != null && urlValue.Type != JTokenType.Null)
                                                {
                                                    Uri urlInstance = TypeConversion.TryParseUri(((string)urlValue));
                                                    endpointConfigInstance.Url = urlInstance;
                                                }
                                            }
                                        }
                                        metricSettingInstance.Value = availabilityMetricSettingValueInstance;
                                    }
                                }
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
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
    }
}
