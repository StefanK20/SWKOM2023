/*
 * PaperlessREST
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DocumentType
    /// </summary>
    [DataContract(Name = "DocumentType")]
    public partial class DocumentType : IEquatable<DocumentType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentType" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="slug">slug.</param>
        /// <param name="name">name.</param>
        /// <param name="match">match.</param>
        /// <param name="matchingAlgorithm">matchingAlgorithm.</param>
        /// <param name="isInsensitive">isInsensitive.</param>
        /// <param name="documentCount">documentCount.</param>
        public DocumentType(long id = default(long), string slug = default(string), string name = default(string), string match = default(string), long matchingAlgorithm = default(long), bool isInsensitive = default(bool), long documentCount = default(long))
        {
            this.Id = id;
            this.Slug = slug;
            this.Name = name;
            this.Match = match;
            this.MatchingAlgorithm = matchingAlgorithm;
            this.IsInsensitive = isInsensitive;
            this.DocumentCount = documentCount;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [DataMember(Name = "match", EmitDefaultValue = true)]
        public string Match { get; set; }

        /// <summary>
        /// Gets or Sets MatchingAlgorithm
        /// </summary>
        [DataMember(Name = "matching_algorithm", EmitDefaultValue = false)]
        public long MatchingAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets IsInsensitive
        /// </summary>
        [DataMember(Name = "is_insensitive", EmitDefaultValue = true)]
        public bool IsInsensitive { get; set; }

        /// <summary>
        /// Gets or Sets DocumentCount
        /// </summary>
        [DataMember(Name = "document_count", EmitDefaultValue = false)]
        public long DocumentCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  MatchingAlgorithm: ").Append(MatchingAlgorithm).Append("\n");
            sb.Append("  IsInsensitive: ").Append(IsInsensitive).Append("\n");
            sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentType);
        }

        /// <summary>
        /// Returns true if DocumentType instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Match == input.Match ||
                    (this.Match != null &&
                    this.Match.Equals(input.Match))
                ) && 
                (
                    this.MatchingAlgorithm == input.MatchingAlgorithm ||
                    this.MatchingAlgorithm.Equals(input.MatchingAlgorithm)
                ) && 
                (
                    this.IsInsensitive == input.IsInsensitive ||
                    this.IsInsensitive.Equals(input.IsInsensitive)
                ) && 
                (
                    this.DocumentCount == input.DocumentCount ||
                    this.DocumentCount.Equals(input.DocumentCount)
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
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Match != null)
                {
                    hashCode = (hashCode * 59) + this.Match.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MatchingAlgorithm.GetHashCode();
                hashCode = (hashCode * 59) + this.IsInsensitive.GetHashCode();
                hashCode = (hashCode * 59) + this.DocumentCount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
