using OpenScienceProjects.API.Extensions;

namespace OpenScienceProjects.API;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

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

        app.MapControllers();
    }
}