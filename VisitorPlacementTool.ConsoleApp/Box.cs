namespace VisitorPlacementTool.ConsoleApp;

public class Box
{
    private readonly string _letter;
    public Chair[,]? chairs;

    public Box(string letter, int rows, int chairsPerRow)
    {
        if (rows > 3 || rows < 1)
        {
            throw new InvalidOperationException("Rows must be between 1 and 3.");
        }

        if (chairsPerRow > 10 || chairsPerRow < 3)
        {
            throw new InvalidOperationException("Chairs per row must be between 3 and 10.");
        }

        _letter = letter;
        chairs = new Chair[rows, chairsPerRow];
    }
    
    public string GetRowInfo(int row)
    {
        string rowInfo = "";
        for (int i = 0; i < chairs.GetLength(1); i++)
        {
            if (chairs[row, i] == null)
            {
                rowInfo += $"{_letter}{row + 1}-{i + 1} empty  ";
            }
            else
            {
                rowInfo += $"{_letter}{row + 1}-{i + 1} vis({chairs[row, i].AssignedVisitor.VisitorId}) ";
            }
            
        }

        return rowInfo;
    }

    public void PlaceVisitor(List<Visitor> visitors)
    {
        foreach (Visitor visitor in visitors)
        {
            GetFirstFreeChair().AssignVisitor(visitor);
        }
    }

    private Chair GetFirstFreeChair()
    {
        for (int i = 0; i < chairs.GetLength(0); i++)
        {
            for (int j = 0; j < chairs.GetLength(1); j++)
            {
                if (chairs[i, j] == null)
                {
                    chairs[i, j] = new Chair();
                }
                if (chairs[i, j].AssignedVisitor == null)
                {
                    return chairs[i, j];
                } // moet dit nog verder genest worden?
            }
        }

        return null;
    }
}