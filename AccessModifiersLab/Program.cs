using System;

namespace AccessModifiersLab
{
    // 1. Базовий клас
    public class BaseClass
    {
        public string PublicField = "Public: доступний з будь-якого місця в коді";
        private string PrivateField = "Private: доступний";
        protected string ProtectedField = "Protected: доступний";
        internal string InternalField = "Internal: доступний";

        private string ProtInternalField = "Protected Internal: нащадки АБО та ж збірка";
        private protected string PrivateProtectedField = "Private Protected: Private Protected: нащадок ТОБТО в тій самій збірці";

        public void ShowAccessFromInside()
        {
            Console.WriteLine("Зсередини класу BaseClass:");
            Console.WriteLine(PublicField);
            Console.WriteLine(PrivateField);
            Console.WriteLine(ProtectedField);
            Console.WriteLine(InternalField);
            Console.WriteLine(ProtInternalField);
            Console.WriteLine(PrivateProtectedField);
        }
    }
    public class DerivedClass : BaseClass
    {
        public void TestAccessFromDerived()
        {
            Console.WriteLine("Зсередини класу DerivedClass:");
            Console.WriteLine(PublicField);
            // Console.WriteLine(PrivateField); // Недоступно
            Console.WriteLine(ProtectedField);
            Console.WriteLine(InternalField);
            // Console.WriteLine(ProtInternalField); // Недоступно
            Console.WriteLine(PrivateProtectedField);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BaseClass bc = new BaseClass();
            Console.WriteLine("З класу Main:");
            Console.WriteLine(bc.PublicField);
            // Console.WriteLine(bs.PrivateField); // Недоступно
            // Console.WriteLine(bs.ProtectedField); // Недоступно
            Console.WriteLine(bc.InternalField);
            // Console.WriteLine(bs.PrivateProtectedField); // Недоступно

            bc.ShowAccessFromInside();

            DerivedClass dc = new DerivedClass();
            dc.TestAccessFromDerived();

            Console.ReadKey();



        }
    }
}