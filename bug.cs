public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized.
        Console.WriteLine(MyProperty); // This line might throw an exception 
    }
}