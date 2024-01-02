using System;

class Loop
{
    static void Main(String[] args)

    {
        /*DO WHILE
        int i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i <= 10) ;
        */


        /*BREAK
         for (int i=1; i<=10; i++)
        {
            if (i == 5)
                break;
            Console.WriteLine(i);
        }
        */

        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
                continue;
            Console.WriteLine(i);
        }
    }
}
