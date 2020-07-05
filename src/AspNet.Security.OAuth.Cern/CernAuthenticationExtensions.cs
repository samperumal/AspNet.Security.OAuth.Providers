/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System;
using AspNet.Security.OAuth.Cern;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods to add Cern authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class CernAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="CernAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Cern authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddCern([NotNull] this AuthenticationBuilder builder)
        {
            return builder.AddCern(CernAuthenticationDefaults.AuthenticationScheme, options => { });
        }

        /// <summary>
        /// Adds <see cref="CernAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Cern authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the OpenID 2.0 options.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddCern(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] Action<CernAuthenticationOptions> configuration)
        {
            return builder.AddCern(CernAuthenticationDefaults.AuthenticationScheme, configuration);
        }

        /// <summary>
        /// Adds <see cref="CernAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Cern authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Cern options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddCern(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [NotNull] Action<CernAuthenticationOptions> configuration)
        {
            return builder.AddCern(scheme, CernAuthenticationDefaults.DisplayName, configuration);
        }

        /// <summary>
        /// Adds <see cref="CernAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Cern authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="caption">The optional display name associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Cern options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddCern(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [CanBeNull] string caption,
            [NotNull] Action<CernAuthenticationOptions> configuration)
        {
            return builder.AddOAuth<CernAuthenticationOptions, CernAuthenticationHandler>(scheme, caption, configuration);
        }
    }
}
