using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// NodeCondition contains condition information for a node.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1NodeCondition {
    /// <summary>
    /// Last time we got an update on a given condition.
    /// </summary>
    /// <value>Last time we got an update on a given condition.</value>
    [DataMember(Name="lastHeartbeatTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastHeartbeatTime")]
    public IoK8sApimachineryPkgApisMetaV1Time LastHeartbeatTime { get; set; }

    /// <summary>
    /// Last time the condition transit from one status to another.
    /// </summary>
    /// <value>Last time the condition transit from one status to another.</value>
    [DataMember(Name="lastTransitionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransitionTime")]
    // public IoK8sApimachineryPkgApisMetaV1Time LastTransitionTime { get; set; }
    public DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// Human readable message indicating details about last transition.
    /// </summary>
    /// <value>Human readable message indicating details about last transition.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// (brief) reason for the condition's last transition.
    /// </summary>
    /// <value>(brief) reason for the condition's last transition.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Status of the condition, one of True, False, Unknown.
    /// </summary>
    /// <value>Status of the condition, one of True, False, Unknown.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Type of node condition.
    /// </summary>
    /// <value>Type of node condition.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1NodeCondition {\n");
      sb.Append("  LastHeartbeatTime: ").Append(LastHeartbeatTime).Append("\n");
      sb.Append("  LastTransitionTime: ").Append(LastTransitionTime).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
