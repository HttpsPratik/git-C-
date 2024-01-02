namespace Generics
{
    public class Program<T> 
    {
       public T field;
        public Program(T value) { 
        field = value;

        }
        public T GetValue()
        {
            return field;
        }
    }
}
