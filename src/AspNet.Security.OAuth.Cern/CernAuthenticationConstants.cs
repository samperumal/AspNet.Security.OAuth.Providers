/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

namespace AspNet.Security.OAuth.Cern
{
    /// <summary>
    /// Contains constants specific to the <see cref="CernAuthenticationHandler"/>.
    /// </summary>
    public static class CernAuthenticationConstants
    {
        public static class Claims
        {
            public const string Sub = "urn:cern:sub";
            public const string PreferredUsername = "urn:cern:preferred_username";
            public const string Upn = "urn:cern:cern_upn";
            public const string PreferredLanguage = "urn:cern:cern_preferred_language";
            public const string PreferredUsername = "urn:cern:preferred_username";

        }
    }
}
