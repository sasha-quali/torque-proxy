using System.ComponentModel.DataAnnotations;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using Quali.Torque.Api.Models;
namespace Quali.Torque.Spec1Gateway.Controllers;

public class BlueprintController : Controller
{
    [HttpGet]
    [Route("/api/spaces/{space_name}/blueprints")]
    public async Task<List<BlueprintForGetAllResponse>> GetAll([FromRoute(Name = "space_name")] [Required] string spaceName, [FromQuery(Name = "type")] string? type, [FromQuery(Name = "commit")] string? commit, [FromQuery(Name = "branch")] string? branch)
    {
        var faker = new Faker<BlueprintForGetAllResponse>();
        return faker.Generate(10);
    }

    [HttpGet]
    [Route("/api/spaces/{space_name}/catalog/{blueprint_name}")]
    public async Task<CatalogForGetResponse> Get([FromRoute(Name = "space_name")] [Required] string spaceName, [FromRoute(Name = "blueprint_name")] [Required] string? blueprintName)
    {
        var faker = new Faker<CatalogForGetResponse>();
        return faker.Generate();
    }

    [HttpPost]
    [Route("/api/spaces/{space_name}/validations/blueprints")]
    public async Task<BlueprintValidationResponse> Validate([FromRoute(Name = "space_name")] [Required] string spaceName, [FromBody] BlueprintValidationRequest blueprintValidationRequest)
    {
        var faker = new Faker<BlueprintValidationResponse>();
        return faker.Generate();
    }

}