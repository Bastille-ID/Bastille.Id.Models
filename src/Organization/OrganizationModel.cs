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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Bastille.Id.Models.Security;

    /// <summary>
    /// This class represents a complete organization detail.
    /// </summary>
    /// <seealso cref="Bastille.Id.Models.Organization.MicroOrganizationModel" />
    public class OrganizationModel : MicroOrganizationModel
    {
        /// <summary>
        /// Gets or sets the slug.
        /// </summary>
        /// <value>The slug.</value>
        [Required]
        [MaxLength(150)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [MaxLength(500)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the owner user identifier.
        /// </summary>
        /// <value>The owner user identifier.</value>
        public BastilleMicroUserModel Owner { get; set; }

        /// <summary>
        /// Gets or sets the address1.
        /// </summary>
        /// <value>The address1.</value>
        [MaxLength(200)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address2.
        /// </summary>
        /// <value>The address2.</value>
        [MaxLength(200)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        [MaxLength(200)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>The region.</value>
        [MaxLength(200)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        [MaxLength(50)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        [MaxLength(100)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets a date time value when the entity was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets a date time value when a user account is updated.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Organization" /> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the organization groups.
        /// </summary>
        /// <value>The groups.</value>
        public List<GroupModel> Groups { get; set; } = new List<GroupModel>();
    }
}