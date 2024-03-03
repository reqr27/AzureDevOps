using AzureDevOps;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Configuration
//    .SetBasePath(builder.Environment.ContentRootPath)
//    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//    .AddJsonFile("appsettings.Dev.json", optional: true) // Add this line
//    .AddJsonFile("appsettings.Prod.json", optional: true) // Add this line

//    .AddEnvironmentVariables();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.isDevOrTest())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => {
        options.EnableTryItOutByDefault();
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
