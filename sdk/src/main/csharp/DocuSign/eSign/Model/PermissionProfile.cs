/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// PermissionProfile
    /// </summary>
    [DataContract]
    public partial class PermissionProfile :  IEquatable<PermissionProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionProfile" /> class.
        /// </summary>
        /// <param name="ModifiedByUsername">.</param>
        /// <param name="ModifiedDateTime">.</param>
        /// <param name="PermissionProfileId">.</param>
        /// <param name="PermissionProfileName">.</param>
        /// <param name="Settings">Settings.</param>
        /// <param name="UserCount">.</param>
        /// <param name="Users">.</param>
        public PermissionProfile(string ModifiedByUsername = default(string), string ModifiedDateTime = default(string), string PermissionProfileId = default(string), string PermissionProfileName = default(string), AccountRoleSettings Settings = default(AccountRoleSettings), string UserCount = default(string), List<UserInformation> Users = default(List<UserInformation>))
        {
            this.ModifiedByUsername = ModifiedByUsername;
            this.ModifiedDateTime = ModifiedDateTime;
            this.PermissionProfileId = PermissionProfileId;
            this.PermissionProfileName = PermissionProfileName;
            this.Settings = Settings;
            this.UserCount = UserCount;
            this.Users = Users;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="modifiedByUsername", EmitDefaultValue=false)]
        public string ModifiedByUsername { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="modifiedDateTime", EmitDefaultValue=false)]
        public string ModifiedDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="permissionProfileId", EmitDefaultValue=false)]
        public string PermissionProfileId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="permissionProfileName", EmitDefaultValue=false)]
        public string PermissionProfileName { get; set; }
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public AccountRoleSettings Settings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="userCount", EmitDefaultValue=false)]
        public string UserCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<UserInformation> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionProfile {\n");
            sb.Append("  ModifiedByUsername: ").Append(ModifiedByUsername).Append("\n");
            sb.Append("  ModifiedDateTime: ").Append(ModifiedDateTime).Append("\n");
            sb.Append("  PermissionProfileId: ").Append(PermissionProfileId).Append("\n");
            sb.Append("  PermissionProfileName: ").Append(PermissionProfileName).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PermissionProfile);
        }

        /// <summary>
        /// Returns true if PermissionProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of PermissionProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionProfile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ModifiedByUsername == other.ModifiedByUsername ||
                    this.ModifiedByUsername != null &&
                    this.ModifiedByUsername.Equals(other.ModifiedByUsername)
                ) && 
                (
                    this.ModifiedDateTime == other.ModifiedDateTime ||
                    this.ModifiedDateTime != null &&
                    this.ModifiedDateTime.Equals(other.ModifiedDateTime)
                ) && 
                (
                    this.PermissionProfileId == other.PermissionProfileId ||
                    this.PermissionProfileId != null &&
                    this.PermissionProfileId.Equals(other.PermissionProfileId)
                ) && 
                (
                    this.PermissionProfileName == other.PermissionProfileName ||
                    this.PermissionProfileName != null &&
                    this.PermissionProfileName.Equals(other.PermissionProfileName)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.UserCount == other.UserCount ||
                    this.UserCount != null &&
                    this.UserCount.Equals(other.UserCount)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ModifiedByUsername != null)
                    hash = hash * 59 + this.ModifiedByUsername.GetHashCode();
                if (this.ModifiedDateTime != null)
                    hash = hash * 59 + this.ModifiedDateTime.GetHashCode();
                if (this.PermissionProfileId != null)
                    hash = hash * 59 + this.PermissionProfileId.GetHashCode();
                if (this.PermissionProfileName != null)
                    hash = hash * 59 + this.PermissionProfileName.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                if (this.UserCount != null)
                    hash = hash * 59 + this.UserCount.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
