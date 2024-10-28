using System.Drawing;
using System.Runtime;

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
                Console.WriteLine(_score);
                Console.WriteLine("Menu");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Record Event");
                Console.WriteLine("5. Quit");

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

                }
                else if (choice == "4")
                {

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
                SimpleGoal simple = new SimpleGoal(name, desc, points);
                _goals.Add(simple);

                break;

            }
            if (choice == "2")
            {
                EternalGoal eternal = new EternalGoal(name, desc, points);
                _goals.Add(eternal);

                break;
            }
            if (choice == "3")
            {
                Console.WriteLine("What is the bonus points?");
                bonus = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the ?");
                target = int.Parse(Console.ReadLine());
                ChecklistGoal check = new ChecklistGoal(name, desc, points, bonus, target);
                _goals.Add(check);
                Console.WriteLine(_goals);
                break;
            }

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

    }
    public void LoadGoals()
    {

    }

}