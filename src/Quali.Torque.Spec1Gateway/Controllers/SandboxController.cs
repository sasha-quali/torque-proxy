using System.ComponentModel.DataAnnotations;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using Quali.Torque.Api.Models;
namespace Quali.Torque.Spec1Gateway.Controllers;

public class SandboxController : Controller
{
    [HttpGet]
    [Route("/api/spaces/{space_name}/sandbox")]
    public async Task<List<SandboxResponseListItem>> GetAll([FromRoute(Name = "space_name")] [Required] string spaceName, [FromQuery(Name = "filter")] string? filter, [FromQuery(Name = "sandbox_name")] string? sandboxName, [FromQuery(Name = "count")] int? count)
    {
        var faker = new Faker<SandboxResponseListItem>();
        return faker.Generate(10);
    }

    [HttpGet]
    [Route("/api/spaces/{space_name}/sandbox/{sandbox_id}")]
    public async Task<SandboxResponse> Get([FromRoute (Name = "space_name")][Required]string spaceName, [FromRoute (Name = "sandbox_id")][Required]string sandboxId)
    {
        var faker = new Faker<SandboxResponse>();
        return faker.Generate();
    }

    [HttpPost]
    [Route("/api/spaces/{space_name}/sandbox")]
    public async Task<CreateEnvResponse> Create([FromRoute (Name = "space_name")][Required]string spaceName, [FromBody]CreateSandboxRequest createSandboxRequest)
    {
        var faker = new Faker<CreateEnvResponse>();
        return faker.Generate();
    }

    [HttpDelete]
    [Route("/api/spaces/{space_name}/sandbox/{sandbox_id}")]
    public async Task Terminate([FromRoute(Name = "space_name")] [Required] string spaceName, [FromRoute(Name = "sandbox_id")] [Required] string sandboxId, [FromQuery(Name = "ignore_errors")] string? ignoreErrors)
    {
        return;
    }
}
