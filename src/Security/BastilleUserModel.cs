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
    using Talegen.Common.Models.Security;

    /// <summary>
    /// This class represents a user within the server API controller.
    /// </summary>
    public class BastilleUserModel : UserModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the e-mail address is confirmed.
        /// </summary>
        public bool IsEmailConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the user's organization model.
        /// </summary>
        public List<GroupModel> Groups { get; set; } = new List<GroupModel>();

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>The phone.</value>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the user's password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <value>The picture.</value>
        public string Picture { get; set; }

        /// <summary>
        /// Gets or sets the user's lockout end date.
        /// </summary>
        public DateTimeOffset? LockoutEnd { get; set; }

        /// <summary>
        /// Gets or sets the user's lockout days.
        /// </summary>
        public int? LockoutDays { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BastilleUserModel" /> is administrator.
        /// </summary>
        /// <value><c>true</c> if administrator; otherwise, <c>false</c>.</value>
        public bool Administrator { get; set; }
    }
}