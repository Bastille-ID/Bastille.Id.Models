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
    using System.ComponentModel.DataAnnotations;
    using Bastille.Id.Models.Organization;
    using IdentityModel;
    using Newtonsoft.Json;
    using Talegen.Common.Core.Extensions;
    using Talegen.Common.Models.Contacts;
    using Talegen.Common.Models.Extensions;

    /// <summary>
    /// This class represents the profile claims and information supported by the server for a user account.
    /// </summary>
    public class ProfileModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileModel" /> class.
        /// </summary>
        public ProfileModel()
        {
            this.Claims = new Dictionary<string, string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileModel" /> class.
        /// </summary>
        /// <param name="claims">Contains a default set of claims.</param>
        public ProfileModel(Dictionary<string, string> claims)
        {
            this.Claims = claims;
        }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public string UserId
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.Subject) ? this.Claims[JwtClaimTypes.Subject] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.Subject))
                {
                    this.Claims[JwtClaimTypes.Subject] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.Subject, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.Name) ? this.Claims[JwtClaimTypes.Name] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.Name))
                {
                    this.Claims[JwtClaimTypes.Name] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.Name, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.PreferredUserName) ? this.Claims[JwtClaimTypes.PreferredUserName] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.PreferredUserName))
                {
                    this.Claims[JwtClaimTypes.PreferredUserName] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.PreferredUserName, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets e-mail address.
        /// </summary>
        [EmailAddress]
        public string Email
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.Email) ? this.Claims[JwtClaimTypes.Email] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.Email))
                {
                    this.Claims[JwtClaimTypes.Email] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.Email, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the e-mail address is confirmed.
        /// </summary>
        public bool IsEmailConfirmed
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.EmailVerified) ? this.Claims[JwtClaimTypes.EmailVerified].ToBoolean() : false;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.EmailVerified))
                {
                    this.Claims[JwtClaimTypes.EmailVerified] = value.ToString();
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.EmailVerified, value.ToString());
                }
            }
        }

        /// <summary>
        /// Gets or sets the user phone number.
        /// </summary>
        [Phone]
        public string PhoneNumber
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.PhoneNumber) ? this.Claims[JwtClaimTypes.PhoneNumber] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.PhoneNumber))
                {
                    this.Claims[JwtClaimTypes.PhoneNumber] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.PhoneNumber, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the user phone number.
        /// </summary>
        [Phone]
        public string Mobile
        {
            get
            {
                return this.Claims.ContainsKey(BastilleClaimTypes.Mobile) ? this.Claims[BastilleClaimTypes.Mobile] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(BastilleClaimTypes.Mobile))
                {
                    this.Claims[BastilleClaimTypes.Mobile] = value;
                }
                else
                {
                    this.Claims.Add(BastilleClaimTypes.Mobile, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets a lock out end date time.
        /// </summary>
        public DateTime? LockoutEnd { get; set; }

        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.GivenName) ? this.Claims[JwtClaimTypes.GivenName] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.GivenName))
                {
                    this.Claims[JwtClaimTypes.GivenName] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.GivenName, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the user's last name.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.FamilyName) ? this.Claims[JwtClaimTypes.FamilyName] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.FamilyName))
                {
                    this.Claims[JwtClaimTypes.FamilyName] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.FamilyName, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the user's middle name.
        /// </summary>
        public string MiddleName
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.MiddleName) ? this.Claims[JwtClaimTypes.MiddleName] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.MiddleName))
                {
                    this.Claims[JwtClaimTypes.MiddleName] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.MiddleName, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the user's nick name.
        /// </summary>
        public string NickName
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.NickName) ? this.Claims[JwtClaimTypes.NickName] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.NickName))
                {
                    this.Claims[JwtClaimTypes.NickName] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.NickName, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the web site.
        /// </summary>
        [Url]
        public string Website
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.WebSite) ? this.Claims[JwtClaimTypes.WebSite] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.WebSite))
                {
                    this.Claims[JwtClaimTypes.WebSite] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.WebSite, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the URL to the user's profile picture.
        /// </summary>
        public string PictureUrl
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.Picture) ? this.Claims[JwtClaimTypes.Picture] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.Picture))
                {
                    this.Claims[JwtClaimTypes.Picture] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.Picture, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the user's time zone.
        /// </summary>
        public string TimeZone
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.ZoneInfo) ? this.Claims[JwtClaimTypes.ZoneInfo] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.ZoneInfo))
                {
                    this.Claims[JwtClaimTypes.ZoneInfo] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.ZoneInfo, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the user's preferred locale.
        /// </summary>
        public string Locale
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.Locale) ? this.Claims[JwtClaimTypes.Locale] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.Locale))
                {
                    this.Claims[JwtClaimTypes.Locale] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.Locale, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the user's preferred locale.
        /// </summary>
        public DateTime? Birthday
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.BirthDate) ? this.Claims[JwtClaimTypes.BirthDate].ToDateTime() as DateTime? : null;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.BirthDate))
                {
                    this.Claims[JwtClaimTypes.BirthDate] = value.HasValue ? value.Value.ToString("yyyy-dd-MM") : null;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.BirthDate, value.HasValue ? value.Value.ToString("yyyy-dd-MM") : null);
                }
            }
        }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>The gender.</value>
        public string Gender
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.Gender) ? this.Claims[JwtClaimTypes.Gender] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.Gender))
                {
                    this.Claims[JwtClaimTypes.Gender] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.Gender, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        /// <value>The website.</value>
        public string WebSite
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.WebSite) ? this.Claims[JwtClaimTypes.WebSite] : string.Empty;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.WebSite))
                {
                    this.Claims[JwtClaimTypes.WebSite] = value;
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.WebSite, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        /// <value>The website.</value>
        public Address Address
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.Address) ? this.Claims[JwtClaimTypes.Address].ToAddress() : null;
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.Address))
                {
                    this.Claims[JwtClaimTypes.Address] = value.ToClaimFormat();
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.Address, value.ToClaimFormat());
                }
            }
        }

        /// <summary>
        /// Gets or sets the user's preferred locale.
        /// </summary>
        public List<string> Roles
        {
            get
            {
                return this.Claims.ContainsKey(JwtClaimTypes.Role) ? JsonConvert.DeserializeObject<List<string>>(this.Claims[JwtClaimTypes.Role]) : new List<string>();
            }

            set
            {
                if (this.Claims.ContainsKey(JwtClaimTypes.Role))
                {
                    this.Claims[JwtClaimTypes.Role] = JsonConvert.SerializeObject(value);
                }
                else
                {
                    this.Claims.Add(JwtClaimTypes.Role, JsonConvert.SerializeObject(value));
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether two factor is enabled.
        /// </summary>
        public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether passwordless authentication is enabled.
        /// </summary>
        public bool PasswordlessAuthenticationEnabled { get; set; }

        /// <summary>
        /// Gets or sets the organizations.
        /// </summary>
        /// <value>The organizations.</value>
        public List<MicroOrganizationModel> Organizations { get; set; } = new List<MicroOrganizationModel>();

        /// <summary>
        /// Gets or sets the groups.
        /// </summary>
        /// <value>The groups.</value>
        public List<MinimalGroupModel> Groups { get; set; } = new List<MinimalGroupModel>();

        /// <summary>
        /// Gets or sets the claims list
        /// </summary>
        public Dictionary<string, string> Claims { get; set; }
    }
}