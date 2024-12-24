# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property before it has been assigned a value.

## The Bug

The `ExampleClass` has a property `MyProperty`. In `MyMethod`, we attempt to print the value of `MyProperty` without initializing it.

This can lead to one of two outcomes:

1. **Unexpected Value:** If the property is a value type (like `int`), it will have its default value (0 for `int`). However, relying on this default value can be problematic, as it might not always be the expected behavior.
2. **Exception:** If you try to access the property through reflection or from a different thread, or if you use certain debugging techniques, you might get a `NullReferenceException`.

## The Solution

The solution is simple: initialize the `MyProperty` before accessing it.