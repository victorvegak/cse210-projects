using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text.Json;

class Program
{


    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();
        int userPoints = 0;
        List<Badge> userBadges =  new List<Badge> ();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {userPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("  7. Display Badges");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goals);
                    break;
                case "2":
                    DisplayGoals(goals);
                    break;
                case "3":
                    Console.Write("What is the Filename for the goal file? ");
                    string fileName = Console.ReadLine();
                    SaveGoals(goals, fileName);
                    break;
                case "4":
                    Console.Write("What is the Filename for the goal file? ");
                    string loadFileName = Console.ReadLine();
                    goals = LoadGoalsFromFile(loadFileName);
                    break;
                case "5":
                    RecordEvent(goals, ref userPoints,userBadges);
                    
                    break;
                case "7":
                    DisplayUserBadges(userBadges);
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goals");
        Console.WriteLine("2. Eternal Goals");
        Console.WriteLine("3. Checklist Goals");

        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int basePoints = int.Parse(Console.ReadLine());

        int requiredPoints = basePoints; 

        Goal newGoal = null;

        switch (goalType)
        {
            case "1":
                newGoal = new Simple(name, description, basePoints, requiredPoints);
                break;
            case "2":
                
                newGoal = new Eternal(name, description, basePoints);
                break;

                
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());

                newGoal = new Checklist(name, description, basePoints, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        goals.Add(newGoal);
        Console.WriteLine("New goal added successfully!");
    }

    static void DisplayGoals(List<Goal> goals)
    {
        Console.WriteLine("\nCurrent Goals:");

        if (goals == null || goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        for (int index = 0; index < goals.Count; index++)
        {
            Goal goal = goals[index];

            if (goal != null)
            {
                Console.Write($"{index + 1}. ");

                if (goal.IsComplete)
                {
                    Console.WriteLine($"[X] {goal.GetName()}: {goal.GetDescription()} - {goal.GetPoints()} points");
                }
                else
                {
                    Console.Write($"[ ] {goal.GetName()}: {goal.GetDescription()} - ");

                    if (goal.GetType() == typeof(Eternal))
                    {
                        Console.WriteLine($"");
                    }
                    else if (goal.GetType() == typeof(Simple))
                    {
                        Simple simpleGoal = (Simple)goal;
                        if (!simpleGoal.IsComplete)
                        {
                            Console.WriteLine($"{simpleGoal.GetBasePoints()} Points (Simple)");
                        }
                        else
                        {
                            Console.WriteLine($"-- Completed: {simpleGoal.GetPoints()} / {simpleGoal.GetRequiredPoints()} (Simple)");
                        }
                        
                    }
                    else if (goal.GetType() == typeof (Checklist))
                    {
                        Checklist checklistGoal = (Checklist)goal;
                        Console.WriteLine($"-- Currently completed: {checklistGoal.CompletedItems} / {checklistGoal.TargetCount}");
                    }    
                    else
                    {
                        Console.WriteLine($"{goal.GetPoints()} points");
                    }
                    
                }
            }
        }

    }
    static void AwardBadges(List<Badge> userBadges, List<Goal>goals)
    {
        int completedGoalsCount = goals.Count(goal => goal.IsComplete);
        if (completedGoalsCount >= 3)
        {
            Badge goalMasterBadge = new Badge("Goal Master", "Awarded for completing goals");
            userBadges.Add(goalMasterBadge);
            Console.WriteLine($"Congratulations! You earned the {goalMasterBadge.Name} badge!");
        }
    }

    static void DisplayUserBadges(List<Badge> userBadges)
    {
        Console.WriteLine("\nYour Badges:");

        foreach (Badge badge in userBadges)
        {
            Console.WriteLine($"{badge.Name}: {badge.Description} ({(badge.IsEarned ? "Earned" : "Earned")})");
        }
    }

    static void RecordEvent(List<Goal> goals, ref int userPoints, List<Badge> userBadges)
    
    {
        Console.WriteLine("\nRecord an Event:");

        // Display the available goals
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }

        // Ask the user which goal they accomplished
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];

            // Record an event for the selected goal
            int pointsEarned = goal.RecordEvent();
            userPoints += pointsEarned;

            Console.WriteLine($"Event recorded for {goal.GetName()}! Earned {pointsEarned} points");

            DisplayGoals(goals); // this display updated goals

            // After recording an event, check if the user has earned any badges
            AwardBadges(userBadges, goals);
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }


    static void SaveGoals(List<Goal> goals, string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetRepresentation());
            }
            
        }

        Console.WriteLine($"Goals saved to {fileName}.");
    }

    static List<Goal> LoadGoalsFromFile(string fileName)
    {
        

        List<Goal> loadedGoals = new List<Goal>();

        try
        {
            string[] lines = File.ReadAllLines(fileName);

            // Check if there are lines in the file
            if (lines.Length > 0)
            
                {
                    // Start from the second line to read goals
                    for (int i = 0; i < lines.Length; i++)
                    {
                        // Console.WriteLine($"Reading line {i}: {lines[i]}");
                        Goal loadedGoal = Goal.CreateGoalFromString(lines[i]);
                        if (loadedGoal != null)
                        {
                            loadedGoals.Add(loadedGoal);
                        }
                    }

                    Console.WriteLine($"Goals loaded from {fileName}.");
                }
            
            else
            {
                Console.WriteLine("Empty file. No goals loaded.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File {fileName} not found. No goals loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
        }
        
        return loadedGoals;
    }

}
