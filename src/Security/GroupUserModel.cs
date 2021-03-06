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

    /// <summary>
    /// This class contains model information for updating an organization user.
    /// </summary>
    public class GroupUserModel
    {
        /// <summary>
        /// Gets or sets the user identity value.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the group identity value of the user.
        /// </summary>
        public Guid GroupId { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the user last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <value>The picture.</value>
        public string Picture { get; set; }

        /// <summary>
        /// Gets the user's full name.
        /// </summary>
        public string FullName => $"{this.LastName}, {this.FirstName}";

        /// <summary>
        /// Gets or sets the last login date time for the user.
        /// </summary>
        public DateTime? LastLoginDate { get; set; }
    }
}