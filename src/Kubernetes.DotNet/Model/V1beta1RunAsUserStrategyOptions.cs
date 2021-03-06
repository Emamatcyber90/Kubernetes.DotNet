/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
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
using SwaggerDateConverter = Kubernetes.DotNet.Client.SwaggerDateConverter;

namespace Kubernetes.DotNet.Model
{
    /// <summary>
    /// Run A sUser Strategy Options defines the strategy type and any options used to create the strategy.
    /// </summary>
    [DataContract]
    public partial class V1beta1RunAsUserStrategyOptions :  IEquatable<V1beta1RunAsUserStrategyOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1RunAsUserStrategyOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1beta1RunAsUserStrategyOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1RunAsUserStrategyOptions" /> class.
        /// </summary>
        /// <param name="Ranges">Ranges are the allowed ranges of uids that may be used..</param>
        /// <param name="Rule">Rule is the strategy that will dictate the allowable RunAsUser values that may be set. (required).</param>
        public V1beta1RunAsUserStrategyOptions(List<V1beta1IDRange> Ranges = default(List<V1beta1IDRange>), string Rule = default(string))
        {
            // to ensure "Rule" is required (not null)
            if (Rule == null)
            {
                throw new InvalidDataException("Rule is a required property for V1beta1RunAsUserStrategyOptions and cannot be null");
            }
            else
            {
                this.Rule = Rule;
            }
            this.Ranges = Ranges;
        }
        
        /// <summary>
        /// Ranges are the allowed ranges of uids that may be used.
        /// </summary>
        /// <value>Ranges are the allowed ranges of uids that may be used.</value>
        [DataMember(Name="ranges", EmitDefaultValue=false)]
        public List<V1beta1IDRange> Ranges { get; set; }

        /// <summary>
        /// Rule is the strategy that will dictate the allowable RunAsUser values that may be set.
        /// </summary>
        /// <value>Rule is the strategy that will dictate the allowable RunAsUser values that may be set.</value>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public string Rule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1RunAsUserStrategyOptions {\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
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
            return this.Equals(obj as V1beta1RunAsUserStrategyOptions);
        }

        /// <summary>
        /// Returns true if V1beta1RunAsUserStrategyOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1RunAsUserStrategyOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1RunAsUserStrategyOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ranges == other.Ranges ||
                    this.Ranges != null &&
                    this.Ranges.SequenceEqual(other.Ranges)
                ) && 
                (
                    this.Rule == other.Rule ||
                    this.Rule != null &&
                    this.Rule.Equals(other.Rule)
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
                if (this.Ranges != null)
                    hash = hash * 59 + this.Ranges.GetHashCode();
                if (this.Rule != null)
                    hash = hash * 59 + this.Rule.GetHashCode();
                return hash;
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
