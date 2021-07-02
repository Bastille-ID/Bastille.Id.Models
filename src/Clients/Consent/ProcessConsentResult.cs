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
    using System;

    /// <summary>
    /// This class is the process consent result model.
    /// </summary>
    public class ProcessConsentResult
    {
        /// <summary>
        /// Gets a value indicating whether the browser is to redirect.
        /// </summary>
        public bool IsRedirect => this.RedirectUri != null;

        /// <summary>
        /// Gets or sets the URL that shall be redirected to after consent action.
        /// </summary>
        public Uri RedirectUri { get; set; }

        /// <summary>
        /// Gets a value indicating whether the consent info should be shown.
        /// </summary>
        public bool ShowView => this.ViewModel != null;

        /// <summary>
        /// Gets or sets the consent view model.
        /// </summary>
        public ConsentViewModel ViewModel { get; set; }

        /// <summary>
        /// Gets a value indicating whether there was a validation error.
        /// </summary>
        public bool HasValidationError => this.ValidationError != null;

        /// <summary>
        /// Gets or sets a validation error message.
        /// </summary>
        public string ValidationError { get; set; }
    }
}