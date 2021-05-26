FluentBoolean is a set of bool's extension methods.  
With this library you can use the fluent interface for the classic boolean's operations (NOT, OR, AND, XOR, NOR, NAND, XNOR)

Install with [NuGet](https://www.nuget.org/packages/FluentBoolean):
``` NuGet
Install-Package FluentBoolean -Version 1.1.0
```

Examples:
```C#
using FluentBoolean;

public void ChainedOr()
{
    var fluentResult = true
        .OR(false)
        .OR(true)
        .OR(true);

    var classicResult = true || false || true || true;

    //fluentResult and classicResult produce the same result
}
```
```C#
using FluentBoolean;

public void ChainedAnd()
{
    var fluentResult = true
        .AND(false)
        .AND(true)
        .AND(true);

    var classicResult = true && false && true && true;

    //fluentResult and classicResult produce the same result
}
```
```C#
using FluentBoolean;

public void MultipleOr()
{
    var fluentResult = true
        .OR(false, true);

    var classicResult = true || false || true;

    //fluentResult and classicResult produce the same result
}
```