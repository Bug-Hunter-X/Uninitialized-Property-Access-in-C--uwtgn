public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value; //Ensure MyProperty is initialized in the constructor
    }

    public void MyMethod()
    {
        // MyProperty is guaranteed to be initialized here
        int x = MyProperty * 2;
        // Add more code here
    }
}