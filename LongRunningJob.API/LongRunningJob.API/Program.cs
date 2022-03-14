using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


// Register the Swagger generator, defining 1 or more Swagger documents
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        //TODO: offload to appsettings later
        Version = "v1",
        Title = "My API to Run Long-running Jobs",
        Description = "Basic structure of API to request long-running jobs for and to poll the job status periodically.",
        TermsOfService = new Uri("https://myapi.com/tos"),
        Contact = new OpenApiContact
        {
            Name = "Debbie Developer",
            Email = "developer@myapi.com",
        }
    });

    //Set the comments path for the swagger json and UI.
    var basePath = AppContext.BaseDirectory;
    foreach (var name in Directory.GetFiles(basePath, "*.XML", SearchOption.AllDirectories))
    {
        c.IncludeXmlComments(name, includeControllerXmlComments: true);
    }

});




var app = builder.Build();


app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();


app.Run();
