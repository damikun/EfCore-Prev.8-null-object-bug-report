# EfCore-Prev.8-null-object-bug-report
This is bug reproduce repo... do not use this as example!

Related to bug: https://github.com/dotnet/efcore/issues/22348

# To Run
```
1 Fetch to local Git
2 Run: dotnet restore
3 Run: dotnet wacth run
4 Use controler to generate error on address: https://localhost:5001/api/Issue/Test/
```

# Test
```

[HttpGet]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
[ProducesResponseType(StatusCodes.Status401Unauthorized)]
public async Task<ActionResult> Test() {

    List<User_DTO> db_enity = await _context.Users.AsNoTracking()
    .Include(e=>e.Role)
    .Select(e=> new User_DTO(){
        ID = e.ID,
        Role =  new Role_DTO {
        ID = e.Role.ID,
        Name = e.Role.Name,
    },
    }).ToListAsync();

    return Ok("Success");
}

```



# Packages:

You can comment out older version to check that it was working before...

```
 <ItemGroup>
    <PackageReference Include="HotChocolate" Version="10.5.0-rc.1" />
    <PackageReference Include="HotChocolate.AspNetCore" Version="10.5.0-rc.1" />
    <PackageReference Include="HotChocolate.AspNetCore.Playground" Version="10.5.0-rc.1" />
    <PackageReference Include="HotChocolate.AspNetCore.Voyager" Version="10.5.0-rc.1" />
    <PackageReference Include="HotChocolate.Types" Version="10.5.0-rc.1" />
    <PackageReference Include="HotChocolate.Types.Filters" Version="10.5.0-rc.1" />
    <PackageReference Include="HotChocolate.Types.Selections" Version="10.5.0-rc.1" />
    <PackageReference Include="HotChocolate.Types.Sorting" Version="10.5.0-rc.1" />
    <PackageReference Include="Microsoft.AspNetCore.Mvc.NewtonsoftJson" Version="3.1.5" />
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="5.0.0-preview.5.20278.2" />
    <PackageReference Include="Newtonsoft.Json" Version="12.0.3" />
    <PackageReference Include="Microsoft.Data.Sqlite.Core" Version="5.0.0-preview.5.20278.2" />
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="5.0.0-preview.5.20278.2" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="5.0.0-preview.5.20278.2" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="5.0.0-preview.5.20278.2">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
 
  </ItemGroup>

```