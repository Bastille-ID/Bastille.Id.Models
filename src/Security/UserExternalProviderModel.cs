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

namespace Bastille.Id.Models.Security
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// This class represents an external provider.
    /// </summary>
    public class UserExternalProviderModel : ExternalProviderModel
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the user email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets a value indicating whether [bound to user].
        /// </summary>
        public bool BoundToUser { get; set; } ///this.UserLogin?.LoginProvider.Equals(this.AuthenticationScheme, StringComparison.InvariantCultureIgnoreCase) ?? false;

                                              /// <summary>
                                              /// Gets the provider key.
                                              /// </summary>
        public string ProviderKey { get; set; } ///this.UserLogin?.ProviderKey ?? string.Empty;

                                                /// <summary>
                                                /// Gets or sets the return URL.
                                                /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or sets the status message.
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Gets or sets the type of the status.
        /// </summary>
        [XmlIgnore]
        public StatusMessageResultType StatusType { get; set; }
    }
}