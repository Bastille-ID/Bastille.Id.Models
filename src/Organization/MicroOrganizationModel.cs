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

namespace Bastille.Id.Models.Organization
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This model represents the minimal information for a user.
    /// </summary>
    public class MicroOrganizationModel
    {
        /// <summary>
        /// Gets or sets the user's organization identity.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the user's organization name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}