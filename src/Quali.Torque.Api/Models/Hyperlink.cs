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
    /// Links to API
    /// </summary>
    [DataContract]
    public class Hyperlink : IEquatable<Hyperlink>
    {
        /// <summary>
        /// Link relation type that describes how the current context (source) is related to the target resource
        /// </summary>
        /// <value>Link relation type that describes how the current context (source) is related to the target resource</value>
        [DataMember(Name="rel", EmitDefaultValue=true)]
        public string Rel { get; set; }

        /// <summary>
        /// URI link to the API
        /// </summary>
        /// <value>URI link to the API</value>
        [DataMember(Name="href", EmitDefaultValue=true)]
        public string Href { get; set; }

        /// <summary>
        /// HTTP method (GET, POST, PUT, etc.)
        /// </summary>
        /// <value>HTTP method (GET, POST, PUT, etc.)</value>
        [DataMember(Name="method", EmitDefaultValue=true)]
        public string Method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Hyperlink {\n");
            sb.Append("  Rel: ").Append(Rel).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Hyperlink)obj);
        }

        /// <summary>
        /// Returns true if Hyperlink instances are equal
        /// </summary>
        /// <param name="other">Instance of Hyperlink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Hyperlink other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Rel == other.Rel ||
                    Rel != null &&
                    Rel.Equals(other.Rel)
                ) && 
                (
                    Href == other.Href ||
                    Href != null &&
                    Href.Equals(other.Href)
                ) && 
                (
                    Method == other.Method ||
                    Method != null &&
                    Method.Equals(other.Method)
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
                    if (Rel != null)
                    hashCode = hashCode * 59 + Rel.GetHashCode();
                    if (Href != null)
                    hashCode = hashCode * 59 + Href.GetHashCode();
                    if (Method != null)
                    hashCode = hashCode * 59 + Method.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Hyperlink left, Hyperlink right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Hyperlink left, Hyperlink right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
