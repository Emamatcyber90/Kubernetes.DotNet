using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// IngressStatus describe the current state of the Ingress.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1IngressStatus {
    /// <summary>
    /// LoadBalancer contains the current status of the load-balancer.
    /// </summary>
    /// <value>LoadBalancer contains the current status of the load-balancer.</value>
    [DataMember(Name="loadBalancer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadBalancer")]
    public IoK8sKubernetesPkgApiV1LoadBalancerStatus LoadBalancer { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1IngressStatus {\n");
      sb.Append("  LoadBalancer: ").Append(LoadBalancer).Append("\n");
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