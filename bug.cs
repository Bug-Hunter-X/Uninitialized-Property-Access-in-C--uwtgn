public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a property before it is assigned can lead to unexpected behavior.
        int x = MyProperty * 2; //Error may occur if MyProperty is not assigned correctly
        // Add more code here
    }
}