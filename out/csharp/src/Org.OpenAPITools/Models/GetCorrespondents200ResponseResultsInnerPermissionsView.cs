/*
 * Paperless Rest Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Org.OpenAPITools.Converters;

namespace Org.OpenAPITools.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class GetCorrespondents200ResponseResultsInnerPermissionsView : IEquatable<GetCorrespondents200ResponseResultsInnerPermissionsView>
    {
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [Required]
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<Object> Users { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [Required]
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<Object> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorrespondents200ResponseResultsInnerPermissionsView {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((GetCorrespondents200ResponseResultsInnerPermissionsView)obj);
        }

        /// <summary>
        /// Returns true if GetCorrespondents200ResponseResultsInnerPermissionsView instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCorrespondents200ResponseResultsInnerPermissionsView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorrespondents200ResponseResultsInnerPermissionsView other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Users == other.Users ||
                    Users != null &&
                    other.Users != null &&
                    Users.SequenceEqual(other.Users)
                ) && 
                (
                    Groups == other.Groups ||
                    Groups != null &&
                    other.Groups != null &&
                    Groups.SequenceEqual(other.Groups)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Users != null)
                    hashCode = hashCode * 59 + Users.GetHashCode();
                    if (Groups != null)
                    hashCode = hashCode * 59 + Groups.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GetCorrespondents200ResponseResultsInnerPermissionsView left, GetCorrespondents200ResponseResultsInnerPermissionsView right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetCorrespondents200ResponseResultsInnerPermissionsView left, GetCorrespondents200ResponseResultsInnerPermissionsView right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
