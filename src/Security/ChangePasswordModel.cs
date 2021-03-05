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
    using System.ComponentModel.DataAnnotations;
    using Bastille.Id.Models.Properties;

    /// <summary>
    /// This class is the password change view model.
    /// </summary>
    public class ChangePasswordModel
    {
        /// <summary>
        /// Gets or sets the old password.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = ResourceKeys.LabelChangePasswordText, ResourceType = typeof(Resources))]
        public string OldPassword { get; set; }

        /// <summary>
        /// Gets or sets the new password.
        /// </summary>
        [Required]
        [RegularExpression(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9 ])(?!.*\s).{8,20})", ErrorMessageResourceName = ResourceKeys.PromptPasswordRequirementsText, ErrorMessageResourceType = typeof(Resources))]
        [DataType(DataType.Password)]
        [Display(Name = ResourceKeys.LabelNewPasswordText, ResourceType = typeof(Resources))]
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or sets the password confirmation.
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = ResourceKeys.LabelConfirmPasswordText, ResourceType = typeof(Resources))]
        [Compare(nameof(NewPassword), ErrorMessageResourceName = ResourceKeys.PromptNewAndConfirmPasswordMustMatchText, ErrorMessageResourceType = typeof(Resources))]
        public string ConfirmPassword { get; set; }
    }
}