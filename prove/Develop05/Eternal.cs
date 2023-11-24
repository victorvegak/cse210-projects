using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class Eternal : Goal
{
    // protected int _eternalPoints;

    public Eternal(string name, string description,int basePoints): base()
    {
        SetName(name);
        SetDescription(description);
        // _eternalPoints = eternalPoints;
        SetBasePoints(basePoints);
    }

    public override int RecordEvent()
    {
        // Add specific logic for the Eternal class
        return _basePoints;
    }

    public override string GetRepresentation()
    {
        return $"{base.GetRepresentation()},{_basePoints}";
    }

    public override int GetPoints()
    {
        // For eternal goals, you may want to return points based on some logic
        return _basePoints;
    }
}



