using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
class Simple : Goal
{
    //  private int _points;
     

    public Simple(string name, string description, int basePoints, int requiredPoints) : base()
    {
        SetName(name);
        SetDescription(description);
        SetBasePoints(basePoints);
        _requiredPoints = requiredPoints;
        
    }


    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            // _basePoints++;
            
            if (_basePoints >= _requiredPoints)
            {
                IsComplete = true;
                return GetBasePoints();
            }
            
            return GetBasePoints();
        }

        return 0;
    }
    public override string GetRepresentation()
    {
        return $"{base.GetRepresentation()}, {_requiredPoints}";
    }

    public override int GetPoints()
    {
        return _basePoints;
    }
    public int GetRequiredPoints()
    {
        return _requiredPoints;
    }
    public override bool CheckCompletion()
    {
        
        return IsComplete;
    }
}