using OpenTelemetry.Metrics;
using OpenTelemetry;
using OpenTelemetry.Resources;
//using OpenTelemetry.Exporter.pr
//using OpenTelemetry.Exporter.OpenTelemetryProtocol;
//using OpenTelemetry.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
builder.Services.AddOpenTelemetry()
    .WithMetrics(options =>
    {
        options.SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("YourServiceName"));
        options.AddAspNetCoreInstrumentation(); options.AddHttpClientInstrumentation();
        options.AddRuntimeInstrumentation();
        options.AddPrometheusExporter();
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Open Telemetry tracing


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseOpenTelemetryPrometheusScrapingEndpoint();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
