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
    /// Request to add parameter to Parameter Store
    /// </summary>
    [DataContract]
    public class ParameterStoreItemRequest : IEquatable<ParameterStoreItemRequest>
    {
        /// <summary>
        /// Parameter name  &lt;remarks&gt;  - Parameter Name is case-insensitive&lt;br /&gt;  - Parameter Name may only contain URL-supported characters including letters, digits, underscores, dashes, etc.  &lt;/remarks&gt;
        /// </summary>
        /// <value>Parameter name  &lt;remarks&gt;  - Parameter Name is case-insensitive&lt;br /&gt;  - Parameter Name may only contain URL-supported characters including letters, digits, underscores, dashes, etc.  &lt;/remarks&gt;</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Torque???s Parameter Store supports two types of parameters:  - \&quot;literal\&quot;: Parameter with a string value&lt;br /&gt;  - \&quot;aws-ssm\&quot;: Parameter that references a string parameter in the AWS Parameter Store
        /// </summary>
        /// <value>Torque???s Parameter Store supports two types of parameters:  - \&quot;literal\&quot;: Parameter with a string value&lt;br /&gt;  - \&quot;aws-ssm\&quot;: Parameter that references a string parameter in the AWS Parameter Store</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public Object Origin { get; set; }

        /// <summary>
        /// Parameter description
        /// </summary>
        /// <value>Parameter description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Value of parameter based on its origin:  &lt;remarks&gt;  - AWS System Manager (SSM): { \&quot;path\&quot; : \&quot;\&quot; }&lt;br /&gt;  - literal: { \&quot;content\&quot; : \&quot;\&quot; }  &lt;/remarks&gt;
        /// </summary>
        /// <value>Value of parameter based on its origin:  &lt;remarks&gt;  - AWS System Manager (SSM): { \&quot;path\&quot; : \&quot;\&quot; }&lt;br /&gt;  - literal: { \&quot;content\&quot; : \&quot;\&quot; }  &lt;/remarks&gt;</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParameterStoreItemRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ParameterStoreItemRequest)obj);
        }

        /// <summary>
        /// Returns true if ParameterStoreItemRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ParameterStoreItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParameterStoreItemRequest other)
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
                    Origin == other.Origin ||
                    Origin != null &&
                    Origin.Equals(other.Origin)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
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
                    if (Origin != null)
                    hashCode = hashCode * 59 + Origin.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ParameterStoreItemRequest left, ParameterStoreItemRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ParameterStoreItemRequest left, ParameterStoreItemRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
