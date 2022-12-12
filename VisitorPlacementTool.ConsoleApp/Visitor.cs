namespace VisitorPlacementTool.ConsoleApp;

public class Visitor
{
    public int GroupId { get; private set; }
   
    public int VisitorId { get; private set; }
    
    public DateTime DateOfBirth { get; private set; }
    public bool IsChild { get; private set; }
    public DateTime RegistrationTime { get; private set; }
    public Visitor(Event eventName, int groupId, int visitorId, DateTime dateOfBirth, DateTime registrationTime)
    {
        GroupId = groupId;
        DateOfBirth = dateOfBirth;
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