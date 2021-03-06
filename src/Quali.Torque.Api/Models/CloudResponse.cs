/*
 * Torque API Reference
 *
 * This page contains information about the Torque APIs and how to use it.<br><br>To be able to test the API methods, you will need an access token to be set in the Authorize section.If you got to this page from your Torque account, we already made it available for you, but you can switch to a different token as needed.<br>To get a different token, use the 'Get token' function available under the 'Access Tokens' section. After running the method, copy the access_token you get in the response and set it in the Authorize fieldas 'Bearer access_token'. For example: Bearer fqSWuw72BbUVFn8AbokF77GJ0r5KEn9MiZjLXF8kBwI.<br><br>The API can be accessed with your account endpoint as will be mentioned in the descriptions and examples or using https://qtorque.io as the prefix instead.
 *
 * The version of the OpenAPI document: 1.0.0
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
using Quali.Torque.Api.Converters;

namespace Quali.Torque.Api.Models
{ 
    /// <summary>
    /// Cloud account or Kubernetes compute service information
    /// </summary>
    [DataContract]
    public class CloudResponse : IEquatable<CloudResponse>
    {
        /// <summary>
        /// Cloud provider name
        /// </summary>
        /// <value>Cloud provider name</value>
        [DataMember(Name="provider", EmitDefaultValue=true)]
        public string Provider { get; set; }

        /// <summary>
        /// Cloud account name
        /// </summary>
        /// <value>Cloud account name</value>
        [DataMember(Name="cloud_account_name", EmitDefaultValue=true)]
        public string CloudAccountName { get; set; }

        /// <summary>
        /// Gets or Sets ComputeService
        /// </summary>
        [DataMember(Name="compute_service", EmitDefaultValue=false)]
        public CloudComputeServiceResponse ComputeService { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public CloudRegionResponse Region { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudResponse {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  CloudAccountName: ").Append(CloudAccountName).Append("\n");
            sb.Append("  ComputeService: ").Append(ComputeService).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
            return obj.GetType() == GetType() && Equals((CloudResponse)obj);
        }

        /// <summary>
        /// Returns true if CloudResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CloudResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Provider == other.Provider ||
                    Provider != null &&
                    Provider.Equals(other.Provider)
                ) && 
                (
                    CloudAccountName == other.CloudAccountName ||
                    CloudAccountName != null &&
                    CloudAccountName.Equals(other.CloudAccountName)
                ) && 
                (
                    ComputeService == other.ComputeService ||
                    ComputeService != null &&
                    ComputeService.Equals(other.ComputeService)
                ) && 
                (
                    Region == other.Region ||
                    Region != null &&
                    Region.Equals(other.Region)
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
                    if (Provider != null)
                    hashCode = hashCode * 59 + Provider.GetHashCode();
                    if (CloudAccountName != null)
                    hashCode = hashCode * 59 + CloudAccountName.GetHashCode();
                    if (ComputeService != null)
                    hashCode = hashCode * 59 + ComputeService.GetHashCode();
                    if (Region != null)
                    hashCode = hashCode * 59 + Region.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CloudResponse left, CloudResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CloudResponse left, CloudResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
