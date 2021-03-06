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
    /// Blueprint input information
    /// </summary>
    [DataContract]
    public class BlueprintInputResponse : IEquatable<BlueprintInputResponse>
    {
        /// <summary>
        /// Input name
        /// </summary>
        /// <value>Input name</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// When the sandbox is created, Torque automatically populates the input with this value.  &lt;remarks&gt;  User can choose to edit the value or leave it as-is  &lt;/remarks&gt;
        /// </summary>
        /// <value>When the sandbox is created, Torque automatically populates the input with this value.  &lt;remarks&gt;  User can choose to edit the value or leave it as-is  &lt;/remarks&gt;</value>
        [DataMember(Name="default_value", EmitDefaultValue=true)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Indicates how to display the input value in UI  &lt;remarks&gt;  - To display the input value in plain text in the UI, do not assign a value.&lt;br /&gt;  - To hide the input value behind bullets, enter the value \&quot;masked\&quot;.  &lt;/remarks&gt;
        /// </summary>
        /// <value>Indicates how to display the input value in UI  &lt;remarks&gt;  - To display the input value in plain text in the UI, do not assign a value.&lt;br /&gt;  - To hide the input value behind bullets, enter the value \&quot;masked\&quot;.  &lt;/remarks&gt;</value>
        [DataMember(Name="display_style", EmitDefaultValue=true)]
        public string DisplayStyle { get; set; }

        /// <summary>
        /// Input description
        /// </summary>
        /// <value>Input description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates if the input is optional or not  &lt;remarks&gt;  - When optional is set to true, the user can leave the parameter empty.&lt;br /&gt;  - When optional is set to false, empty value(s) will result in validation error(s).  &lt;/remarks&gt;
        /// </summary>
        /// <value>Indicates if the input is optional or not  &lt;remarks&gt;  - When optional is set to true, the user can leave the parameter empty.&lt;br /&gt;  - When optional is set to false, empty value(s) will result in validation error(s).  &lt;/remarks&gt;</value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool Optional { get; set; }

        /// <summary>
        /// Possible values for the input  &lt;remarks&gt;  - Possible_values are optional  - The default value is one of the possible values  - Possible values must be unique  &lt;/remarks&gt;
        /// </summary>
        /// <value>Possible values for the input  &lt;remarks&gt;  - Possible_values are optional  - The default value is one of the possible values  - Possible values must be unique  &lt;/remarks&gt;</value>
        [DataMember(Name="possible_values", EmitDefaultValue=true)]
        public List<string> PossibleValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlueprintInputResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  DisplayStyle: ").Append(DisplayStyle).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  PossibleValues: ").Append(PossibleValues).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BlueprintInputResponse)obj);
        }

        /// <summary>
        /// Returns true if BlueprintInputResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BlueprintInputResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlueprintInputResponse other)
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
                    DefaultValue == other.DefaultValue ||
                    DefaultValue != null &&
                    DefaultValue.Equals(other.DefaultValue)
                ) && 
                (
                    DisplayStyle == other.DisplayStyle ||
                    DisplayStyle != null &&
                    DisplayStyle.Equals(other.DisplayStyle)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Optional == other.Optional ||
                    
                    Optional.Equals(other.Optional)
                ) && 
                (
                    PossibleValues == other.PossibleValues ||
                    PossibleValues != null &&
                    other.PossibleValues != null &&
                    PossibleValues.SequenceEqual(other.PossibleValues)
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
                    if (DefaultValue != null)
                    hashCode = hashCode * 59 + DefaultValue.GetHashCode();
                    if (DisplayStyle != null)
                    hashCode = hashCode * 59 + DisplayStyle.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + Optional.GetHashCode();
                    if (PossibleValues != null)
                    hashCode = hashCode * 59 + PossibleValues.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BlueprintInputResponse left, BlueprintInputResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BlueprintInputResponse left, BlueprintInputResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
