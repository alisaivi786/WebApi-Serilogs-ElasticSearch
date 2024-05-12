using Common.Logging;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
DateTime startTime = DateTime.Now;
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Serilog
builder.Host.UseSerilog(Logging.ConfigureLogger);



var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();
app.MapGet("/", () => {
   
    TimeSpan uptime = DateTime.Now - startTime;
    // Log the system info
    //Log.Information($"System info: HealthCare Api Server is Running {uptime.Hours} hour {uptime.Minutes} minute {uptime.Seconds} second and {uptime.Milliseconds} millisecond");
    return $"HealthCare Api Server is Running {uptime.Hours} hour {uptime.Minutes} minute {uptime.Seconds} second and {uptime.Milliseconds} millisecond";
}).ExcludeFromDescription();

app.Run();

