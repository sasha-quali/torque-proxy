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
    /// Blue production information
    /// </summary>
    [DataContract]
    public class ProductionBlueResponse : IEquatable<ProductionBlueResponse>
    {
        /// <summary>
        /// Indicates if there is a green production environment
        /// </summary>
        /// <value>Indicates if there is a green production environment</value>
        [DataMember(Name="has_green", EmitDefaultValue=false)]
        public bool HasGreen { get; set; }

        /// <summary>
        /// Sandbox ID
        /// </summary>
        /// <value>Sandbox ID</value>
        [DataMember(Name="sandbox_id", EmitDefaultValue=true)]
        public string SandboxId { get; set; }

        /// <summary>
        /// Production environment status (\&quot;launching\&quot;, \&quot;active\&quot;, \&quot;pending\&quot;, etc.)
        /// </summary>
        /// <value>Production environment status (\&quot;launching\&quot;, \&quot;active\&quot;, \&quot;pending\&quot;, etc.)</value>
        [DataMember(Name="production_status", EmitDefaultValue=true)]
        public string ProductionStatus { get; set; }

        /// <summary>
        /// Production environment update status (\&quot;deploying green\&quot;, \&quot;transitioning green\&quot;, \&quot;cleaning up\&quot;, etc.)
        /// </summary>
        /// <value>Production environment update status (\&quot;deploying green\&quot;, \&quot;transitioning green\&quot;, \&quot;cleaning up\&quot;, etc.)</value>
        [DataMember(Name="update_status", EmitDefaultValue=true)]
        public string UpdateStatus { get; set; }

        /// <summary>
        /// Description of the production environment&#39;s blueprint
        /// </summary>
        /// <value>Description of the production environment&#39;s blueprint</value>
        [DataMember(Name="blueprint_description", EmitDefaultValue=true)]
        public string BlueprintDescription { get; set; }

        /// <summary>
        /// Gets or Sets Applications
        /// </summary>
        [DataMember(Name="applications", EmitDefaultValue=true)]
        public List<ApplicationResponse> Applications { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name="services", EmitDefaultValue=true)]
        public List<ServiceResponse> Services { get; set; }

        /// <summary>
        /// Production environment artifacts
        /// </summary>
        /// <value>Production environment artifacts</value>
        [DataMember(Name="artifacts", EmitDefaultValue=true)]
        public Dictionary<string, string> Artifacts { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="inputs", EmitDefaultValue=true)]
        public List<CreateSandboxInput> Inputs { get; set; }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name="outputs", EmitDefaultValue=true)]
        public List<SandboxOutput> Outputs { get; set; }

        /// <summary>
        /// System, pre-defined and user-defined tags sandbox was launched with
        /// </summary>
        /// <value>System, pre-defined and user-defined tags sandbox was launched with</value>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<TagResponse> Tags { get; set; }

        /// <summary>
        /// Environment ID
        /// </summary>
        /// <value>Environment ID</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Environment name
        /// </summary>
        /// <value>Environment name</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Blueprint name
        /// </summary>
        /// <value>Blueprint name</value>
        [DataMember(Name="blueprint_name", EmitDefaultValue=true)]
        public string BlueprintName { get; set; }

        /// <summary>
        /// Enable logs flag
        /// </summary>
        /// <value>Enable logs flag</value>
        [DataMember(Name="enable_logs", EmitDefaultValue=true)]
        public bool? EnableLogs { get; set; }

        /// <summary>
        /// Environment status details (\&quot;initiating\&quot;, \&quot;waiting\&quot;, \&quot;launching\&quot;, etc.)
        /// </summary>
        /// <value>Environment status details (\&quot;initiating\&quot;, \&quot;waiting\&quot;, \&quot;launching\&quot;, etc.)</value>
        [DataMember(Name="status_details", EmitDefaultValue=true)]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Error status description of environment
        /// </summary>
        /// <value>Error status description of environment</value>
        [DataMember(Name="status_error_description", EmitDefaultValue=true)]
        public string StatusErrorDescription { get; set; }

        /// <summary>
        /// Environment deployment start time
        /// </summary>
        /// <value>Environment deployment start time</value>
        [DataMember(Name="deployment_start_time", EmitDefaultValue=true)]
        public string DeploymentStartTime { get; set; }

        /// <summary>
        /// Environment creation time
        /// </summary>
        /// <value>Environment creation time</value>
        [DataMember(Name="create_time", EmitDefaultValue=true)]
        public string CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="build", EmitDefaultValue=true)]
        public string Build { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=true)]
        public List<SandboxError> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserResponse Owner { get; set; }

        /// <summary>
        /// Debugging service information (\&quot;not ready\&quot;, \&quot;on\&quot;, \&quot;off\&quot;, etc.)
        /// </summary>
        /// <value>Debugging service information (\&quot;not ready\&quot;, \&quot;on\&quot;, \&quot;off\&quot;, etc.)</value>
        [DataMember(Name="debugging_service", EmitDefaultValue=true)]
        public string DebuggingService { get; set; }

        /// <summary>
        /// Gets or Sets LaunchingProgress
        /// </summary>
        [DataMember(Name="launching_progress", EmitDefaultValue=false)]
        public LaunchingProgressResponse LaunchingProgress { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public EnvCost Cost { get; set; }

        /// <summary>
        /// Indicates if environment is internet-facing
        /// </summary>
        /// <value>Indicates if environment is internet-facing</value>
        [DataMember(Name="internet_facing", EmitDefaultValue=true)]
        public bool? InternetFacing { get; set; }

        /// <summary>
        /// Indicates if there is a direct access to environment
        /// </summary>
        /// <value>Indicates if there is a direct access to environment</value>
        [DataMember(Name="direct_access", EmitDefaultValue=true)]
        public string DirectAccess { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=true)]
        public List<Hyperlink> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductionBlueResponse {\n");
            sb.Append("  HasGreen: ").Append(HasGreen).Append("\n");
            sb.Append("  SandboxId: ").Append(SandboxId).Append("\n");
            sb.Append("  ProductionStatus: ").Append(ProductionStatus).Append("\n");
            sb.Append("  UpdateStatus: ").Append(UpdateStatus).Append("\n");
            sb.Append("  BlueprintDescription: ").Append(BlueprintDescription).Append("\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BlueprintName: ").Append(BlueprintName).Append("\n");
            sb.Append("  EnableLogs: ").Append(EnableLogs).Append("\n");
            sb.Append("  StatusDetails: ").Append(StatusDetails).Append("\n");
            sb.Append("  StatusErrorDescription: ").Append(StatusErrorDescription).Append("\n");
            sb.Append("  DeploymentStartTime: ").Append(DeploymentStartTime).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  DebuggingService: ").Append(DebuggingService).Append("\n");
            sb.Append("  LaunchingProgress: ").Append(LaunchingProgress).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  InternetFacing: ").Append(InternetFacing).Append("\n");
            sb.Append("  DirectAccess: ").Append(DirectAccess).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProductionBlueResponse)obj);
        }

        /// <summary>
        /// Returns true if ProductionBlueResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductionBlueResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductionBlueResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HasGreen == other.HasGreen ||
                    
                    HasGreen.Equals(other.HasGreen)
                ) && 
                (
                    SandboxId == other.SandboxId ||
                    SandboxId != null &&
                    SandboxId.Equals(other.SandboxId)
                ) && 
                (
                    ProductionStatus == other.ProductionStatus ||
                    ProductionStatus != null &&
                    ProductionStatus.Equals(other.ProductionStatus)
                ) && 
                (
                    UpdateStatus == other.UpdateStatus ||
                    UpdateStatus != null &&
                    UpdateStatus.Equals(other.UpdateStatus)
                ) && 
                (
                    BlueprintDescription == other.BlueprintDescription ||
                    BlueprintDescription != null &&
                    BlueprintDescription.Equals(other.BlueprintDescription)
                ) && 
                (
                    Applications == other.Applications ||
                    Applications != null &&
                    other.Applications != null &&
                    Applications.SequenceEqual(other.Applications)
                ) && 
                (
                    Services == other.Services ||
                    Services != null &&
                    other.Services != null &&
                    Services.SequenceEqual(other.Services)
                ) && 
                (
                    Artifacts == other.Artifacts ||
                    Artifacts != null &&
                    other.Artifacts != null &&
                    Artifacts.SequenceEqual(other.Artifacts)
                ) && 
                (
                    Inputs == other.Inputs ||
                    Inputs != null &&
                    other.Inputs != null &&
                    Inputs.SequenceEqual(other.Inputs)
                ) && 
                (
                    Outputs == other.Outputs ||
                    Outputs != null &&
                    other.Outputs != null &&
                    Outputs.SequenceEqual(other.Outputs)
                ) && 
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    other.Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    BlueprintName == other.BlueprintName ||
                    BlueprintName != null &&
                    BlueprintName.Equals(other.BlueprintName)
                ) && 
                (
                    EnableLogs == other.EnableLogs ||
                    EnableLogs != null &&
                    EnableLogs.Equals(other.EnableLogs)
                ) && 
                (
                    StatusDetails == other.StatusDetails ||
                    StatusDetails != null &&
                    StatusDetails.Equals(other.StatusDetails)
                ) && 
                (
                    StatusErrorDescription == other.StatusErrorDescription ||
                    StatusErrorDescription != null &&
                    StatusErrorDescription.Equals(other.StatusErrorDescription)
                ) && 
                (
                    DeploymentStartTime == other.DeploymentStartTime ||
                    DeploymentStartTime != null &&
                    DeploymentStartTime.Equals(other.DeploymentStartTime)
                ) && 
                (
                    CreateTime == other.CreateTime ||
                    CreateTime != null &&
                    CreateTime.Equals(other.CreateTime)
                ) && 
                (
                    Build == other.Build ||
                    Build != null &&
                    Build.Equals(other.Build)
                ) && 
                (
                    Errors == other.Errors ||
                    Errors != null &&
                    other.Errors != null &&
                    Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    Owner == other.Owner ||
                    Owner != null &&
                    Owner.Equals(other.Owner)
                ) && 
                (
                    DebuggingService == other.DebuggingService ||
                    DebuggingService != null &&
                    DebuggingService.Equals(other.DebuggingService)
                ) && 
                (
                    LaunchingProgress == other.LaunchingProgress ||
                    LaunchingProgress != null &&
                    LaunchingProgress.Equals(other.LaunchingProgress)
                ) && 
                (
                    Cost == other.Cost ||
                    Cost != null &&
                    Cost.Equals(other.Cost)
                ) && 
                (
                    InternetFacing == other.InternetFacing ||
                    InternetFacing != null &&
                    InternetFacing.Equals(other.InternetFacing)
                ) && 
                (
                    DirectAccess == other.DirectAccess ||
                    DirectAccess != null &&
                    DirectAccess.Equals(other.DirectAccess)
                ) && 
                (
                    Links == other.Links ||
                    Links != null &&
                    other.Links != null &&
                    Links.SequenceEqual(other.Links)
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
                    
                    hashCode = hashCode * 59 + HasGreen.GetHashCode();
                    if (SandboxId != null)
                    hashCode = hashCode * 59 + SandboxId.GetHashCode();
                    if (ProductionStatus != null)
                    hashCode = hashCode * 59 + ProductionStatus.GetHashCode();
                    if (UpdateStatus != null)
                    hashCode = hashCode * 59 + UpdateStatus.GetHashCode();
                    if (BlueprintDescription != null)
                    hashCode = hashCode * 59 + BlueprintDescription.GetHashCode();
                    if (Applications != null)
                    hashCode = hashCode * 59 + Applications.GetHashCode();
                    if (Services != null)
                    hashCode = hashCode * 59 + Services.GetHashCode();
                    if (Artifacts != null)
                    hashCode = hashCode * 59 + Artifacts.GetHashCode();
                    if (Inputs != null)
                    hashCode = hashCode * 59 + Inputs.GetHashCode();
                    if (Outputs != null)
                    hashCode = hashCode * 59 + Outputs.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (BlueprintName != null)
                    hashCode = hashCode * 59 + BlueprintName.GetHashCode();
                    if (EnableLogs != null)
                    hashCode = hashCode * 59 + EnableLogs.GetHashCode();
                    if (StatusDetails != null)
                    hashCode = hashCode * 59 + StatusDetails.GetHashCode();
                    if (StatusErrorDescription != null)
                    hashCode = hashCode * 59 + StatusErrorDescription.GetHashCode();
                    if (DeploymentStartTime != null)
                    hashCode = hashCode * 59 + DeploymentStartTime.GetHashCode();
                    if (CreateTime != null)
                    hashCode = hashCode * 59 + CreateTime.GetHashCode();
                    if (Build != null)
                    hashCode = hashCode * 59 + Build.GetHashCode();
                    if (Errors != null)
                    hashCode = hashCode * 59 + Errors.GetHashCode();
                    if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();
                    if (DebuggingService != null)
                    hashCode = hashCode * 59 + DebuggingService.GetHashCode();
                    if (LaunchingProgress != null)
                    hashCode = hashCode * 59 + LaunchingProgress.GetHashCode();
                    if (Cost != null)
                    hashCode = hashCode * 59 + Cost.GetHashCode();
                    if (InternetFacing != null)
                    hashCode = hashCode * 59 + InternetFacing.GetHashCode();
                    if (DirectAccess != null)
                    hashCode = hashCode * 59 + DirectAccess.GetHashCode();
                    if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProductionBlueResponse left, ProductionBlueResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductionBlueResponse left, ProductionBlueResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
