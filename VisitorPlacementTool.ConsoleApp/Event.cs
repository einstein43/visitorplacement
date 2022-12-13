namespace VisitorPlacementTool.ConsoleApp;

public class Event
{
    public DateTime EventDate { get; private set; }
    private DateTime _signupEndDate;
    public List<List<Visitor>> ListOfGroups = new List<List<Visitor>>();
    public List<Visitor> FilteredVisitorList = new List<Visitor>();
    private int _maxVisitors;
    
    public Event(DateTime eventDate, int maxVisitors)
    {
        EventDate = eventDate;
        _signupEndDate = eventDate.AddDays(-7);
        _maxVisitors = maxVisitors;
    }
    
    public void AddGroup(List<Visitor> group)
    {
        ListOfGroups.Add(group);
    }
    
    public List<Visitor> FilterVisitors(List<List<Visitor>> listOfGroups)
    {
        List<Visitor> FullVisitorList = listOfGroups.SelectMany(x => x).OrderBy(x => x.RegistrationTime).ToList();;
        for (int i = 0; i < _maxVisitors && i < _maxVisitors; i++)
        {
            if (FullVisitorList[i].RegistrationTime < _signupEndDate)
            {
                FilteredVisitorList.Add(FullVisitorList[i]);
            }
        }
        return FilteredVisitorList;
    }

    private List<Visitor> OrderByAge(List<Visitor> visitorList)
    {
        visitorList.OrderBy(x => x.DateOfBirth);
        foreach (Visitor visitor in visitorList)
        {
            if (visitorList[i].DateOfBirth + 18 >= DateTime.Now)
            {

            }

        }

            return visitorList;
    }


    public void AddPreviousVisitorsToGroup(Event eventName, List<Visitor> previousVisitors)
    {

        while (previousVisitors.Count > 0)
        {
          
                int i = previousVisitors[0].GroupId;
                List<Visitor> group = new List<Visitor>();

                foreach (Visitor visitor in previousVisitors.ToList())
                {
                    if (visitor.GroupId == i)
                    {
                        group.Add(visitor);

                    }

                    previousVisitors.RemoveAt(0);
                }

                // voegt een visitor groep toe aan de lijst met groepen van een event
                eventName.AddGroup(group);
            
           
        }
    }
}