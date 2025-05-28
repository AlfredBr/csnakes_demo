using CSnakes.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        var home = Path.Join(Environment.CurrentDirectory, "."); // Path to your Python modules, alongside the executable
        services.WithPython().WithHome(home).FromRedistributable(); // Download Python 3.12 and store it locally
    });

var app = builder.Build();
var env = app.Services.GetRequiredService<IPythonEnvironment>();

var demo = env.Demo();
var result = demo.HelloWorld("Alfred");
Console.WriteLine(result);

var calc = env.Calc();
var sum = calc.Add(1, 2);
Console.WriteLine(sum);
var diff = calc.Sub(5, 3);
Console.WriteLine(diff);
var product = calc.Mul(3, 4);
Console.WriteLine(product);
var quotient = calc.Div(10, 2);
Console.WriteLine(quotient);
