using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome to the Journal Program! ");

        Questions qst1 = new Questions();
        Questions qst2 = new Questions();
        Questions qst3 = new Questions();
        Questions qst4 = new Questions();
        Questions qst5 = new Questions();

        Questions asw1 = new Questions();
        Questions asw2 = new Questions();
        Questions asw3 = new Questions();
        Questions asw4 = new Questions();
        Questions asw5 = new Questions();
        
        Console.WriteLine(qst1._question1);
        asw1._answer1 = Console.ReadLine();


        Journal myJournal = new Journal();
        myJournal._questions.Add(qst1);
        myJournal._questions.Add(asw1);

        myJournal.Display();      

    }
}