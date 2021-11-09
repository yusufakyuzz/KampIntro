using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            isimler.Add("Yusuf");
           foreach (var item in isimler.Item)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine(isimler.Lenght);
           

            

        }
    }
}
