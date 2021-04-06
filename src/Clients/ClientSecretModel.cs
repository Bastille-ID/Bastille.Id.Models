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
    /// Contains an enumerated list of Client Secret types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientSecretTypes
    {
        /// <summary>
        /// JSON Web Key.
        /// </summary>
        [EnumMember(Value = "JWK")]
        JsonWebKey,

        /// <summary>
        /// Shared Secret hash.
        /// </summary>
        SharedSecret,

        /// <summary>
        /// X509 certificate base64 encoded.
        /// </summary>
        X509CertificateBase64,

        /// <summary>
        /// X509 Certificate by Name.
        /// </summary>
        [EnumMember(Value = "X509Name")]
        X509CertificateName,

        /// <summary>
        /// X509 Certificate by Thumbprint.
        /// </summary>
        [EnumMember(Value = "X509Thumbprint")]
        X509CertificateThumbprint
    }

    /// <summary>
    /// This class represnts a client secret model associated with a client.
    /// </summary>
    /// <seealso cref="IdentityServer4.Models.Secret" />
    public class ClientSecretModel : IdentityServer4.Models.Secret
    {
        /// <summary>
        /// Gets or sets the type of the client secret.
        /// </summary>
        /// <value>The type of the client secret.</value>
        public new ClientSecretTypes Type { get; set; } = ClientSecretTypes.SharedSecret;
    }
}