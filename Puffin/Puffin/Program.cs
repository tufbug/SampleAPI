using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Puffin.DataAccess.Data;
using Puffin.DataAccess.Entities;
using Puffin.Endpoints;
using Puffin.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IValidator<Feather>, FeatherValidator>();
builder.Services.AddDbContext<PuffinDbContext>(opt => opt.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));

var app = builder.Build();

app.MapFeathersEndpoints();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();