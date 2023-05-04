using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Transflo.Driver.Application.Dto;
using Transflo.Driver.Application.Interfaces;

namespace Transflo.Driver.Api.Endpoints
{
    public static class DriverEndpoints
    {
        public static void MapDriverEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/driver").WithTags(nameof(Models.Driver));
            group.MapGet("/", async (IDriverService driverService) =>
            {
                return await driverService.GetAllAsync();
            })
            .WithName("GetAllDrivers")
            .WithOpenApi();

            group.MapGet("/alphabetized", async (IDriverService driverService) =>
            {
                return await driverService.GetAllAlphabetizedAsync();
            })
            .WithName("GetAllDriversAlphabetized")
            .WithOpenApi();

            group.MapGet("/{id}", async Task<Results<Ok<DriverDto>, NotFound>> (int id, IDriverService driverService) =>
            {
                return await driverService.GetByIdAsync(id)
                    is DriverDto dto
                        ? TypedResults.Ok(dto)
                        : TypedResults.NotFound();
            })
            .WithName("GetDriverById")
            .WithOpenApi();

            group.MapPost("/", async Task<IResult> (PostDriverDto dto
                , IValidator<PostDriverDto> validator
                , IDriverService driverService
                , LinkGenerator linker) =>
            {
                var validationResult = await validator.ValidateAsync(dto);
                if (!validationResult.IsValid)
                {
                    return Results.ValidationProblem(validationResult.ToDictionary());
                }
                var insertedDto = await driverService.InsertAsync(dto);
                var path = linker.GetPathByName("GetDriverById", values: new { insertedDto.Id });
                return TypedResults.Created(path, insertedDto);
            })
            .WithName("CreateDriver")
            .WithOpenApi();

            group.MapPut("/{id}", async Task<IResult> (int id
                , UpdateDriverDto dto
                , IValidator<UpdateDriverDto> validator
                , IDriverService driverService) =>
            {
                dto.SetDriverId(id);
                var validationResult = await validator.ValidateAsync(dto);
                if (!validationResult.IsValid)
                {
                    return Results.ValidationProblem(validationResult.ToDictionary());
                }
                var affected = await driverService.UpdateAsync(dto);

                return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
            })
            .WithName("UpdateDriver")
            .WithOpenApi();

            group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, IDriverService driverService) =>
            {
                var affected = await driverService.DeleteByIdAsync(id);

                return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
            })
            .WithName("DeleteDriver")
            .WithOpenApi();
        }

    }
}
