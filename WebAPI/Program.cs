using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

ConfigurationManager configuration = builder.Configuration;
var option = configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>( options =>
    options.UseSqlServer(configuration.GetConnectionString(option)));

services.AddEndpointsApiExplorer();
services.AddMyOwnAutoMapper();
services.AddSwaggerGen();
services.AddMyOwnScopedServices();
services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();


app.Run();
