abstract class Goal
{
    string _name;
    string _description;
    int _numberOfPoints;
    bool _status;
    string _goalType;
    public Goal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = goalType;

    }
    public Goal()
    {

    }
    public string GetName()
    {
        return $"{_name}";
    }
    public void SetName(string name1)
    {
        _name = name1;
    }
    public string GetDescription()
    {
        return $"{_description}";
    }
    public void SetDescription(string descript)
    {
        _description = descript;
    }
    public int GetPoints()
    {
        return _numberOfPoints;
    }
    public void SetPoints(int point1)
    {
        _numberOfPoints = point1;
    }
    public bool GetStatus()
    {
        return _status;
    }
    public void MarkComplete()
    {
        _status = true;
    }
    public virtual string GetGoalType()
    {
        return $"{_goalType}";
    }
    public override string ToString()
    {
        return $"{_name}, {_description}, {_numberOfPoints}, {_status}, {_goalType}";
    }
    public abstract int RecordEvent();
    public abstract void RunGoal();
}