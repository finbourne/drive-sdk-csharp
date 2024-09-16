/*
 * FINBOURNE Drive API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Polly;
using RestSharp;

namespace Lusid.Drive.Sdk.Client
{
    /// <summary>
    /// Configuration class to set the polly retry policies to be applied to the requests.
    /// </summary>
    public static class RetryConfiguration
    {
        /// <summary>
        /// Function to return a retry policy for synchronous calls - this will only be used if RetryPolicy is null
        /// </summary>
        public static Func<RequestOptions, Policy<RestResponse>>? GetRetryPolicyFunc { get; set; }

        /// <summary>
        /// Function to return a retry policy for asynchronous calls - this will only be used if AsyncRetryPolicy is null
        /// </summary>
        public static Func<RequestOptions, AsyncPolicy<RestResponse>>? GetAsyncRetryPolicyFunc { get; set; }
        
        /// <summary>
        /// Retry policy - if set will be used over any policy returned from GetRetryPolicyFunc
        /// </summary>
        public static Policy<RestResponse>? RetryPolicy { get; set; }

        /// <summary>
        /// Async retry policy - if set will be used over any policy returned from GetAsyncRetryPolicyFunc
        /// </summary>
        public static AsyncPolicy<RestResponse>? AsyncRetryPolicy { get; set; }
    }
}
