using Program;

namespace Delegates
{
    class function
    {
        static void Main()
        {

            DelegateET obj = new DelegateET();

            MyDelegate delegate1 = obj.Method1;
            MyDelegate delegate2 = obj.Method2;

            delegate1("This is first Delegate");
            delegate2("This is second Delegate");


    }
    }
}
