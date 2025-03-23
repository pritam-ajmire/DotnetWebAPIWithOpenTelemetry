# OpenTelemetry Metrics for ASP.NET Core Web API

This guide explains how to integrate OpenTelemetry metrics into your ASP.NET Core Web API project.

## Prerequisites

1. .NET SDK installed on your machine.
2. Visual Studio or Visual Studio Code for development.
3. Basic knowledge of .NET and OpenTelemetry.

## Steps

### 1. Create or Open your ASP.NET Core Web API Project

- Create a new ASP.NET Core Web API project or open your existing ASP.NET Core Web API project.

### 2. Add the Necessary NuGet Packages

To integrate OpenTelemetry for metrics, you need to add the following NuGet packages:

```
dotnet add package OpenTelemetry
dotnet add package OpenTelemetry.Exporter.Prometheus.AspNetCore
dotnet add package OpenTelemetry.Instrumentation.AspNetCore
dotnet add package OpenTelemetry.Instrumentation.Http
dotnet add package OpenTelemetry.Extensions.Hosting
dotnet add package OpenTelemetry.Api
dotnet add package OpenTelemetry.Instrumentation.Runtime
```

### 3. Run the application:

After building and running the application, OpenTelemetry will start collecting metrics. 
The `app.UseOpenTelemetryPrometheusScrapingEndpoint()` method in Program.cs will expose a `/metrics` endpoint where Prometheus or any other metrics monitoring system can scrape the metrics.

Run the application using the following command: `dotnet run`


### 4. Access the Metrics
Once the application is running, you can access the following:

The metrics endpoint at:
http://localhost:{update-your-port}/metrics

Replace {update-your-port} with the appropriate port number for your application.
