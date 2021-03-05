/*
 * Bastille.ID Identity Server
 * (c) Copyright Talegen, LLC.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

namespace Bastille.Id.Models.Clients
{
    using IdentityServer4.Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents a model related to a client.
    /// </summary>
    public class ClientModel : IdentityServer4.Models.Client
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientModel" /> class.
        /// </summary>
        public ClientModel()
        {
            this.AbsoluteRefreshTokenLifetime = 2592000;
            this.AccessTokenLifetime = 3600;
            this.AccessTokenType = AccessTokenType.Jwt;
            this.AllowAccessTokensViaBrowser = true;
            this.AuthorizationCodeLifetime = 300;
            this.BackChannelLogoutSessionRequired = true;
            this.Enabled = true;
            this.EnableLocalLogin = true;
            this.FrontChannelLogoutSessionRequired = true;
            this.IdentityTokenLifetime = 300;
            this.ProtocolType = "oidc";
            this.RefreshTokenExpiration = TokenExpiration.Absolute;
            this.RefreshTokenUsage = TokenUsage.OneTimeOnly;
            this.RequireClientSecret = true;
            this.RequireConsent = true;
            this.SlidingRefreshTokenLifetime = 1296000;
        }

        /// <summary>
        /// Unique ID of the client
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the access token type value.
        /// </summary>
        /// <value>The access token type value.</value>
        [JsonIgnore]
        public int AccessTokenTypeValue
        {
            get
            {
                return (int)this.AccessTokenType;
            }

            set
            {
                this.AccessTokenType = (AccessTokenType)value;
            }
        }

        /// <summary>
        /// Gets or sets the refresh token expiration value.
        /// </summary>
        /// <value>The refresh token expiration value.</value>
        [JsonIgnore]
        public int RefreshTokenExpirationValue
        {
            get
            {
                return (int)this.RefreshTokenExpiration;
            }

            set
            {
                this.RefreshTokenExpiration = (TokenExpiration)value;
            }
        }

        /// <summary>
        /// Gets or sets the refresh token usage value.
        /// </summary>
        /// <value>The refresh token usage value.</value>
        [JsonIgnore]
        public int RefreshTokenUsageValue
        {
            get
            {
                return (int)this.RefreshTokenUsage;
            }

            set
            {
                this.RefreshTokenUsage = (TokenUsage)value;
            }
        }
    }
}