namespace InheritanceApp;

public class AccessModifiers
{
    class BaseCLass
    {
        public int field1 = 1;
        protected int field2 = 2;
        private int field3 = 3;

        public void Display()
        {
            Console.WriteLine($"field1: {field1}, field2: {field2}, field3: {field3}");
        }

    }

    class Derivedlass : BaseCLass
    {
        public void Display()
        {
            Console.WriteLine($"field1: {field1}, field2: {field2}"); //can only access field1 & field2
        }
    }
    
    
}