var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! V2");

app.MapGet("/creditscore", () =>
{
    try
    {
        var result = 3/0;
        Console.WriteLine($"Processing succeeded: {result}");
    }
    catch (Exception e)
    {
        LogError(e, "Processing failed.");
        throw;
    }
    return score;
});

app.Run();
