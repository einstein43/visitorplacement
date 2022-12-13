using VisitorPlacementTool.ConsoleApp;




Event testEvent = new Event(DateTime.Today, 2);
//csvmanager aanmaken
visitorCsv csvManager = new visitorCsv();

List<Visitor> previousVisitors = csvManager.GetPreviousRegisteredVisitorInfo(testEvent);

//stop oude visitors in groepen
testEvent.AddPreviousVisitorsToGroup(testEvent, previousVisitors);

Box box1 = new Box("A", 3, 10);
Box box2 = new Box("B", 2, 5);

box1.PlaceVisitor(testEvent.FilterVisitors(testEvent.ListOfGroups)); //lijst moet niet steeds herbruikt worden want dan komen er dubbele gasten, dus ff naar kijken xxx

for (int i = 0; i < box1.chairs.GetLength(0); i++)
{
    Console.WriteLine(box1.GetRowInfo(i));
}

Console.ReadLine();

