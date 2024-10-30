using Microsoft.EntityFrameworkCore;
using VueFinanceNET.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AssetsRepository>(options =>
{
    options.UseNpgsql( builder.Configuration.GetConnectionString("DefaultConnection") );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // TODO
    // move to below once dotnet 9 is released
    // https://www.nuget.org/packages/Scalar.AspNetCore
    // https://www.youtube.com/watch?v=8yI4gD1HruY
    // app.MapOpenApi();
    
    // swagger is no longer included in dotnet 9
    // app.UseSwagger(options =>
    //     {
    //         options.RouteTemplate = "openapi/{documentName}/openapi.json";
    //     });
    app.UseSwagger();
    app.UseSwaggerUI();
    
    // app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();