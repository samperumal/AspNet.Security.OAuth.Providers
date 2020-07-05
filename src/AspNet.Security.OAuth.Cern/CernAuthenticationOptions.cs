/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace AspNet.Security.OAuth.Cern
{
    /// <summary>
    /// Defines a set of options used by <see cref="CernAuthenticationHandler"/>.
    /// </summary>
    public class CernAuthenticationOptions : OAuthOptions
    {
        public CernAuthenticationOptions()
        {
            ClaimsIssuer = CernAuthenticationDefaults.Issuer;
            CallbackPath = CernAuthenticationDefaults.CallbackPath;
            AuthorizationEndpoint = CernAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = CernAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = CernAuthenticationDefaults.UserInformationEndpoint;

            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "cern_person_id");
            ClaimActions.MapJsonKey(ClaimTypes.PrimarySid, "cern_uid");
            ClaimActions.MapJsonKey(ClaimTypes.GroupSid, "cern_gid");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "name");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
            ClaimActions.MapJsonKey(ClaimTypes.GivenName, "given_name");
            ClaimActions.MapJsonKey(ClaimTypes.Surname, "family_name");
            ClaimActions.MapJsonKey(Claims.Sub, "sub");
            ClaimActions.MapJsonKey(Claims.PreferredUsername, "preferred_username");
            ClaimActions.MapJsonKey(Claims.Upn, "cern_upn");
            ClaimActions.MapJsonKey(Claims.PreferredLanguage, "cern_preferred_language");
            ClaimActions.MapJsonKey(Claims.PreferredUsername, "preferred_username");

            Scope.Add("identify");
        }
    }
}
