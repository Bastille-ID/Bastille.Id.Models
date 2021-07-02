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

namespace Bastille.Id.Models.Clients.Consent
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is the consent page view model.
    /// </summary>
    public class ConsentViewModel : ConsentInputModel
    {
        /// <summary>
        /// Gets or sets the client name.
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the client URL.
        /// </summary>
        public string ClientUrl { get; set; }

        /// <summary>
        /// Gets or sets the client Logo URL.
        /// </summary>
        public string ClientLogoUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the ability to remember consent is allowed.
        /// </summary>
        public bool AllowRememberConsent { get; set; }

        /// <summary>
        /// Gets or sets an enumerable list of scopes the identity requests.
        /// </summary>
        public IEnumerable<ScopeViewModel> IdentityScopes { get; set; }

        /// <summary>
        /// Gets or sets an enumerable list of scopes the resource requests.
        /// </summary>
        public IEnumerable<ScopeViewModel> ApiScopes { get; set; }
    }
}