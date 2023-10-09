using OpenScienceProjects.API.Extensions;

namespace OpenScienceProjects.API;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
            {
                builder
                    .AllowAnyOrigin() // Permitir qualquer origem (Isso é apenas para fins de desenvolvimento; ajuste conforme sua necessidade)
                    .AllowAnyMethod() // Permitir qualquer método HTTP
                    .AllowAnyHeader(); // Permitir qualquer cabeçalho HTTP
            });
        });
        services.AddExceptionHandler(options =>
        {
            options.ExceptionHandler = GlobalExceptionHandler.Handle;
            options.AllowStatusCode404Response = true;
        });

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddApplicationServices();
    }

    public void Configure(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        app.UseCors();

        app.MapControllers();
    }
}