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
    /// This class is the consent input view model.
    /// </summary>
    public class ConsentInputModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the user does consent to use.
        /// </summary>
        /// <value><c>true</c> if the user does consent; otherwise, <c>false</c>.</value>
        public bool DoesConsent { get; set; }

        /// <summary>
        /// Gets or sets the scopes that were consented.
        /// </summary>
        public IEnumerable<string> ScopesConsented { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether consent should be remembered.
        /// </summary>
        public bool RememberConsent { get; set; }

        /// <summary>
        /// Gets or sets the URL to redirect to after the consent action.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}