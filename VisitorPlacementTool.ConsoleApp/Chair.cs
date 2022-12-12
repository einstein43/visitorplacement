namespace VisitorPlacementTool.ConsoleApp;

public class Chair
{
    public bool IsOccupied
    {
        get
        {
            return AssignedVisitor != null;
        }
    }

    public Visitor? AssignedVisitor { get; private set; }
    
    public Chair()
    {
        
    }
    
    public void AssignVisitor(Visitor visitor)
    {
        AssignedVisitor = visitor;
    }
}