var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    Service = "ETI.Api",
    Status = "OK"
}));

app.Run();
