using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
internal class Program
{
    class MyClass
    {
        //public int id;
        private int id;

        public int MyProperty { get; set; }

    }

    private static void Main(string[] args)
    {
        MyClass my = new MyClass();
    }
}