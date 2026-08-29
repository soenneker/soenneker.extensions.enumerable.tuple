[![](https://img.shields.io/nuget/v/Soenneker.Extensions.Enumerable.Tuple.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Extensions.Enumerable.Tuple/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.enumerable.tuple/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.enumerable.tuple/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Extensions.Enumerable.Tuple.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Extensions.Enumerable.Tuple/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.enumerable.tuple/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.enumerable.tuple/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Enumerable.Tuple
Extension methods for querying and transforming sequences of `System.Tuple` values with element-aware comparisons.

## Installation

```bash
dotnet add package Soenneker.Extensions.Enumerable.Tuple
```

## Usage

```csharp
using Soenneker.Extensions.Enumerable.Tuple;

var routes = new[]
{
    Tuple.Create("ORD", "DFW"),
    Tuple.Create("DFW", "LAX")
};

bool exists = routes.ContainsItem("ORD", "DFW"); // true
bool reverseExists = routes.ContainsItem("DFW", "ORD"); // false
```

Both tuple positions must match, in order, using `EqualityComparer<T>.Default`. Enumeration stops at the first match and null tuples in the sequence are skipped. The overload accepting a `Tuple<TFirst,TSecond>` throws `ArgumentNullException` when that tuple is null; a null source also throws.

This package targets `System.Tuple<,>`, not C# value tuples such as `(string, string)`.
