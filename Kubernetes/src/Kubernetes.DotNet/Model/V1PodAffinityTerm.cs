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
    /// Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; tches that of any node on which a pod of the set of pods is running
    /// </summary>
    [DataContract]
    public partial class V1PodAffinityTerm :  IEquatable<V1PodAffinityTerm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PodAffinityTerm" /> class.
        /// </summary>
        /// <param name="LabelSelector">A label query over a set of resources, in this case pods..</param>
        /// <param name="Namespaces">namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \&quot;this pod&#39;s namespace\&quot;.</param>
        /// <param name="TopologyKey">This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. For PreferredDuringScheduling pod anti-affinity, empty topologyKey is interpreted as \&quot;all topologies\&quot; (\&quot;all topologies\&quot; here means all the topologyKeys indicated by scheduler command-line argument - -failure-domains); for affinity and for RequiredDuringScheduling pod anti-affinity, empty topologyKey is not allowed..</param>
        public V1PodAffinityTerm(V1LabelSelector LabelSelector = default(V1LabelSelector), List<string> Namespaces = default(List<string>), string TopologyKey = default(string))
        {
            this.LabelSelector = LabelSelector;
            this.Namespaces = Namespaces;
            this.TopologyKey = TopologyKey;
        }
        
        /// <summary>
        /// A label query over a set of resources, in this case pods.
        /// </summary>
        /// <value>A label query over a set of resources, in this case pods.</value>
        [DataMember(Name="labelSelector", EmitDefaultValue=false)]
        public V1LabelSelector LabelSelector { get; set; }

        /// <summary>
        /// namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \&quot;this pod&#39;s namespace\&quot;
        /// </summary>
        /// <value>namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \&quot;this pod&#39;s namespace\&quot;</value>
        [DataMember(Name="namespaces", EmitDefaultValue=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. For PreferredDuringScheduling pod anti-affinity, empty topologyKey is interpreted as \&quot;all topologies\&quot; (\&quot;all topologies\&quot; here means all the topologyKeys indicated by scheduler command-line argument - -failure-domains); for affinity and for RequiredDuringScheduling pod anti-affinity, empty topologyKey is not allowed.
        /// </summary>
        /// <value>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. For PreferredDuringScheduling pod anti-affinity, empty topologyKey is interpreted as \&quot;all topologies\&quot; (\&quot;all topologies\&quot; here means all the topologyKeys indicated by scheduler command-line argument - -failure-domains); for affinity and for RequiredDuringScheduling pod anti-affinity, empty topologyKey is not allowed.</value>
        [DataMember(Name="topologyKey", EmitDefaultValue=false)]
        public string TopologyKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PodAffinityTerm {\n");
            sb.Append("  LabelSelector: ").Append(LabelSelector).Append("\n");
            sb.Append("  Namespaces: ").Append(Namespaces).Append("\n");
            sb.Append("  TopologyKey: ").Append(TopologyKey).Append("\n");
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
            return this.Equals(obj as V1PodAffinityTerm);
        }

        /// <summary>
        /// Returns true if V1PodAffinityTerm instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PodAffinityTerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PodAffinityTerm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LabelSelector == other.LabelSelector ||
                    this.LabelSelector != null &&
                    this.LabelSelector.Equals(other.LabelSelector)
                ) && 
                (
                    this.Namespaces == other.Namespaces ||
                    this.Namespaces != null &&
                    this.Namespaces.SequenceEqual(other.Namespaces)
                ) && 
                (
                    this.TopologyKey == other.TopologyKey ||
                    this.TopologyKey != null &&
                    this.TopologyKey.Equals(other.TopologyKey)
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
                if (this.LabelSelector != null)
                    hash = hash * 59 + this.LabelSelector.GetHashCode();
                if (this.Namespaces != null)
                    hash = hash * 59 + this.Namespaces.GetHashCode();
                if (this.TopologyKey != null)
                    hash = hash * 59 + this.TopologyKey.GetHashCode();
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