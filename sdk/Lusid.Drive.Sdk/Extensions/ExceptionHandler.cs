/*
 * FINBOURNE Drive API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Lusid.Drive.Sdk.Client;

namespace Lusid.Drive.Sdk.Extensions
{
    /// <summary>
    /// Handles the generation of exceptions after receiving the ApiResponse
    /// </summary>
    internal static class ExceptionHandler
    {
        /// <summary>
        /// Generate exceptions from the ApiResponse when ResponseStatus is an Error,
        /// and StatusCode has no content or is less than 400
        /// </summary>
        /// <param name="methodName">The name of the method that was being called</param>
        /// <param name="response">The ApiResponse</param>
        public static Exception CustomExceptionFactory(string methodName, IApiResponse response)
        {
            // Use default exception handler first (only use subsequent checks if this returns null)
            Exception defaultException = Client.Configuration.DefaultExceptionFactory.Invoke(methodName, response);
            if (defaultException != null)
            {
                return defaultException;
            }

            // leaving this as an extension point for future.  The code we did have isn't required for HttpClient.
            return null;
        }
    }
}