using Microsoft.AspNetCore.Http.HttpResults;
using Transflo.Driver.Application.Dto;
using Transflo.Driver.Application.Interfaces;

namespace Transflo.Driver.Api.Endpoints
{
    public static class AlphabetizerEndpoints
    {
        public static void MapAlphabetizerEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/alphabetizer").WithTags("alphabetizer");
            group.MapGet("/{name}", (string name
                , IAlphabetizerService svc) =>
            {
                return TypedResults.Ok(svc.Alphabetize(name));
            })
            .WithName("GetAlphabetizedName")
            .WithOpenApi();
        }
    }
}
