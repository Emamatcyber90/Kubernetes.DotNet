using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ReplicaSetStatus represents the current status of a ReplicaSet.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetStatus {
    /// <summary>
    /// The number of available replicas (ready for at least minReadySeconds) for this replica set.
    /// </summary>
    /// <value>The number of available replicas (ready for at least minReadySeconds) for this replica set.</value>
    [DataMember(Name="availableReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableReplicas")]
    public int? AvailableReplicas { get; set; }

    /// <summary>
    /// Represents the latest available observations of a replica set's current state.
    /// </summary>
    /// <value>Represents the latest available observations of a replica set's current state.</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetCondition> Conditions { get; set; }

    /// <summary>
    /// The number of pods that have labels matching the labels of the pod template of the replicaset.
    /// </summary>
    /// <value>The number of pods that have labels matching the labels of the pod template of the replicaset.</value>
    [DataMember(Name="fullyLabeledReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullyLabeledReplicas")]
    public int? FullyLabeledReplicas { get; set; }

    /// <summary>
    /// ObservedGeneration reflects the generation of the most recently observed ReplicaSet.
    /// </summary>
    /// <value>ObservedGeneration reflects the generation of the most recently observed ReplicaSet.</value>
    [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// The number of ready replicas for this replica set.
    /// </summary>
    /// <value>The number of ready replicas for this replica set.</value>
    [DataMember(Name="readyReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readyReplicas")]
    public int? ReadyReplicas { get; set; }

    /// <summary>
    /// Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
    /// </summary>
    /// <value>Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replicas")]
    public int? Replicas { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetStatus {\n");
      sb.Append("  AvailableReplicas: ").Append(AvailableReplicas).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  FullyLabeledReplicas: ").Append(FullyLabeledReplicas).Append("\n");
      sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
      sb.Append("  ReadyReplicas: ").Append(ReadyReplicas).Append("\n");
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
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
