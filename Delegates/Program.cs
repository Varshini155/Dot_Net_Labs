using System;
using System.Collections.Generic;
using System.Linq;
using oops;
using System.Security.Cryptography;
using System.Threading;

class Program
{
    //Created  a new datatype
    //Viz . DECLARATION OF DELEGATE
    public delegate void PM(string requirement);

    static void Main()
    {
        // LinQLambda();
        Thread t1 = new Thread(()=>
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Hand movement animation y ::co-ordinate " + i );
            }
        });
        t1.Name = "Hand Animation";

        Thread t2 = new Thread(() =>
        {
            for (int i =1000; i >0; i--)
            {
                Console.WriteLine("Ball movement animation y ::co-ordinate " + i);
            }
        });
         t2.Name = "Ball Animation";


        t1.Start();
        t2.Start();
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("========== The game has completed=======");
























        /*List<string> names = new List<string>();
        names.Add("Meena");
        names.Add("Teena");
        names.Add("Reena");
        names.Add("Sanjay");

        names.ForEach((str) => {
            Console.WriteLine(str);
        });

        List<string> result = names.Where((str) => { return str.StartsWith("Sa") && str.EndsWith("jay"); }).ToList();

        Console.WriteLine("Search for 'Reena'");
        result.ForEach((str) => {  
            Console.WriteLine("Found match for " +str); 
        });


        //LINQ => Language Integrated query == SQL in .Net
        Console.Write("--- USING LINQ----");
        var queryOutput = (from str in names 
                           where
 str.Contains("Reena") && str.Contains("Chakravarthy")
                         select str).ToList();
        queryOutput.ForEach((str) => { Console.WriteLine(str); });

                          

       

        //OBJECT or INSTANTIATE OF DELGATE
       // PM Vimal = new PM((requirement) => { Console.WriteLine("I Mayur have attended the training");});
        //Vimal += (requirement) => { Console.WriteLine("I Sanjay have attended the training"); };
       // Vimal += (requirement) => { Console.WriteLine("I Preetham have attended the training"); };

       // Vimal("Tax training for team");

        */
    }

    private static void LinQLambda()
    {
        List<Rectangle> rectangle = new List<Rectangle>();
        rectangle.Add(new Rectangle(10, 5));
        rectangle.Add(new Rectangle(10, 3));
        rectangle.Add(new Rectangle(20, 7));
        rectangle.Add(new Rectangle(25, 5));

        rectangle.Where((r) => { return r.Length == 10; })
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine("Length: " + r.Length + " | Breadth :" + r.Breadth);
            });

        var searchedRectangles = from r in rectangle
                                 where r.Length == 10 && r.Breadth == 5
                                 select r;

        searchedRectangles
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine("Output from LINQ : Recatangle length X Breadth :" + r.Length + "X" + r.Breadth);
            });
    }

}