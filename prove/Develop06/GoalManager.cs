using System.Drawing;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();

        _score = 0;
    }

    public void start()
    {
        {
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine(_score);
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                LevelUp();

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    CreateGoal();
                }
                else if (choice == "2")
                {
                    ListGoalDetails();

                }
                else if (choice == "3")
                {
                    SaveGoals();
                }
                else if (choice == "4")
                {
                    LoadGoals();
                }
                else if (choice == "5")
                {
                    RecordEvent();
                }
                else if (choice == "6")
                {
                    break;
                }

            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_score);
    }
    public void ListGoalNames()
    {
        Console.WriteLine(_goals);
    }
    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }

    }
    public void LevelUp()
    {
        if (_score >= 500)
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(5);

            while (DateTime.Now < endTime)
            {
                Console.Write("=");
                Thread.Sleep(1000);
                Console.Write("/");
                Thread.Sleep(1000);
                Console.Write("!");
                Console.WriteLine("LEVEL UP");
            }

        }
    }
    public void CreateGoal()
    {
        //declare local vars name description points
        string name;
        string desc;

        //prompt user for goal type
        // ie. press 1 for eternal goala 
        // press 2 for simple

        //while () to prompt user for goal type and name, desc, score
        // if option = 1
        // create goal(name, desc, score

        while (true)
        {
            int points;
            int target;
            int bonus;
            bool complete;
            int amountCompleted;
            Console.WriteLine("Choose a goal");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string choice = Console.ReadLine();
            Console.WriteLine("What is the name of your goal?");
            name = Console.ReadLine();
            Console.WriteLine("What is the short description?");
            desc = Console.ReadLine();
            Console.WriteLine("How many points is your goal?");
            points = int.Parse(Console.ReadLine());
            if (choice == "1")
            {
                complete = false;
                SimpleGoal simple = new SimpleGoal(name, desc, points, complete);
                _goals.Add(simple);

                break;

            }
            else if (choice == "2")
            {
                EternalGoal eternal = new EternalGoal(name, desc, points);
                _goals.Add(eternal);

                break;
            }
            else if (choice == "3")
            {
                amountCompleted = 0;
                Console.WriteLine("What is the bonus points?");
                bonus = int.Parse(Console.ReadLine());
                Console.WriteLine("What is target number for bonus?");
                target = int.Parse(Console.ReadLine());
                ChecklistGoal check = new ChecklistGoal(name, desc, points, bonus, amountCompleted, target);
                _goals.Add(check);
                Console.WriteLine(_goals);
                break;
            }
            break;

        }



    }
    public void RecordEvent()
    {
        Console.WriteLine("Select a goal from the list ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1} {_goals[i].GetDetailsString()}");
        }
        int choice;
        while (true)
        {
            Console.WriteLine("Choose a number ");
            choice = int.Parse(Console.ReadLine());
            if (choice > 0 && choice <= _goals.Count)
            {
                Goal goal = _goals[choice - 1];
                goal.RecordEvent();
                _score += goal.GetPoints();
                Console.WriteLine("event recorded");
            }
            break;
        }

    }
    public void SaveGoals()
    {
        Console.WriteLine("Where would you like to save your goals? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresenation());
            }
        }


    }
    public void LoadGoals()
    {
        Console.WriteLine("What is your file to open? ");
        string filename = Console.ReadLine();
        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(",");
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            Goal goal;
            if (goalType == "EternalGoal")
            {
                goal = new EternalGoal(name, description, points);

            }
            else if (goalType == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[4]);
                goal = new SimpleGoal(name, description, points, complete);

            }
            else if (goalType == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                goal = new ChecklistGoal(name, description, points, bonus, amountCompleted, target);

            }
            else
            {
                break;
            }
            _goals.Add(goal);



        }

    }

}