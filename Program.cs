//https://dev.to/thnery/create-an-aws-ecs-cluster-using-terraform-g80
//API built with following tutorial
//https://www.moesif.com/blog/technical/api-development/Building-Minimal-API-with-Dotnet/
using System;
using System.IO;
using System.Net;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
{
    var dataResponse = "Hello World! V6";
    Console.WriteLine($"Request Served");
    return dataResponse;

});

app.MapGet("/loaderio-e78bf51e241c1cec5b6d5095283acdab.html", () => 
{
    var dataResponse = "loaderio-e78bf51e241c1cec5b6d5095283acdab";
    Console.WriteLine($"Request Served");
    return dataResponse;

});

app.MapGet("/score", () =>
{
        try
        {
            using (StreamReader sr = File.OpenText("data.txt"))
            {
                Console.WriteLine($"The first line of this file is {sr.ReadLine()}");
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"The file was not found: '{e}'");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine($"The directory was not found: '{e}'");
        }
        catch (IOException e)
        {
            Console.WriteLine($"The file could not be opened: '{e}'");
        }
});

app.Run();
