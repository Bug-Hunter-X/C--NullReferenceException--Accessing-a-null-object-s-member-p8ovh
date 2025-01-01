public class MyClass {
    public int? MyProperty { get; set; } //Using Nullable<int> to allow null values

    public void MyMethod() {
        // Check for null before accessing MyProperty
        if (MyProperty.HasValue) {
            Console.WriteLine(MyProperty.Value.ToString());
        } else {
            Console.WriteLine("MyProperty is null");
        }
    }
}