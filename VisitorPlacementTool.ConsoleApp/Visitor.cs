namespace VisitorPlacementTool.ConsoleApp;

public class Visitor
{
    private int _groupId;
    public int VisitorId { get; private set; }
    private DateTime _dateOfBirth;
    public bool IsChild { get; private set; }
    public DateTime RegistrationTime { get; private set; }
    public Visitor(Event eventName, int groupId, int visitorId, DateTime dateOfBirth, DateTime registrationTime)
    {
        _groupId = groupId;
        _dateOfBirth = dateOfBirth;
        VisitorId = visitorId;
        if (dateOfBirth > eventName.EventDate.AddYears(-12))
        {
            IsChild = true;
        }
        else
        {
            IsChild = false;
        }
        RegistrationTime = registrationTime;
    }
}