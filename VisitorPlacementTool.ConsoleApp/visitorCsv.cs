using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementTool.ConsoleApp
{
    public class visitorCsv
    {
        //methode die visitors in een csv bestand plaatst
        public void SaveVisitorInfo(Visitor visitor)
        {
            string visitorInfo = visitor.VisitorId + "," + visitor.DateOfBirth + "," + visitor.GroupId;

            using (StreamWriter writer = new StreamWriter("visitors.csv", true))
            {
                writer.WriteLine(visitorInfo);
            }
        }

        //methode die visitors uit een csv haalt en ze aanmaakt als visitor
        /*public List<Visitor> ReadVisitorInfo(string filePath, string eventName)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] visitorInfo = line.Split(',');
                    int visitorId = int.Parse(visitorInfo[0]);
                    DateTime dateOfBirth = DateTime.Parse(visitorInfo[1]);
                    int groupId = int.Parse(visitorInfo[2]);


                    

                    // Do something with the visitor information
                }
            }
        }*/
        public List<Visitor> GetPreviousRegisteredVisitorInfo(Event eventName)
        {
            List<Visitor> previousVisitors = new List<Visitor>();
            using (StreamReader reader = new StreamReader("visitors.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    Visitor visitor = new Visitor(eventName, Convert.ToInt32(values[2]), Convert.ToInt32(values[0]), DateTime.Parse(values[1]), DateTime.Now);
                   
                    previousVisitors.Add(visitor);
                }
            }
            return previousVisitors;
        }
    }
}
