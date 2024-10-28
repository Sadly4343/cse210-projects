using System;
using System.Runtime.Intrinsics;
//Added a method in the goalmanager to have a levelup after user reaches
// a score of over 500! Displays Levelup and will continue to display and 
//show them. The other thing added was a method with the goal class so that 
//member variables are kept private and can apply the score towards the goalmanager easier from points.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop06 World!");
        GoalManager game = new GoalManager();
        game.start();
    }
}