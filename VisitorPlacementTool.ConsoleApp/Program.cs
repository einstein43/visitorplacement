using VisitorPlacementTool.ConsoleApp;
//csvmanager aanmaken



Event testEvent = new Event(DateTime.Today, 2);
visitorCsv csvManager = new visitorCsv();


List<Visitor> previousVisitors = csvManager.GetPreviousRegisteredVisitorInfo(testEvent);

//stop oude visitors in groepen
testEvent.AddPreviousVisitorsToGroup(testEvent, previousVisitors);




//vier visitors toevoegen aan CSV bestand


/* visitorCsv csvManager = new visitorCsv();

csvManager.SaveVisitorInfo(new Visitor(testEvent, 1, 1, new DateTime(2002, 12, 31),
        new DateTime(2022, 12, 3)));
csvManager.SaveVisitorInfo(new Visitor(testEvent, 1, 2, new DateTime(2015, 12, 31),
    new DateTime(2022, 12, 2)));
csvManager.SaveVisitorInfo(new Visitor(testEvent, 1, 3, new DateTime(2002, 12, 31),
    new DateTime(2022, 9, 7)));
csvManager.SaveVisitorInfo(new Visitor(testEvent, 1, 4, new DateTime(2002, 12, 31),
    new DateTime(2022, 12, 12))); */

Box box1 = new Box("A", 3, 10);
Box box2 = new Box("B", 2, 5);

box1.PlaceVisitor(testEvent.FilterVisitors(testEvent.ListOfGroups)); //lijst moet niet steeds herbruikt worden want dan komen er dubbele gasten, dus ff naar kijken xxx

for (int i = 0; i < box1.chairs.GetLength(0); i++)
{
    Console.WriteLine(box1.GetRowInfo(i));
}

Console.ReadLine();

