using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class Checklist : Goal
{
    private int _completedItems;
    private int _targetCount;
    private int _bonusPoints;

    public Checklist(string name, string description, int basePoints, int targetCount, int bonusPoints) : base()
    {
        SetName(name);
        SetDescription(description);
        SetBasePoints(basePoints);
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
        _completedItems = 0;
        _requiredPoints = basePoints ;
    }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            _completedItems++;

            if (_completedItems >= _targetCount)
            {
                IsComplete = true;
                return GetBasePoints() + _bonusPoints; // Return only the bonus points when the goal is completed
            }
            return GetBasePoints();
        }

        return 0;
    }

    public override string GetRepresentation()
    {
        return $"{base.GetRepresentation()},{_targetCount},{_bonusPoints},{_completedItems}";
    }

    public override int GetPoints()
    {
        return _completedItems * GetBasePoints() + (_completedItems >= _targetCount ? GetBasePoints() : 0);
    }

    public int TargetCount => _targetCount;
    public int CompletedItems => _completedItems;
}