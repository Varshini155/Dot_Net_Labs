// See https://aka.ms/new-console-template for more information
using System;
using oops;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /* Todo myTodo =new Todo() {Name ="Coding",Startdate=DateTime.Now.AddDays(-15),EndDate=DateTime.Now.AddDays(15),IsCompleted=false};
         myTodo.Create(0);
         myTodo.Name = "Angular Training";
         myTodo.Startdate=DateTime.Now.AddDays(-10);
         myTodo.EndDate = DateTime.Now.AddDays(-4);
         myTodo.IsCompleted = true;

         myTodo.Create(1);
         myTodo.ViewTodos();
         myTodo.ViewTodos("Coding");*/

        /*
        Console.WriteLine("--parent p = new Child()--");
        //Base class  = new DerivedClass()
        Parent Meena = new Child();
        Meena.ChooseCareer();
        Meena.NoNightOut();


        Console.WriteLine("--Child ch = new Child()--");
        Child nxgenChild=new Child();
        nxgenChild.NoNightouts();
        */

        //base = new Derived
        // Shape sh =new circle() { Radius = 5 };
        //sh.Draw();


        /*
        IEmpContract mayur = new KpmgEmployee();
        Console.WriteLine("In KPMG, "+mayur.SickLeavesClause());
        Console.WriteLine("In KPMG ,"+mayur.WorkHoursClause());

        Console.WriteLine();
        IEmpContract Preetham = new DellEmployee();
        Console.WriteLine("In Dell, "+Preetham.SickLeavesClause());
        Console.WriteLine("In Dell, "+Preetham.WorkHoursClause());
        */

        IProjectRequirement employee = new TaxTeam();
        Console.WriteLine(employee.GetUserStories());
        Console.WriteLine(employee.GetStoryStatus());

    }

} 
