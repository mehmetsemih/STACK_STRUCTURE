namespace STACK_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STACK DESCRIBING 

            var Karakter_yığını=new Stack<char>();

            //ADDING
            Karakter_yığını.Push('A');
            Console.WriteLine(Karakter_yığını.Peek());
            Karakter_yığını.Push('B');
            Console.WriteLine(Karakter_yığını.Peek());
            Karakter_yığını.Push('C');
            Console.WriteLine(Karakter_yığını.Peek());
            Karakter_yığını.Push('D');
            Console.WriteLine(Karakter_yığını.Peek());
            Karakter_yığını.Push('E');
            Console.WriteLine(Karakter_yığını.Peek());
            //NOT:MY PURPOSE IN THE ABOVE IS TO SHOW HOW THE PEEK STRUCTURE WORKS.

            //REMOVAL PROCESS
            Console.WriteLine(Karakter_yığını.Pop()+" ifadesi çıkartıldı.");
            Console.WriteLine(Karakter_yığını.Pop() + " ifadesi çıkartıldı.");
            Console.WriteLine(Karakter_yığını.Pop() + " ifadesi çıkartıldı.");
            Console.WriteLine(Karakter_yığını.Pop() + " ifadesi çıkartıldı.");
            Console.WriteLine(Karakter_yığını.Pop() + " ifadesi çıkartıldı.");


            //ADDING WITH FOR LOOP
            for (int i = 65; i <=90; i++)
            {
                Karakter_yığını.Push((char)i);
                Console.WriteLine($"{Karakter_yığını.Peek()}"+" ifadesi yığına eklendi");

            }

            //REMOVAL PROCESS WITH WHILE LOOP
            while (Karakter_yığını.Count() > 0)
            {
               
                Console.WriteLine($"{Karakter_yığını.Pop()}" +" ifadesi yığından çıkartıldı.");
            }















            Console.ReadLine();
        }
    }
}
