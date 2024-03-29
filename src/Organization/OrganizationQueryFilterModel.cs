﻿/*
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
    using Talegen.Common.Models.Server.Queries;

    /// <summary>
    /// This class represents an organization browsing query filter.
    /// </summary>
    /// <seealso cref="Talegen.Common.Models.Server.Queries.PaginatedQueryRequestModel" />
    public class OrganizationQueryFilterModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        /// <value>The search text.</value>
        public string Search { get; set; }
    }
}