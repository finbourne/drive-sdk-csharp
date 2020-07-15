﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Lusid.Drive.Sdk.Client;

namespace Lusid.Drive.Sdk.Utilities
{
    /// <summary>
    /// Factory to provide instances of the autogenerated LusidApi
    /// </summary>
    public interface ILusidApiFactory
    {
        /// <summary>
        /// Return the specific autogenerated Api
        /// </summary>
        TApi Api<TApi>() where TApi : class;
    }

    /// <inheritdoc />
    public class LusidApiFactory : ILusidApiFactory
    {
        private Dictionary<Type, IApiAccessor> _apis;

        /// <summary>
        /// Create a new factory using the specified configuration
        /// </summary>
        public LusidApiFactory(ApiConfiguration apiConfiguration)
        {
            if (apiConfiguration == null) throw new ArgumentNullException(nameof(apiConfiguration));

            // Validate Uris
            if (!Uri.TryCreate(apiConfiguration.TokenUrl, UriKind.Absolute, out var _))
            {
                throw new UriFormatException($"Invalid Token Uri: {apiConfiguration.TokenUrl}");
            }

            if (!Uri.TryCreate(apiConfiguration.ApiUrl, UriKind.Absolute, out var _))
            {
                throw new UriFormatException($"Invalid LUSID Uri: {apiConfiguration.ApiUrl}");
            }

            // Create configuration
            var tokenProvider = new ClientCredentialsFlowTokenProvider(apiConfiguration);
            var configuration = new TokenProviderConfiguration(tokenProvider)
            {
                BasePath = apiConfiguration.ApiUrl,
            };
            
            configuration.AddDefaultHeader("X-LUSID-Application", apiConfiguration.ApplicationName);

            Init(configuration);
        }

        /// <summary>
        /// Create a new factory using the specified configuration
        /// </summary>
        public LusidApiFactory(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            Init(configuration);
        }

        private void Init(Configuration configuration)
        {   
            IEnumerable<Type> apis = Assembly.GetAssembly(typeof(ApiClient))
                .GetTypes()
                .Where(t => typeof(IApiAccessor).IsAssignableFrom(t) && t.IsClass);

            _apis = new Dictionary<Type, IApiAccessor>();
            foreach (var api in apis)
            {
                if (!(Activator.CreateInstance(api, configuration) is IApiAccessor impl))
                {
                    throw new Exception($"Unable to create type {api}");
                }

                var @interface = api.GetInterfaces()
                    .First(i => typeof(IApiAccessor).IsAssignableFrom(i));

                _apis[api] = impl;
                _apis[@interface] = impl;
            }
        }

        /// <inheritdoc />
        public TApi Api<TApi>() where TApi : class
        {
            _apis.TryGetValue(typeof(TApi), out var api);

            if (api == null)
            {
                throw new InvalidOperationException($"Unable to find api: {typeof(TApi)}");
            }
            return api as TApi;
        }
    }
}