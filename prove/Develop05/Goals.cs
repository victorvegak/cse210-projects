using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text.Json;
abstract class Goal

{
    private string _name;
    private string _description;
    protected int _basePoints;
    protected int _requiredPoints;

    public bool IsComplete{get; protected set;}

    public Goal()
    {
        _requiredPoints = 0;
        IsComplete = false;
    }

    public virtual int RecordEvent()
    {
        // Implementation
        IsComplete = CheckCompletion();
        return GetBasePoints();
    }

    public virtual bool CheckCompletion()
    {
        return IsComplete;
    }

    public void DisplayDetails()
    {
        // Implementation
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetBasePoints()
    {
        return _basePoints;
    }

    public void SetBasePoints(int basePoints)
    {
        _basePoints = basePoints;
    }

    public virtual string GetRepresentation()
    {
        return $"{GetType().Name}:{_name},{_description},{_basePoints}";
    }
    public abstract int GetPoints();


    // protected bool IsGoalComplete { get; set; } = false;
    public static Goal CreateGoalFromString(string goalString)
    {   
    try{
        string[] parts = goalString.Split(":");

        if (parts.Length == 2)
        {
            string[] details = parts[1].Split(",");

            if (details.Length >= 3)
            {
                string type = parts[0];
                string name = details[0];
                string description = details[1];
                int basePoints;

                if (int.TryParse(details[2], out basePoints))
                {
                    switch (type.ToLower())
                    {
                        case "simple":
                           
                            int requiredPoints;
                            // Console.WriteLine($"Simple Goal: {name}, {description}, {basePoints}");
                            if ( int.TryParse(details[3], out requiredPoints))
                            return new Simple(name, description, basePoints, requiredPoints);
                            break;
                            

                        case "eternal":
    
                            int eternalPoints;
                            if (int.TryParse(details[3], out eternalPoints))
                            {
                                // Console.WriteLine($"Eternal Goal: {name}, {description}, {basePoints}, {eternalPoints}");
                                return new Eternal(name, description, basePoints);
                            }
                            
                            break;

                        case "checklist":
                            int targetCount;
                            int bonusPoints;
                            if (int.TryParse(details[3], out targetCount) && int.TryParse(details[4], out bonusPoints))
                            {
                                return new Checklist(name, description, basePoints, targetCount, bonusPoints);
                            }
                            break;
                        }
                }
            }
        }
        Console.WriteLine($"Invalid goal: {goalString}");
        return null;
    
       }
    catch (Exception)
        {

            return null;
       }
    }
}
