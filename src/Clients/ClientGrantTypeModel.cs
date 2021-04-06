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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of Client Grant types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientGrantTypes
    {
        /// <summary>
        /// Client grants device flow.
        /// </summary>
        [EnumMember(Value = "urn:ietf:params:oauth:grant-type:device_code")]
        DeviceFlow,

        /// <summary>
        /// Client grants resource owner password flow.
        /// </summary>
        /// <remarks>For backwards compatibility. <see cref="ClientCredentials" /> or <see cref="AuthorizationCode" /> is recommended.</remarks>
        [EnumMember(Value = "password")]
        ResourceOwnerPassword,

        /// <summary>
        /// Client grants implicit flow.
        /// </summary>
        /// <remarks>For backwards compatibility. <see cref="ClientCredentials" /> or <see cref="AuthorizationCode" /> is recommended.</remarks>
        [EnumMember(Value = "implicit")]
        Implicit,

        /// <summary>
        /// Client grants hybrid flow.
        /// </summary>
        [EnumMember(Value = "hybrid")]
        Hybrid,

        /// <summary>
        /// Client grants client credentials.
        /// </summary>
        [EnumMember(Value = "client_credentials")]
        ClientCredentials,

        /// <summary>
        /// Client grants authorization code.
        /// </summary>
        [EnumMember(Value = "authorization_code")]
        AuthorizationCode,

        /// <summary>
        /// Client grants delegation flow.
        /// </summary>
        [EnumMember(Value = "delegation")]
        Delegation
    }

    /// <summary>
    /// This class represents a grant for a client.
    /// </summary>
    public class ClientGrantTypeModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>The client identifier.</value>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public ClientGrantTypes Type { get; set; } = ClientGrantTypes.ClientCredentials;
    }
}