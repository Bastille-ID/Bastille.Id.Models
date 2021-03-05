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

namespace Bastille.Id.Models.Logging
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of security event types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditEvent
    {
        /// <summary>
        /// Login event.
        /// </summary>
        Login,

        /// <summary>
        /// Logout event.
        /// </summary>
        Logout,

        /// <summary>
        /// Consent event.
        /// </summary>
        Consent,

        /// <summary>
        /// Validation event.
        /// </summary>
        Validation,

        /// <summary>
        /// Password update event.
        /// </summary>
        Password,

        /// <summary>
        /// Profile update event.
        /// </summary>
        Profile,

        /// <summary>
        /// A configuration update event.
        /// </summary>
        Config
    }

    /// <summary>
    /// Contains an enumerated list of security event results.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditResult
    {
        /// <summary>
        /// Successful event.
        /// </summary>
        Success,

        /// <summary>
        /// Unsuccessful event.
        /// </summary>
        Fail,

        /// <summary>
        /// Informational event.
        /// </summary>
        Info
    }
}