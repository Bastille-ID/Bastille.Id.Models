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
    using System.Collections.Generic;

    /// <summary>
    /// This class contains model information for updating an organization user.
    /// </summary>
    public class GroupModel
    {
        /// <summary>
        /// Gets or sets the organization identity value of the user.
        /// </summary>
        public Guid GroupId { get; set; }

        /// <summary>
        /// Gets or sets the organization identifier.
        /// </summary>
        /// <value>The organization identifier.</value>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the parent group identifier.
        /// </summary>
        /// <value>The parent group identifier.</value>
        public Guid? ParentGroupId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the owner user identifier.
        /// </summary>
        /// <value>The owner user identifier.</value>
        public Guid? OwnerUserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GroupModel" /> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>The members.</value>
        public List<GroupUserModel> Members { get; set; } = new List<GroupUserModel>();
    }
}