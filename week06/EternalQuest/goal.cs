// File: Goal.cs
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual string Name => _name;
    public virtual string Description => _description;
    public virtual int Points => _points;

    public abstract void RecordEvent();
    public virtual int GetPoints() => _points;
    public virtual string GetDetailsString() => $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description})";
    public abstract string GetStringRepresentation();
    public virtual bool IsComplete() => false;
}
