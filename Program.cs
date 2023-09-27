var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! V2");

app.MapGet("/creditscore", () =>
{
    try
    {
        Console.WriteLine($"Processing succeeded: {3 + 5}");
    }
    catch (Exception e)
    {
        LogError(e, "Processing failed.");
        throw;
    }
    return score;
});

app.Run();
