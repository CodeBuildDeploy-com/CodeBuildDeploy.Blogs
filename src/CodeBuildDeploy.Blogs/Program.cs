using Serilog;
using Serilog.Formatting.Json;
using Serilog.Extensions.Hosting;

using CodeBuildDeploy.Blogs.DI;

var logConfiguration = new LoggerConfiguration().Enrich.FromLogContext().WriteTo.Async(a => a.Console(new JsonFormatter()));
var reloadableLogger = logConfiguration.CreateBootstrapLogger();
Log.Logger = reloadableLogger;

try
{
    Log.Information("Creating WebApplicationBuilder");
    var builder = WebApplication.CreateBuilder(args);

    Log.Information("Reconfiguring Logging");
    await ConfigureLoggingAsync(builder, reloadableLogger);

    Log.Information("Configuring Services");
    builder.Services.ConfigureApiServices();

    Log.Information("Building WebApplication");
    var app = builder.Build();

    Log.Information("Configuring WebApplication");
    await ConfigureAppAsync(app);

    Log.Information("Running WebApplication");
    await app.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Unhandled Exception");
}
finally
{
    Log.Information("WebApplication Shutdown");
    Log.CloseAndFlush();
}

static async Task ConfigureLoggingAsync(WebApplicationBuilder builder, ReloadableLogger reloadableLogger)
{
    reloadableLogger.Reload(config => config.ReadFrom.Configuration(builder.Configuration)
                                            .Enrich.FromLogContext()
                                            .WriteTo.Async(a => a.Console(new JsonFormatter())));
    Log.Logger = reloadableLogger.Freeze();

    builder.Host.UseSerilog();
    await Task.CompletedTask;
}

static async Task ConfigureAppAsync(WebApplication app)
{
    app.UseSwagger(options => { options.RouteTemplate = "swagger/blogs/{documentName}/spec.json"; })
       .UseSwaggerUI(c =>
        {
            c.RoutePrefix = "swagger/blogs";
            c.SwaggerEndpoint("v1/spec.json", "Code Build Deploy Blogs API v1");
        });

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.UseHealthChecks($"/v1/healthcheck");

    await Task.CompletedTask;
}