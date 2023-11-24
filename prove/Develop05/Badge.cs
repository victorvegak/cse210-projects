
class Badge
{
    private string _name;
    private string _description;
    private bool _isEarned;

    public string Name => _name;
    public string Description => _description;
    public bool IsEarned => _isEarned;

    public Badge(string name, string description)
    {
        _name = name;
        _description = description;
        _isEarned = false;
    }

    public void EarnBadge()
    {
        _isEarned = true;
    }
}