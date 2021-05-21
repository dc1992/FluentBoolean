FluentBoolean is a set of bool's extension methods.  
WIth this library you can use the fluent interface for the classic boolean's operations (NOT, OR, AND, XOR, NOR, NAND, XNOR)

Examples:
```C#
using FluentBoolean;

public void Test()
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

public void Test()
{
    var fluentResult = true
        .AND(false)
        .AND(true)
        .AND(true);

    var classicResult = true && false && true && true;

    //fluentResult and classicResult produce the same result
}
```
