// File: ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonusPoints;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
        }
    }

    public override int GetPoints()
    {
        return _currentCount == _targetCount ? _points + _bonusPoints : _points;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetDetailsString() => $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description}) -- Completed {_currentCount}/{_targetCount}";

    public override string GetStringRepresentation() => $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_bonusPoints}|{_currentCount}";
}
