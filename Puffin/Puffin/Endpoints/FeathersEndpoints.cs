using Microsoft.EntityFrameworkCore;
using Puffin.DataAccess.Data;
using Puffin.DataAccess.Entities;
using System.Linq;

namespace Puffin.Endpoints
{
	public static class FeathersEndpoints
	{
		public static void MapFeathersEndpoints(this WebApplication app)
		{
			app.MapGet("/feathers", List);
			app.MapGet("/feathers/{id}", Get);
			app.MapPost("feathers", Create);
			app.MapPut("feathers", Update);
			app.MapDelete("feathers/{id}", Delete);
		}

		public static async Task<IResult> List(PuffinDbContext context)
		{
			// var result = await context.Feathers.ToListAsync();
			return Results.Ok();
		}

		public static async Task<IResult> Get(PuffinDbContext context, int id)
		{
			return await context.Feathers.FindAsync(id) is Feather feather
				? Results.Ok(feather)
				: Results.NotFound();
		}

		public static async Task<IResult> Create(PuffinDbContext context, Feather feather)
		{
			context.Feathers.Add(feather);
			await context.SaveChangesAsync();

			return Results.Created($"/feathers/{feather.Id}", feather);
		}

		public static async Task<IResult> Update(PuffinDbContext context, Feather updatedFeather)
		{
			var feather = await context.Feathers.FindAsync(updatedFeather.Id);

			if (feather is null)
				return Results.NotFound();

			feather.Name = updatedFeather.Name;
			feather.Weight = updatedFeather.Weight;
			feather.Price = updatedFeather.Price;
			feather.InStock = updatedFeather.InStock;

			await context.SaveChangesAsync();
			return Results.NoContent();
		}

        public static async Task<IResult> Delete(PuffinDbContext context, int id)
        {
			if (await context.Feathers.FindAsync(id) is Feather feather)
			{
				context.Feathers.Remove(feather);
				await context.SaveChangesAsync();
				return Results.Ok(feather);
			}

			return Results.NotFound();
		}
    }
}

