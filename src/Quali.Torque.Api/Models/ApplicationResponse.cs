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
    /// Application information
    /// </summary>
    [DataContract]
    public class ApplicationResponse : IEquatable<ApplicationResponse>
    {
        /// <summary>
        /// Application private address
        /// </summary>
        /// <value>Application private address</value>
        [DataMember(Name="private_address", EmitDefaultValue=true)]
        public string PrivateAddress { get; set; }

        /// <summary>
        /// Application public address
        /// </summary>
        /// <value>Application public address</value>
        [DataMember(Name="public_address", EmitDefaultValue=true)]
        public string PublicAddress { get; set; }

        /// <summary>
        /// Application internal ports
        /// </summary>
        /// <value>Application internal ports</value>
        [DataMember(Name="internal_ports", EmitDefaultValue=true)]
        public List<string> InternalPorts { get; set; }

        /// <summary>
        /// Application external ports
        /// </summary>
        /// <value>Application external ports</value>
        [DataMember(Name="external_ports", EmitDefaultValue=true)]
        public List<string> ExternalPorts { get; set; }

        /// <summary>
        /// Application shortcut rules  &lt;remarks&gt;  The shortcut rule customizes the application link???s display text in the summary page of the sandbox or production environment  &lt;/remarks&gt;
        /// </summary>
        /// <value>Application shortcut rules  &lt;remarks&gt;  The shortcut rule customizes the application link???s display text in the summary page of the sandbox or production environment  &lt;/remarks&gt;</value>
        [DataMember(Name="shortcuts", EmitDefaultValue=true)]
        public List<string> Shortcuts { get; set; }

        /// <summary>
        /// Application cloud image (AMI for AWS and URN/subscription ID for Azure)
        /// </summary>
        /// <value>Application cloud image (AMI for AWS and URN/subscription ID for Azure)</value>
        [DataMember(Name="image_name", EmitDefaultValue=true)]
        public string ImageName { get; set; }

        /// <summary>
        /// DNS name of the application in the sandbox (as decided by the cloud provider)
        /// </summary>
        /// <value>DNS name of the application in the sandbox (as decided by the cloud provider)</value>
        [DataMember(Name="internal_dns", EmitDefaultValue=true)]
        public string InternalDns { get; set; }

        /// <summary>
        /// Application instances
        /// </summary>
        /// <value>Application instances</value>
        [DataMember(Name="instances", EmitDefaultValue=true)]
        public List<AppInstanceResponse> Instances { get; set; }

        /// <summary>
        /// Application image name
        /// </summary>
        /// <value>Application image name</value>
        [DataMember(Name="icon", EmitDefaultValue=true)]
        public string Icon { get; set; }

        /// <summary>
        /// Array of protocols for in-browser connection to VM (RDP | SSH | RDP,SSH)
        /// </summary>
        /// <value>Array of protocols for in-browser connection to VM (RDP | SSH | RDP,SSH)</value>
        [DataMember(Name="direct_access_protocols", EmitDefaultValue=true)]
        public List<string> DirectAccessProtocols { get; set; }

        /// <summary>
        /// Application name
        /// </summary>
        /// <value>Application name</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Application status (\&quot;Pending\&quot;, \&quot;Aborted\&quot;, \&quot;Done\&quot;, etc.)
        /// </summary>
        /// <value>Application status (\&quot;Pending\&quot;, \&quot;Aborted\&quot;, \&quot;Done\&quot;, etc.)</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Cloud
        /// </summary>
        [DataMember(Name="cloud", EmitDefaultValue=false)]
        public CloudResponse Cloud { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationResponse {\n");
            sb.Append("  PrivateAddress: ").Append(PrivateAddress).Append("\n");
            sb.Append("  PublicAddress: ").Append(PublicAddress).Append("\n");
            sb.Append("  InternalPorts: ").Append(InternalPorts).Append("\n");
            sb.Append("  ExternalPorts: ").Append(ExternalPorts).Append("\n");
            sb.Append("  Shortcuts: ").Append(Shortcuts).Append("\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
            sb.Append("  InternalDns: ").Append(InternalDns).Append("\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  DirectAccessProtocols: ").Append(DirectAccessProtocols).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Cloud: ").Append(Cloud).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ApplicationResponse)obj);
        }

        /// <summary>
        /// Returns true if ApplicationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplicationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PrivateAddress == other.PrivateAddress ||
                    PrivateAddress != null &&
                    PrivateAddress.Equals(other.PrivateAddress)
                ) && 
                (
                    PublicAddress == other.PublicAddress ||
                    PublicAddress != null &&
                    PublicAddress.Equals(other.PublicAddress)
                ) && 
                (
                    InternalPorts == other.InternalPorts ||
                    InternalPorts != null &&
                    other.InternalPorts != null &&
                    InternalPorts.SequenceEqual(other.InternalPorts)
                ) && 
                (
                    ExternalPorts == other.ExternalPorts ||
                    ExternalPorts != null &&
                    other.ExternalPorts != null &&
                    ExternalPorts.SequenceEqual(other.ExternalPorts)
                ) && 
                (
                    Shortcuts == other.Shortcuts ||
                    Shortcuts != null &&
                    other.Shortcuts != null &&
                    Shortcuts.SequenceEqual(other.Shortcuts)
                ) && 
                (
                    ImageName == other.ImageName ||
                    ImageName != null &&
                    ImageName.Equals(other.ImageName)
                ) && 
                (
                    InternalDns == other.InternalDns ||
                    InternalDns != null &&
                    InternalDns.Equals(other.InternalDns)
                ) && 
                (
                    Instances == other.Instances ||
                    Instances != null &&
                    other.Instances != null &&
                    Instances.SequenceEqual(other.Instances)
                ) && 
                (
                    Icon == other.Icon ||
                    Icon != null &&
                    Icon.Equals(other.Icon)
                ) && 
                (
                    DirectAccessProtocols == other.DirectAccessProtocols ||
                    DirectAccessProtocols != null &&
                    other.DirectAccessProtocols != null &&
                    DirectAccessProtocols.SequenceEqual(other.DirectAccessProtocols)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Cloud == other.Cloud ||
                    Cloud != null &&
                    Cloud.Equals(other.Cloud)
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
                    if (PrivateAddress != null)
                    hashCode = hashCode * 59 + PrivateAddress.GetHashCode();
                    if (PublicAddress != null)
                    hashCode = hashCode * 59 + PublicAddress.GetHashCode();
                    if (InternalPorts != null)
                    hashCode = hashCode * 59 + InternalPorts.GetHashCode();
                    if (ExternalPorts != null)
                    hashCode = hashCode * 59 + ExternalPorts.GetHashCode();
                    if (Shortcuts != null)
                    hashCode = hashCode * 59 + Shortcuts.GetHashCode();
                    if (ImageName != null)
                    hashCode = hashCode * 59 + ImageName.GetHashCode();
                    if (InternalDns != null)
                    hashCode = hashCode * 59 + InternalDns.GetHashCode();
                    if (Instances != null)
                    hashCode = hashCode * 59 + Instances.GetHashCode();
                    if (Icon != null)
                    hashCode = hashCode * 59 + Icon.GetHashCode();
                    if (DirectAccessProtocols != null)
                    hashCode = hashCode * 59 + DirectAccessProtocols.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Cloud != null)
                    hashCode = hashCode * 59 + Cloud.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ApplicationResponse left, ApplicationResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApplicationResponse left, ApplicationResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
