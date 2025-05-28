# csnakes_demo
A .NET 9.0 project demonstrating C#/.NET integration with Python, leveraging the incredible [CSnakes.Runtime](https://www.nuget.org/packages/CSnakes.Runtime/) runtime.

## Features
- .NET 9.0 support
- Python interoperability (see `demo.py`)
- Uses [CommunityToolkit.HighPerformance](https://github.com/CommunityToolkit/dotnet) for optimized performance
- Logging and configuration via [Microsoft.Extensions.*](https://github.com/dotnet/runtime/tree/main/src/libraries/Microsoft.Extensions)
- Includes [CSnakes.Runtime](https://www.nuget.org/packages/CSnakes.Runtime/) for Python/.NET interop

## Getting Started

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/)
- [Python 3.12+](https://www.python.org/) (installed upon first run)

### Build
```sh
dotnet build
```

### Run
```sh
dotnet run
```
## Project Structure
- `Program.cs` - Main .NET entry point
- `demo.py` - Python demo script
- `calc.py` - Python module for calculations
- `csnakes.csproj` - Project file

## Attributions
- [CommunityToolkit.HighPerformance](https://github.com/CommunityToolkit/dotnet)
- [Microsoft.Extensions.*](https://github.com/dotnet/runtime/tree/main/src/libraries/Microsoft.Extensions)
- [CSnakes.Runtime](https://www.nuget.org/packages/CSnakes.Runtime/)
- [ZstdSharp.Port](https://github.com/oleg-st/ZstdSharp)
- [System.Numerics.Tensors](https://github.com/dotnet/runtime)
