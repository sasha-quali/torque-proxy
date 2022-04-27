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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Quali.Torque.Api.Attributes;
using Quali.Torque.Api.Models;

namespace Quali.Torque.Api.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class SandboxEnvironmentsApiController : ControllerBase
    { 
        /// <summary>
        /// Get all sandboxes
        /// </summary>
        /// <remarks>Returns details of all sandboxes in the space.</remarks>
        /// <param name="spaceName">Name of the space containing the sandboxes</param>
        /// <param name="filter">Filter for the environment:  - \&quot;automation\&quot;: Sandboxes launched by any automation process in the space  - \&quot;my\&quot;: Sandboxes launched by the user  - \&quot;all\&quot;: Sandboxes launched by anyone in the space</param>
        /// <param name="sandboxName">String that all sandbox names must contain</param>
        /// <param name="count">Amount of sandboxes to be retrieved</param>
        /// <response code="200">Success</response>
        /// <response code="404">Space not found</response>
        /// <response code="422">Count is above the maximum allowed sandboxes (1000)</response>
        [HttpGet]
        [Route("/api/spaces/{space_name}/sandbox")]
        [Authorize(Policy = "Bearer")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SandboxResponseListItem>))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        public abstract IActionResult ApiSpacesSpaceNameSandboxGet([FromRoute (Name = "space_name")][Required]string spaceName, [FromQuery (Name = "filter")]string filter, [FromQuery (Name = "sandbox_name")]string sandboxName, [FromQuery (Name = "count")]int? count);

        /// <summary>
        /// Start new sandbox
        /// </summary>
        /// <remarks>Launches a new sandbox environment in Torque</remarks>
        /// <param name="spaceName">Name of the space that should contain the sandbox environment</param>
        /// <param name="createSandboxRequest"></param>
        /// <response code="202">Success</response>
        /// <response code="400">Operation failed</response>
        /// <response code="403">User is not permitted to launch sandbox from branch</response>
        /// <response code="404">Space, current user, or compute service user not found</response>
        /// <response code="422">Could not processed request</response>
        /// <response code="424">Cloud account not accessible</response>
        [HttpPost]
        [Route("/api/spaces/{space_name}/sandbox")]
        [Authorize(Policy = "Bearer")]
        [Consumes("application/json")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 202, type: typeof(CreateEnvResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 424, type: typeof(ErrorResponse))]
        public abstract IActionResult ApiSpacesSpaceNameSandboxPost([FromRoute (Name = "space_name")][Required]string spaceName, [FromBody]CreateSandboxRequest createSandboxRequest);

        /// <summary>
        /// Turn Bastion on or off
        /// </summary>
        /// <remarks>This API requires Bastion to be deployed in the sandbox environment</remarks>
        /// <param name="spaceName">Name of the space containing the sandbox</param>
        /// <param name="sandboxId">Sandbox ID</param>
        /// <param name="value">Indicates if to enable/disable the debugging service: \&quot;on\&quot; or \&quot;off\&quot;</param>
        /// <response code="200">Success</response>
        /// <response code="202">Request is in progress or triggered</response>
        /// <response code="400">Operation failed</response>
        /// <response code="404">Space not found, sandbox not found, or debugging service is disabled</response>
        /// <response code="409">The current status of the debugging service is conflicted with the new status request</response>
        /// <response code="422">\&quot;value\&quot; is empty or invalid</response>
        /// <response code="424">Cloud not accessible</response>
        [HttpPut]
        [Route("/api/spaces/{space_name}/sandbox/{sandbox_id}/debuggingservice")]
        [Authorize(Policy = "Bearer")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 409, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 424, type: typeof(ErrorResponse))]
        public abstract IActionResult ApiSpacesSpaceNameSandboxSandboxIdDebuggingservicePut([FromRoute (Name = "space_name")][Required]string spaceName, [FromRoute (Name = "sandbox_id")][Required]string sandboxId, [FromQuery (Name = "value")]string value);

        /// <summary>
        /// End sandbox
        /// </summary>
        /// <remarks>Ends a running sandbox from Torque.</remarks>
        /// <param name="spaceName">Name of the space containing the sandbox</param>
        /// <param name="sandboxId">Sandbox ID</param>
        /// <param name="ignoreErrors">Should ignore errors during termination, if set to true then if termination of the sandbox failed it will be accepted as termination succeeded.</param>
        /// <response code="202">Success</response>
        /// <response code="400">Operation failed</response>
        /// <response code="404">Space not found, sandbox not found, or sandbox already ended</response>
        /// <response code="422">Invalid \&quot;ignore_errors\&quot; value</response>
        /// <response code="423">Sandbox already ending or temporarily unavailable for ending</response>
        /// <response code="424">Cloud not accessible</response>
        [HttpDelete]
        [Route("/api/spaces/{space_name}/sandbox/{sandbox_id}")]
        [Authorize(Policy = "Bearer")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 423, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 424, type: typeof(ErrorResponse))]
        public abstract IActionResult ApiSpacesSpaceNameSandboxSandboxIdDelete([FromRoute (Name = "space_name")][Required]string spaceName, [FromRoute (Name = "sandbox_id")][Required]string sandboxId, [FromQuery (Name = "ignore_errors")]string ignoreErrors);

        /// <summary>
        /// Gets sandbox details
        /// </summary>
        /// <remarks>Gets details on a sandbox.</remarks>
        /// <param name="spaceName">Name of the space containing the sandbox</param>
        /// <param name="sandboxId">Sandbox ID</param>
        /// <response code="200">Success</response>
        /// <response code="404">Space or sandbox not found</response>
        /// <response code="424">Cloud account is not accessible</response>
        [HttpGet]
        [Route("/api/spaces/{space_name}/sandbox/{sandbox_id}")]
        [Authorize(Policy = "Bearer")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SandboxResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 424, type: typeof(ErrorResponse))]
        public abstract IActionResult ApiSpacesSpaceNameSandboxSandboxIdGet([FromRoute (Name = "space_name")][Required]string spaceName, [FromRoute (Name = "sandbox_id")][Required]string sandboxId);

        /// <summary>
        /// Get terraform apply logs
        /// </summary>
        /// <param name="spaceName"></param>
        /// <param name="sandboxId"></param>
        /// <param name="serviceName"></param>
        /// <response code="200">Success</response>
        /// <response code="409">Conflict</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/api/spaces/{space_name}/sandbox/{sandboxId}/logs/tfapply")]
        [Authorize(Policy = "Bearer")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(string))]
        [ProducesResponseType(statusCode: 409, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        public abstract IActionResult ApiSpacesSpaceNameSandboxSandboxIdLogsTfapplyGet([FromRoute (Name = "space_name")][Required]string spaceName, [FromRoute (Name = "sandboxId")][Required]string sandboxId, [FromQuery (Name = "service_name")]string serviceName);

        /// <summary>
        /// Get terraform destroy logs
        /// </summary>
        /// <param name="spaceName"></param>
        /// <param name="sandboxId"></param>
        /// <param name="serviceName"></param>
        /// <response code="200">Success</response>
        /// <response code="409">Conflict</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/api/spaces/{space_name}/sandbox/{sandboxId}/logs/tfdestroy")]
        [Authorize(Policy = "Bearer")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(string))]
        [ProducesResponseType(statusCode: 409, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        public abstract IActionResult ApiSpacesSpaceNameSandboxSandboxIdLogsTfdestroyGet([FromRoute (Name = "space_name")][Required]string spaceName, [FromRoute (Name = "sandboxId")][Required]string sandboxId, [FromQuery (Name = "service_name")]string serviceName);

        /// <summary>
        /// Get terraform init logs
        /// </summary>
        /// <param name="spaceName"></param>
        /// <param name="sandboxId"></param>
        /// <param name="serviceName"></param>
        /// <response code="200">Success</response>
        /// <response code="409">Conflict</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/api/spaces/{space_name}/sandbox/{sandboxId}/logs/tfinit")]
        [Authorize(Policy = "Bearer")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(string))]
        [ProducesResponseType(statusCode: 409, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        public abstract IActionResult ApiSpacesSpaceNameSandboxSandboxIdLogsTfinitGet([FromRoute (Name = "space_name")][Required]string spaceName, [FromRoute (Name = "sandboxId")][Required]string sandboxId, [FromQuery (Name = "service_name")]string serviceName);

        /// <summary>
        /// Get terraform plan logs
        /// </summary>
        /// <param name="spaceName"></param>
        /// <param name="sandboxId"></param>
        /// <param name="serviceName"></param>
        /// <response code="200">Success</response>
        /// <response code="409">Conflict</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/api/spaces/{space_name}/sandbox/{sandboxId}/logs/tfplan")]
        [Authorize(Policy = "Bearer")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(string))]
        [ProducesResponseType(statusCode: 409, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        public abstract IActionResult ApiSpacesSpaceNameSandboxSandboxIdLogsTfplanGet([FromRoute (Name = "space_name")][Required]string spaceName, [FromRoute (Name = "sandboxId")][Required]string sandboxId, [FromQuery (Name = "service_name")]string serviceName);

        /// <summary>
        /// Extend sandbox
        /// </summary>
        /// <remarks>Extends the duration of a running sandbox</remarks>
        /// <param name="spaceName">Name of the space containing the sandbox</param>
        /// <param name="sandboxId">Sandbox ID</param>
        /// <param name="value">New scheduled end time in ISO 8601 format. For example, 2021-10-06T08:27:05.215Z.</param>
        /// <response code="200">Success</response>
        /// <response code="400">Operation failed</response>
        /// <response code="404">Space or sandbox not found</response>
        /// <response code="422">\&quot;value\&quot; (end time) is empty, not UTC, or time already passed</response>
        /// <response code="424">Cloud not accessible</response>
        [HttpPut]
        [Route("/api/spaces/{space_name}/sandbox/{sandbox_id}/scheduled_end_time")]
        [Authorize(Policy = "Bearer")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 424, type: typeof(ErrorResponse))]
        public abstract IActionResult ApiSpacesSpaceNameSandboxSandboxIdScheduledEndTimePut([FromRoute (Name = "space_name")][Required]string spaceName, [FromRoute (Name = "sandbox_id")][Required]string sandboxId, [FromQuery (Name = "value")]DateTime? value);
    }
}