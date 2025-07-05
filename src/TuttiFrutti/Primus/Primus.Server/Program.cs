using Microsoft.EntityFrameworkCore;
using PrimusBackend.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<MeasDbContext>(opt => {
    opt.UseSqlite(builder.Configuration.GetConnectionString("DbConnectionString"));
});

var app = builder.Build();

app.UseDefaultFiles();
app.MapStaticAssets();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// ToDo: ANOTHER FALLBACK REQUIRED
app.MapFallbackToFile("/index.html");

app.Run();
