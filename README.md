# this project is a study to update from .NET 7 to .NET 8

### 1. **Install .NET 8 SDK**
First, ensure that you have the .NET 8 SDK installed on your system. You can download it from the official [.NET download page](https://dotnet.microsoft.com/download/dotnet/8.0).

### 2. **Update the Target Framework in `.csproj`**
Next, update the target framework in your project's `.csproj` file from `net7.0` to `net8.0`.

Change this line:
```xml
<TargetFramework>net7.0</TargetFramework>
```
To:
```xml
<TargetFramework>net8.0</TargetFramework>
```

### 3. **Update NuGet Packages**
You'll also need to update the NuGet packages to the latest versions that are compatible with .NET 8. You can do this manually by modifying the versions in your `.csproj` file, or by using the `dotnet add package` command.

#### Update the package references in your `.csproj` file:
```xml
<ItemGroup>
  <PackageReference Include="Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore" Version="8.0.8" />
  <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="8.0.8" />
  <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="8.0.8" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.8" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.8">
    <PrivateAssets>all</PrivateAssets>
    <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
  </PackageReference>
  <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="8.0.4" />
</ItemGroup>
```

#### you have also to update them via the command line:

```bash
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore --version 8.0.8
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.8
dotnet add package Microsoft.AspNetCore.Identity.UI --version 8.0.8
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.8
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.8
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 8.0.4
```

### 4. **Restore and Rebuild the Project**
After updating the framework and packages, restore the packages and rebuild the project:

```bash
dotnet restore
dotnet build
```

### 5. **Run the Application**
Finally, run the application to ensure everything works as expected:

```bash
dotnet run
```

