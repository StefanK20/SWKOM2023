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
    public partial class GetDocumentSuggestions200Response : IEquatable<GetDocumentSuggestions200Response>
    {
        /// <summary>
        /// Gets or Sets Correspondents
        /// </summary>
        [Required]
        [DataMember(Name="correspondents", EmitDefaultValue=false)]
        public List<Object> Correspondents { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [Required]
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Object> Tags { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTypes
        /// </summary>
        [Required]
        [DataMember(Name="document_types", EmitDefaultValue=false)]
        public List<Object> DocumentTypes { get; set; }

        /// <summary>
        /// Gets or Sets StoragePaths
        /// </summary>
        [Required]
        [DataMember(Name="storage_paths", EmitDefaultValue=false)]
        public List<Object> StoragePaths { get; set; }

        /// <summary>
        /// Gets or Sets Dates
        /// </summary>
        [Required]
        [DataMember(Name="dates", EmitDefaultValue=false)]
        public List<Object> Dates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocumentSuggestions200Response {\n");
            sb.Append("  Correspondents: ").Append(Correspondents).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DocumentTypes: ").Append(DocumentTypes).Append("\n");
            sb.Append("  StoragePaths: ").Append(StoragePaths).Append("\n");
            sb.Append("  Dates: ").Append(Dates).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetDocumentSuggestions200Response)obj);
        }

        /// <summary>
        /// Returns true if GetDocumentSuggestions200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of GetDocumentSuggestions200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentSuggestions200Response other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Correspondents == other.Correspondents ||
                    Correspondents != null &&
                    other.Correspondents != null &&
                    Correspondents.SequenceEqual(other.Correspondents)
                ) && 
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    other.Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    DocumentTypes == other.DocumentTypes ||
                    DocumentTypes != null &&
                    other.DocumentTypes != null &&
                    DocumentTypes.SequenceEqual(other.DocumentTypes)
                ) && 
                (
                    StoragePaths == other.StoragePaths ||
                    StoragePaths != null &&
                    other.StoragePaths != null &&
                    StoragePaths.SequenceEqual(other.StoragePaths)
                ) && 
                (
                    Dates == other.Dates ||
                    Dates != null &&
                    other.Dates != null &&
                    Dates.SequenceEqual(other.Dates)
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
                    if (Correspondents != null)
                    hashCode = hashCode * 59 + Correspondents.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                    if (DocumentTypes != null)
                    hashCode = hashCode * 59 + DocumentTypes.GetHashCode();
                    if (StoragePaths != null)
                    hashCode = hashCode * 59 + StoragePaths.GetHashCode();
                    if (Dates != null)
                    hashCode = hashCode * 59 + Dates.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GetDocumentSuggestions200Response left, GetDocumentSuggestions200Response right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetDocumentSuggestions200Response left, GetDocumentSuggestions200Response right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
