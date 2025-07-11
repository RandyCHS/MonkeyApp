# MonkeyApp

MonkeyApp is a .NET 9 console application for managing monkey species data, featuring interactive menus and integration with GitHub MCP servers.

## Features
- List all monkey species with details
- Get details for a specific monkey by name
- Get a random monkey
- Track access counts for each monkey
- Console-based interactive menu
- Extensible for GitHub MCP integration

## Technologies
- .NET 9
- C# 13
- Console UI
- Repository pattern for data access
- Async/await for asynchronous operations

## Project Structure
```
MonkeyApp.sln
MyMonkeyApp/
  Monkey.cs
  MonkeyHelper.cs
  Program.cs
  MyMonkeyApp.csproj
```

## Getting Started
1. **Clone the repository:**
   ```powershell
   git clone https://github.com/RandyCHS/MonkeyApp.git
   ```
2. **Navigate to the project folder:**
   ```powershell
   cd MonkeyApp/MyMonkeyApp
   ```
3. **Build and run the application:**
   ```powershell
   dotnet run
   ```

## Usage
Follow the on-screen menu to list monkeys, view details, or get a random monkey. Press the corresponding number to select an option.

## Coding Standards
- PascalCase for classes, methods, and properties
- camelCase for local variables and parameters
- XML documentation for public members
- Proper exception handling
- Separation of concerns between UI and business logic

## Contributing
Pull requests are welcome! Please follow the coding standards and ensure all code is inside the `MyMonkeyApp` project folder.

## License
This project is licensed under the MIT License.
 
## Acknowledgements
This project was inspired by and references code from the excellent [letslearnmcp-csharp](https://github.com/jamesmontemagno/letslearnmcp-csharp) repository by James Montemagno.

