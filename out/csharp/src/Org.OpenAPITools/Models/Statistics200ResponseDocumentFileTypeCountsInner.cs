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
    public partial class Statistics200ResponseDocumentFileTypeCountsInner : IEquatable<Statistics200ResponseDocumentFileTypeCountsInner>
    {
        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [Required]
        [DataMember(Name="mime_type", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or Sets MimeTypeCount
        /// </summary>
        [Required]
        [DataMember(Name="mime_type_count", EmitDefaultValue=true)]
        public int MimeTypeCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Statistics200ResponseDocumentFileTypeCountsInner {\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  MimeTypeCount: ").Append(MimeTypeCount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Statistics200ResponseDocumentFileTypeCountsInner)obj);
        }

        /// <summary>
        /// Returns true if Statistics200ResponseDocumentFileTypeCountsInner instances are equal
        /// </summary>
        /// <param name="other">Instance of Statistics200ResponseDocumentFileTypeCountsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Statistics200ResponseDocumentFileTypeCountsInner other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MimeType == other.MimeType ||
                    MimeType != null &&
                    MimeType.Equals(other.MimeType)
                ) && 
                (
                    MimeTypeCount == other.MimeTypeCount ||
                    
                    MimeTypeCount.Equals(other.MimeTypeCount)
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
                    if (MimeType != null)
                    hashCode = hashCode * 59 + MimeType.GetHashCode();
                    
                    hashCode = hashCode * 59 + MimeTypeCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Statistics200ResponseDocumentFileTypeCountsInner left, Statistics200ResponseDocumentFileTypeCountsInner right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Statistics200ResponseDocumentFileTypeCountsInner left, Statistics200ResponseDocumentFileTypeCountsInner right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
