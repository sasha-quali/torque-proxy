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
    /// Cloud compute service information
    /// </summary>
    [DataContract]
    public class CloudComputeServiceResponse : IEquatable<CloudComputeServiceResponse>
    {
        /// <summary>
        /// Cloud compute service name
        /// </summary>
        /// <value>Cloud compute service name</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Cloud compute service type (EC2, Azure virtual machine, AKS, EKS, etc.)
        /// </summary>
        /// <value>Cloud compute service type (EC2, Azure virtual machine, AKS, EKS, etc.)</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Cloud compute service creation date and time
        /// </summary>
        /// <value>Cloud compute service creation date and time</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// User name of the cloud compute service owner
        /// </summary>
        /// <value>User name of the cloud compute service owner</value>
        [DataMember(Name="created_by", EmitDefaultValue=true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Indicates if the cloud compute service created automatically or defined by the user&lt;br /&gt;&lt;example&gt;EC2 and Azure VM are not user defined while K8s, EKS and AKS are user-defined.&lt;/example&gt;
        /// </summary>
        /// <value>Indicates if the cloud compute service created automatically or defined by the user&lt;br /&gt;&lt;example&gt;EC2 and Azure VM are not user defined while K8s, EKS and AKS are user-defined.&lt;/example&gt;</value>
        [DataMember(Name="user_defined", EmitDefaultValue=false)]
        public bool UserDefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudComputeServiceResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CloudComputeServiceResponse)obj);
        }

        /// <summary>
        /// Returns true if CloudComputeServiceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CloudComputeServiceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudComputeServiceResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    CreatedBy == other.CreatedBy ||
                    CreatedBy != null &&
                    CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    UserDefined == other.UserDefined ||
                    
                    UserDefined.Equals(other.UserDefined)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (CreatedBy != null)
                    hashCode = hashCode * 59 + CreatedBy.GetHashCode();
                    
                    hashCode = hashCode * 59 + UserDefined.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CloudComputeServiceResponse left, CloudComputeServiceResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CloudComputeServiceResponse left, CloudComputeServiceResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
